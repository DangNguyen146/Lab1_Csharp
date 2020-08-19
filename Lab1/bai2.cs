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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if (textBox3.Text != "")
                        button1.Enabled = true;
        }

        public bool IsNumber(string pValue)
        {
            if (pValue == "")
                return false;
            foreach (char c in pValue)
            {
                if (!(char.IsNumber(c)))
                    return false;
            }
            return true;
        }

        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public int Min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = (IsNumber(textBox1.Text) && IsNumber(textBox2.Text) && IsNumber(textBox3.Text));
            if (test == true)
            {
                int n = int.Parse(textBox1.Text.Trim());
                int m = int.Parse(textBox2.Text.Trim());
                int k = int.Parse(textBox3.Text.Trim());

                int max = Max(Max(n, m), k);
                int min = Min(Min(n, m), k);

                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "", MessageBoxButtons.RetryCancel);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if (textBox3.Text != "")
                        button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    if (textBox3.Text != "")
                        button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
