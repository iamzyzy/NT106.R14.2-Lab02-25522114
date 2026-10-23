namespace lab02
{
    partial class bai5
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
            btnReadInput = new Button();
            btnProcessAndExport = new Button();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReadInput
            // 
            btnReadInput.BackColor = Color.FromArgb(192, 255, 255);
            btnReadInput.Font = new Font("Times New Roman", 10.2F);
            btnReadInput.Location = new Point(125, 41);
            btnReadInput.Name = "btnReadInput";
            btnReadInput.Size = new Size(94, 29);
            btnReadInput.TabIndex = 0;
            btnReadInput.Text = "Đọc File";
            btnReadInput.UseVisualStyleBackColor = false;
            btnReadInput.Click += btnReadInput_Click;
            // 
            // btnProcessAndExport
            // 
            btnProcessAndExport.BackColor = Color.FromArgb(192, 255, 255);
            btnProcessAndExport.Font = new Font("Times New Roman", 10.2F);
            btnProcessAndExport.Location = new Point(309, 41);
            btnProcessAndExport.Name = "btnProcessAndExport";
            btnProcessAndExport.Size = new Size(153, 29);
            btnProcessAndExport.TabIndex = 1;
            btnProcessAndExport.Text = "Xuất File thống kê";
            btnProcessAndExport.UseVisualStyleBackColor = false;
            btnProcessAndExport.Click += btnProcessAndExport_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(192, 255, 255);
            progressBar1.Location = new Point(165, 104);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 29);
            progressBar1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Times New Roman", 10.2F);
            groupBox1.Location = new Point(41, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 294);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị nội dung thống kê vé xem phim:";
            groupBox1.UseWaitCursor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(446, 262);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.UseWaitCursor = true;
            // 
            // bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 496);
            Controls.Add(groupBox1);
            Controls.Add(progressBar1);
            Controls.Add(btnProcessAndExport);
            Controls.Add(btnReadInput);
            Name = "bai5";
            Text = "bai5";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReadInput;
        private Button btnProcessAndExport;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}