namespace lab02
{
    partial class bai6
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
            btnLoadSQLite = new Button();
            btnRandom = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTenMon = new RichTextBox();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(250, 51);
            label1.Name = "label1";
            label1.Size = new Size(174, 23);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btnLoadSQLite
            // 
            btnLoadSQLite.BackColor = Color.FromArgb(192, 255, 255);
            btnLoadSQLite.Font = new Font("Times New Roman", 10.2F);
            btnLoadSQLite.Location = new Point(100, 102);
            btnLoadSQLite.Name = "btnLoadSQLite";
            btnLoadSQLite.Size = new Size(156, 29);
            btnLoadSQLite.TabIndex = 1;
            btnLoadSQLite.Text = "Tải dữ liệu SQLite";
            btnLoadSQLite.UseVisualStyleBackColor = false;
            btnLoadSQLite.Click += btnLoadSQLite_Click;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.FromArgb(192, 255, 255);
            btnRandom.Font = new Font("Times New Roman", 10.2F);
            btnRandom.Location = new Point(429, 102);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(174, 29);
            btnRandom.TabIndex = 2;
            btnRandom.Text = "Random món ăn 🎲";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Times New Roman", 10.2F);
            groupBox1.Location = new Point(34, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 303);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách món ăn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Font = new Font("Times New Roman", 10.2F);
            groupBox2.Location = new Point(371, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 303);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả gợi ý món ăn:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTenMon
            // 
            labelTenMon.Location = new Point(404, 354);
            labelTenMon.Name = "labelTenMon";
            labelTenMon.Size = new Size(263, 89);
            labelTenMon.TabIndex = 1;
            labelTenMon.Text = "";
            // 
            // listView1
            // 
            listView1.Location = new Point(26, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(251, 245);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 502);
            Controls.Add(labelTenMon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRandom);
            Controls.Add(btnLoadSQLite);
            Controls.Add(label1);
            Name = "bai6";
            Text = "bai6";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoadSQLite;
        private Button btnRandom;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox labelTenMon;
        private PictureBox pictureBox1;
        private ListView listView1;
    }
}