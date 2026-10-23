namespace lab02
{
    partial class bai7
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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            richTextBoxContent = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(251, 483);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxContent);
            groupBox1.ForeColor = Color.Purple;
            groupBox1.Location = new Point(279, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 483);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Content";
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Location = new Point(3, 23);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(410, 457);
            richTextBoxContent.TabIndex = 0;
            richTextBoxContent.Text = "";
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 507);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            Name = "bai7";
            Text = "bai7";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxContent;
    }
}