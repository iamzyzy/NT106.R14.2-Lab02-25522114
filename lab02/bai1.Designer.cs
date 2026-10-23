namespace lab02
{
    partial class bai1
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
            txtContent = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Times New Roman", 9F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(86, 126);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Đọc File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Times New Roman", 9F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(86, 196);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Ghi File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(251, 126);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(146, 99);
            txtContent.TabIndex = 2;
            txtContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 3;
            label1.Text = "Bài 1";
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(465, 313);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox txtContent;
        private Label label1;
    }
}