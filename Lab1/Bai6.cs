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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = true;
            string[] text = textBox1.Text.Trim().Split(',');
            float temp = 0;
            foreach(string c in text)
            {
                test = float.TryParse(c, out temp);
                if (test == false)
                    break;
            }

            if (test == true)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
                MessageBox.Show("Sai Format", "Lỗi!", MessageBoxButtons.RetryCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string[] text = textBox1.Text.Trim().Split(',');
            float[] Diem = new float[text.Length];
            int n = 0;
            foreach (string c in text)
            {
                Diem[n] = float.Parse(c);
                n++;
            }
            for(int i=0;i<n;i++)
            {
                
                //textBox2.Text = ("Môn " + i + ": " + Diem[i] +"\r\n").ToString();
                string sent = ("Môn " + (i+1) + ": " + Diem[i]);

                textBox2.AppendText(sent);
                textBox2.AppendText(Environment.NewLine);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Trim().Split(',');
            float Diemtb = 0;
            int n = 0;
            foreach (string c in text)
            {
                n++;
                Diemtb += float.Parse(c);
            }
            Diemtb /= n;
            textBox2.Text = ("Điểm trung bình: " + Diemtb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] text = textBox1.Text.Trim().Split(',');
            float min=10, max=0;
            foreach (string c in text)
            {
                float temp = float.Parse(c);
                if (temp > max)
                    max = temp;
                if (temp < min)
                    min = temp;
            }
            textBox2.Text = ("Điểm lớn nhất: " + max + "\r\n" + "Điểm nhỏ nhất: " + min);
        }
    }
}
