namespace lab02
{
    partial class bai2
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtFileName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSize = new TextBox();
            txtUrl = new TextBox();
            txtLineCount = new TextBox();
            txtWordsCount = new TextBox();
            txtCharCount = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(192, 0, 192);
            button1.Location = new Point(43, 35);
            button1.Name = "button1";
            button1.Size = new Size(278, 29);
            button1.TabIndex = 0;
            button1.Text = "Read From File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 192);
            button2.Location = new Point(43, 376);
            button2.Name = "button2";
            button2.Size = new Size(278, 29);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(43, 105);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 2;
            label1.Text = "File name:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(196, 97);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(125, 27);
            txtFileName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(43, 148);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 4;
            label2.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(43, 195);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 5;
            label3.Text = "URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(43, 237);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 6;
            label4.Text = "Line count:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(43, 284);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 7;
            label5.Text = "Word counts:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(43, 329);
            label6.Name = "label6";
            label6.Size = new Size(122, 19);
            label6.TabIndex = 8;
            label6.Text = "Character count:";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(196, 140);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 9;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(196, 187);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(125, 27);
            txtUrl.TabIndex = 10;
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(196, 229);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.Size = new Size(125, 27);
            txtLineCount.TabIndex = 11;
            // 
            // txtWordsCount
            // 
            txtWordsCount.Location = new Point(196, 276);
            txtWordsCount.Name = "txtWordsCount";
            txtWordsCount.Size = new Size(125, 27);
            txtWordsCount.TabIndex = 12;
            txtWordsCount.TextChanged += textBox5_TextChanged;
            // 
            // txtCharCount
            // 
            txtCharCount.Location = new Point(196, 321);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.Size = new Size(125, 27);
            txtCharCount.TabIndex = 13;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(362, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(336, 370);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(729, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txtCharCount);
            Controls.Add(txtWordsCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtUrl);
            Controls.Add(txtSize);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bai2";
            Text = "bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox txtFileName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSize;
        private TextBox txtUrl;
        private TextBox txtLineCount;
        private TextBox txtWordsCount;
        private TextBox txtCharCount;
        private RichTextBox richTextBox1;
    }
}