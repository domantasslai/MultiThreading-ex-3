namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.Location = new System.Windows.Forms.TextBox();
			this.browseBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.startBtn = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.Pausebtn = new System.Windows.Forms.Button();
			this.Resumebtn = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// Location
			// 
			this.Location.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Location.Location = new System.Drawing.Point(51, 60);
			this.Location.Margin = new System.Windows.Forms.Padding(4);
			this.Location.Name = "Location";
			this.Location.Size = new System.Drawing.Size(644, 38);
			this.Location.TabIndex = 0;
			// 
			// browseBtn
			// 
			this.browseBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseBtn.Location = new System.Drawing.Point(704, 60);
			this.browseBtn.Margin = new System.Windows.Forms.Padding(4);
			this.browseBtn.Name = "browseBtn";
			this.browseBtn.Size = new System.Drawing.Size(112, 39);
			this.browseBtn.TabIndex = 1;
			this.browseBtn.Text = "Browse";
			this.browseBtn.UseVisualStyleBackColor = true;
			this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Arff folder location";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(51, 165);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(525, 468);
			this.listBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 145);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "All atributes";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(704, 165);
			this.listBox2.Margin = new System.Windows.Forms.Padding(4);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(525, 468);
			this.listBox2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(700, 145);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Seelected atributes";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(584, 326);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 39);
			this.button1.TabIndex = 7;
			this.button1.Text = ">>>>";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(584, 373);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 39);
			this.button2.TabIndex = 8;
			this.button2.Text = "<<<<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// startBtn
			// 
			this.startBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBtn.Location = new System.Drawing.Point(51, 641);
			this.startBtn.Margin = new System.Windows.Forms.Padding(4);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(112, 39);
			this.startBtn.TabIndex = 9;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(51, 688);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(1180, 41);
			this.progressBar1.TabIndex = 10;
			// 
			// Pausebtn
			// 
			this.Pausebtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pausebtn.Location = new System.Drawing.Point(183, 640);
			this.Pausebtn.Name = "Pausebtn";
			this.Pausebtn.Size = new System.Drawing.Size(111, 41);
			this.Pausebtn.TabIndex = 11;
			this.Pausebtn.Text = "Pause";
			this.Pausebtn.UseVisualStyleBackColor = true;
			this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
			// 
			// Resumebtn
			// 
			this.Resumebtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Resumebtn.Location = new System.Drawing.Point(311, 639);
			this.Resumebtn.Name = "Resumebtn";
			this.Resumebtn.Size = new System.Drawing.Size(111, 41);
			this.Resumebtn.TabIndex = 12;
			this.Resumebtn.Text = "Resume";
			this.Resumebtn.UseVisualStyleBackColor = true;
			this.Resumebtn.Click += new System.EventHandler(this.Resumebtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 743);
			this.Controls.Add(this.Resumebtn);
			this.Controls.Add(this.Pausebtn);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.browseBtn);
			this.Controls.Add(this.Location);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button Pausebtn;
		private System.Windows.Forms.Button Resumebtn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

