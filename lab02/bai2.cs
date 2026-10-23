using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                string content = "";
                long fileSize = 0;
                string fileUrl = "";

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    fileSize = fs.Length;
                    fileUrl = fs.Name;

                    using (StreamReader reader = new StreamReader(fs))
                    {
                        content = reader.ReadToEnd();
                    }
                }

                richTextBox1.Text = content;

                txtFileName.Text = ofd.SafeFileName;
                txtSize.Text = fileSize + " bytes";
                txtUrl.Text = fileUrl;

                int lineCount = content.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
                if (string.IsNullOrEmpty(content)) lineCount = 0;
                txtLineCount.Text = lineCount.ToString();

                string[] words = content.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                txtWordsCount.Text = words.Length.ToString();

                txtCharCount.Text = content.Length.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
