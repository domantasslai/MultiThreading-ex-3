using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        StreamWriter outputFile = new StreamWriter("C:\\Users\\doman\\Desktop\\created.arff", append: true);
		ManualResetEvent resetEvent = new ManualResetEvent(true);
		//public bool iseiti = true;
		public bool iseiti= true;
		public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
			FormClosing += Form1_FormClosing;
			progressBar1.Maximum = 3996;
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Location.Text = folderBrowserDialog1.SelectedPath;
            }
			try { string[] readText = File.ReadAllLines(Location.Text + "\\fixed_1 Dziaugsmas_01.arff");
				readText = readText.Skip(2).ToArray();
				foreach (string s in readText)
				{
					listBox1.Items.Add(s);
					if (s == "")
						return;
				}
			}
			catch(Exception)
			{ }
            
        }
       
		private void button1_Click(object sender, EventArgs e)
		{
			MoveListBoxItems(listBox1, listBox2);
		}
		private void button2_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBox2, listBox1);
        }
		private void MoveListBoxItems(ListBox source, ListBox destination)
		{
			ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
			foreach (var item in sourceItems)
			{
				destination.Items.Add(item);
			}
			while (source.SelectedItems.Count > 0)
			{
				source.Items.Remove(source.SelectedItems[0]);
			}
		}

		private void startBtn_Click(object sender, EventArgs e)
        {
            createFile();
			Task t2 = Task.Factory.StartNew(doStuff);
			
			
		}

        private void writeToFile(int whichword, string current)
        {
            int counter = 0;
            string delim = ",";
            string[] fields = null;
            string liness = null;
            StreamReader sr = new StreamReader(current);
            for (var i = 0; i < 6560; i++)
            {
                sr.ReadLine();
            }
            while (!sr.EndOfStream)
            {
                liness = sr.ReadLine();
                liness.Trim();
                fields = liness.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
                outputFile.Write(fields[whichword] + ",");
            }
        }
        private void doStuff()
        {
            int listBoxItmes = 0;
            listBoxItmes = listBox2.Items.Count;
            int counter = 0;
            const Int32 BufferSize = 4096;
            var txtFiles = Directory.EnumerateFiles(Location.Text, "*.arff");
            foreach (string currentFile in txtFiles)
            {
                using (var fileStream = File.OpenRead(currentFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
					try
					{
						string lines;
						while ((lines = streamReader.ReadLine()) != null)
						{
							for (int i = 0; listBoxItmes > i; i++)
							{
								if (lines == listBox2.Items[i].ToString())
								{
									writeToFile(counter - 2, currentFile);
									iseiti = false;
								}
							}
							counter++;
							//iseiti = true;
						}
					}

					catch (Exception ex)
					{
						MessageBox.Show("Klaida: " + ex);
					}
                }
                counter = 0;
                this.BeginInvoke((MethodInvoker)delegate
                {
					if (progressBar1.Value != progressBar1.Maximum)
					{
						progressBar1.Value += 1;
					}
					else
					{
						progressBar1.Value = 0;
					}
                });
            }
			MessageBox.Show("isejo");
			iseiti = true;

		}
        private void createFile()
        {
            outputFile.WriteLine("@relation SMILEfeatures");
            outputFile.WriteLine("");
            foreach (string line in listBox2.Items)
                outputFile.WriteLine(line);
            outputFile.WriteLine("");
            outputFile.WriteLine("@data");
            outputFile.WriteLine("");
        }

		private void Pausebtn_Click(object sender, EventArgs e)
		{
			/*if (task1 != null && !task1.IsPaused())
			{
				task1.reset
			}*/
			resetEvent.Reset();
		}

		private void Resumebtn_Click(object sender, EventArgs e)
		{
			resetEvent.Set();
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			if (e.CloseReason == CloseReason.WindowsShutDown) return;

			DialogResult dialog = MessageBox.Show(this, "Are you sure want to close?", "Closing", MessageBoxButtons.YesNo);
			//if (iseiti==true) {
				if (dialog == DialogResult.No)
				{
					e.Cancel = false;

				}
			//}
		}


		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
				if (iseiti == true)
				{
				//Application.Exit();
				//e.Cancel = true;
				MessageBox.Show(" " + iseiti);
				}
				else if(iseiti == false)
				{
					MessageBox.Show("Application still working!!!"+ iseiti);
				}
			
		}
	}
}

