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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Box_a_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    button1.Enabled = true;
            button2.Enabled = true;
        }

        public bool IsNumber(string pValue)
        {
            if (pValue == "")
                return false;
            foreach(char c in pValue)
            {
                if (!(char.IsNumber(c)))
                    return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = (IsNumber(textBox1.Text) && IsNumber(textBox2.Text));
            if(test==true)
            {
                int n = int.Parse(textBox1.Text.Trim());
                int m = int.Parse(textBox2.Text.Trim());
                Box_Tong.Text = (n + m).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "", MessageBoxButtons.RetryCancel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            Box_Tong.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Box_Tong_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
