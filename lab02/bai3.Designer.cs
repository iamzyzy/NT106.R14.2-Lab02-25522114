namespace lab02
{
    partial class bai3
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
            btnDocFile = new Button();
            btnTinhToan = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.FromArgb(255, 192, 192);
            btnDocFile.Location = new Point(69, 140);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(149, 29);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "Đọc file input3.txt";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnTinhToan
            // 
            btnTinhToan.BackColor = Color.FromArgb(255, 192, 192);
            btnTinhToan.Location = new Point(69, 203);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(149, 29);
            btnTinhToan.TabIndex = 1;
            btnTinhToan.Text = "Tính toán";
            btnTinhToan.UseVisualStyleBackColor = false;
            btnTinhToan.Click += btnTinhToan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(216, 51);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 2;
            label1.Text = "Bài 3";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(251, 110);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(218, 148);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 327);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(btnTinhToan);
            Controls.Add(btnDocFile);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDocFile;
        private Button btnTinhToan;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}