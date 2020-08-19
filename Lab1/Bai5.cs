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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            groupBox1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;

            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
        }

        private long GiaiThua(int n)
        {
            if (n == 1)
                return 1;
            return n * GiaiThua(n - 1);
        }
        private long Tong(int n)
        {
            if (n == 0)
                return 0;
            return n + Tong(n - 1);
        }
        private double TongBac(int n, int m)
        {
            double tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += Math.Pow(m, i);
            }
            return tong;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            groupBox1.Enabled = true;

            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;

            int m = int.Parse(textBox1.Text.Trim());
            int n = int.Parse(textBox2.Text.Trim());

            long temp = GiaiThua(m);
            textBox3.Text = temp.ToString();
            temp = GiaiThua(n);
            textBox7.Text = temp.ToString();

            temp = Tong(m);
            textBox4.Text = temp.ToString();
            temp = Tong(n);
            textBox5.Text = temp.ToString();

            double Temp = TongBac(n, m);
            textBox6.Text = Temp.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    button1.Enabled = true;
            button2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox2.Text != "")
                    button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
