namespace lab02
{
    partial class lab2_main
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 66);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 0;
            label1.Text = "LAB02 - 25522114";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button1.Location = new Point(122, 155);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button2.Location = new Point(122, 222);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button3.Location = new Point(122, 289);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button4.Location = new Point(308, 155);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 255);
            button5.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button5.Location = new Point(308, 222);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 255, 255);
            button6.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button6.Location = new Point(308, 289);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "Bài 6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 255);
            button7.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button7.Location = new Point(214, 362);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 7;
            button7.Text = "Bài 7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lab2_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 453);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "lab2_main";
            Text = "lab2_main";
            Load += lab2_main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}