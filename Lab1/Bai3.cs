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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text.Trim());
            string text1="";
            switch(number)
            {
                case 1:
                    text1 = "Một";
                    break;
                case 2:
                    text1 = "Hai";
                    break;
                case 3:
                    text1 = "Ba";
                    break;
                case 4:
                    text1 = "Bốn";
                    break;
                case 5:
                    text1 = "Năm";
                    break;
                case 6:
                    text1 = "Sáu";
                    break;
                case 7:
                    text1 = "Bảy";
                    break;
                case 8:
                    text1 = "Tám";
                    break;
                case 9:
                    text1 = "Chín";
                    break;
            }
            textBox2.Text = text1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
