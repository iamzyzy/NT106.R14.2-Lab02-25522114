namespace lab02
{
    partial class bai4
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
            richTextBox1 = new RichTextBox();
            btnWriteFromFile = new Button();
            btnReadFromFile = new Button();
            btnAdd = new Button();
            btnBack = new Button();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtInputName = new TextBox();
            txtInputID = new TextBox();
            txtInputPhone = new TextBox();
            txtInputCourse1 = new TextBox();
            txtInputCourse2 = new TextBox();
            txtInputCourse3 = new TextBox();
            textBox7 = new TextBox();
            label8 = new Label();
            lblPageNumber = new Label();
            txtAverageOutput = new TextBox();
            txtCourse3Output = new TextBox();
            txtCourse2Output = new TextBox();
            txtCourse1Output = new TextBox();
            txtPhoneOutput = new TextBox();
            txtIDOutput = new TextBox();
            txtNameOutput = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(284, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(276, 483);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnWriteFromFile
            // 
            btnWriteFromFile.BackColor = Color.FromArgb(192, 255, 192);
            btnWriteFromFile.Font = new Font("Times New Roman", 10.2F);
            btnWriteFromFile.ForeColor = Color.Black;
            btnWriteFromFile.Location = new Point(13, 26);
            btnWriteFromFile.Name = "btnWriteFromFile";
            btnWriteFromFile.Size = new Size(252, 36);
            btnWriteFromFile.TabIndex = 1;
            btnWriteFromFile.Text = "Write to a File";
            btnWriteFromFile.UseVisualStyleBackColor = false;
            btnWriteFromFile.Click += btnReadFromFile_Click;
            // 
            // btnReadFromFile
            // 
            btnReadFromFile.BackColor = Color.FromArgb(255, 192, 255);
            btnReadFromFile.Font = new Font("Times New Roman", 10.2F);
            btnReadFromFile.Location = new Point(582, 26);
            btnReadFromFile.Name = "btnReadFromFile";
            btnReadFromFile.Size = new Size(251, 36);
            btnReadFromFile.TabIndex = 2;
            btnReadFromFile.Text = "Button to read a File";
            btnReadFromFile.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Font = new Font("Times New Roman", 10.2F);
            btnAdd.Location = new Point(88, 479);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 26);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 255);
            btnBack.Font = new Font("Times New Roman", 10.2F);
            btnBack.Location = new Point(582, 478);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 192, 255);
            btnNext.Font = new Font("Times New Roman", 10.2F);
            btnNext.Location = new Point(738, 479);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(194, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(194, 144);
            label2.Name = "label2";
            label2.Size = new Size(26, 19);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(194, 198);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(194, 253);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 9;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.Location = new Point(194, 310);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 10;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F);
            label6.Location = new Point(194, 367);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 11;
            label6.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.Location = new Point(194, 428);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 12;
            label7.Text = "Average";
            // 
            // txtInputName
            // 
            txtInputName.Location = new Point(26, 83);
            txtInputName.Name = "txtInputName";
            txtInputName.Size = new Size(125, 27);
            txtInputName.TabIndex = 13;
            // 
            // txtInputID
            // 
            txtInputID.Location = new Point(26, 136);
            txtInputID.Name = "txtInputID";
            txtInputID.Size = new Size(125, 27);
            txtInputID.TabIndex = 14;
            // 
            // txtInputPhone
            // 
            txtInputPhone.Location = new Point(26, 190);
            txtInputPhone.Name = "txtInputPhone";
            txtInputPhone.Size = new Size(125, 27);
            txtInputPhone.TabIndex = 15;
            // 
            // txtInputCourse1
            // 
            txtInputCourse1.Location = new Point(26, 245);
            txtInputCourse1.Name = "txtInputCourse1";
            txtInputCourse1.Size = new Size(125, 27);
            txtInputCourse1.TabIndex = 16;
            // 
            // txtInputCourse2
            // 
            txtInputCourse2.Location = new Point(26, 302);
            txtInputCourse2.Name = "txtInputCourse2";
            txtInputCourse2.Size = new Size(125, 27);
            txtInputCourse2.TabIndex = 17;
            // 
            // txtInputCourse3
            // 
            txtInputCourse3.Location = new Point(26, 359);
            txtInputCourse3.Name = "txtInputCourse3";
            txtInputCourse3.Size = new Size(125, 27);
            txtInputCourse3.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(26, 420);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(707, 469);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 20;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(682, 483);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(50, 20);
            lblPageNumber.TabIndex = 21;
            lblPageNumber.Text = "label9";
            // 
            // txtAverageOutput
            // 
            txtAverageOutput.Location = new Point(582, 420);
            txtAverageOutput.Name = "txtAverageOutput";
            txtAverageOutput.Size = new Size(125, 27);
            txtAverageOutput.TabIndex = 35;
            // 
            // txtCourse3Output
            // 
            txtCourse3Output.Location = new Point(582, 359);
            txtCourse3Output.Name = "txtCourse3Output";
            txtCourse3Output.Size = new Size(125, 27);
            txtCourse3Output.TabIndex = 34;
            // 
            // txtCourse2Output
            // 
            txtCourse2Output.Location = new Point(582, 302);
            txtCourse2Output.Name = "txtCourse2Output";
            txtCourse2Output.Size = new Size(125, 27);
            txtCourse2Output.TabIndex = 33;
            // 
            // txtCourse1Output
            // 
            txtCourse1Output.Location = new Point(582, 245);
            txtCourse1Output.Name = "txtCourse1Output";
            txtCourse1Output.Size = new Size(125, 27);
            txtCourse1Output.TabIndex = 32;
            // 
            // txtPhoneOutput
            // 
            txtPhoneOutput.Location = new Point(582, 190);
            txtPhoneOutput.Name = "txtPhoneOutput";
            txtPhoneOutput.Size = new Size(125, 27);
            txtPhoneOutput.TabIndex = 31;
            // 
            // txtIDOutput
            // 
            txtIDOutput.Location = new Point(582, 136);
            txtIDOutput.Name = "txtIDOutput";
            txtIDOutput.Size = new Size(125, 27);
            txtIDOutput.TabIndex = 30;
            // 
            // txtNameOutput
            // 
            txtNameOutput.Location = new Point(582, 83);
            txtNameOutput.Name = "txtNameOutput";
            txtNameOutput.Size = new Size(125, 27);
            txtNameOutput.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F);
            label10.Location = new Point(750, 428);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 28;
            label10.Text = "Average";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F);
            label11.Location = new Point(750, 367);
            label11.Name = "label11";
            label11.Size = new Size(71, 19);
            label11.TabIndex = 27;
            label11.Text = "Course 3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.2F);
            label12.Location = new Point(750, 310);
            label12.Name = "label12";
            label12.Size = new Size(71, 19);
            label12.TabIndex = 26;
            label12.Text = "Course 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.2F);
            label13.Location = new Point(750, 253);
            label13.Name = "label13";
            label13.Size = new Size(71, 19);
            label13.TabIndex = 25;
            label13.Text = "Course 1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 10.2F);
            label14.Location = new Point(750, 198);
            label14.Name = "label14";
            label14.Size = new Size(52, 19);
            label14.TabIndex = 24;
            label14.Text = "Phone";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10.2F);
            label15.Location = new Point(750, 144);
            label15.Name = "label15";
            label15.Size = new Size(26, 19);
            label15.TabIndex = 23;
            label15.Text = "ID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 10.2F);
            label16.Location = new Point(750, 91);
            label16.Name = "label16";
            label16.Size = new Size(49, 19);
            label16.TabIndex = 22;
            label16.Text = "Name";
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 531);
            Controls.Add(txtAverageOutput);
            Controls.Add(txtCourse3Output);
            Controls.Add(txtCourse2Output);
            Controls.Add(txtCourse1Output);
            Controls.Add(txtPhoneOutput);
            Controls.Add(txtIDOutput);
            Controls.Add(txtNameOutput);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(lblPageNumber);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(txtInputCourse3);
            Controls.Add(txtInputCourse2);
            Controls.Add(txtInputCourse1);
            Controls.Add(txtInputPhone);
            Controls.Add(txtInputID);
            Controls.Add(txtInputName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(btnReadFromFile);
            Controls.Add(btnWriteFromFile);
            Controls.Add(richTextBox1);
            Name = "bai4";
            Text = "bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnWriteFromFile;
        private Button btnReadFromFile;
        private Button btnAdd;
        private Button btnBack;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtInputName;
        private TextBox txtInputID;
        private TextBox txtInputPhone;
        private TextBox txtInputCourse1;
        private TextBox txtInputCourse2;
        private TextBox txtInputCourse3;
        private TextBox textBox7;
        private Label label8;
        private Label lblPageNumber;
        private TextBox txtAverageOutput;
        private TextBox txtCourse3Output;
        private TextBox txtCourse2Output;
        private TextBox txtCourse1Output;
        private TextBox txtPhoneOutput;
        private TextBox txtIDOutput;
        private TextBox txtNameOutput;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}