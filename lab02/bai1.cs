using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "input1.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        txtContent.Text = reader.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file input1.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outputPath = "output1.txt";

            try
            {
                string content = txtContent.Text.ToUpper();

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.Write(content);
                }

                MessageBox.Show("Đã ghi file output1.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
