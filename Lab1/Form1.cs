using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 f2 = new bai2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 f3 = new Bai3();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 f4 = new Bai4();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 f5 = new Bai5();
            f5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai6 f6 = new Bai6();
            f6.Show();
        }
    }
}
