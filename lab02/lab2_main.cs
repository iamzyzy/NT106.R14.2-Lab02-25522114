using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab02
{
    public partial class lab2_main : Form
    {
        public lab2_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.Show();
        }

        private void lab2_main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 b1 = new bai2();
            b1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 b1 = new bai3();
            b1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 b1 = new bai4();
            b1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 b1 = new bai5();
            b1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bai6 b1 = new bai6();
            b1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bai7 b1 = new bai7();
            b1.Show();
        }
    }
}
