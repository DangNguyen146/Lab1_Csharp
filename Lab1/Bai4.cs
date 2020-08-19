using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        public string SoTien(int a)
        {
            string var = "";
            int temp = 1;
            while (a != 0)
            {
                var=var + a%10;
                a = a / 10;
                if (temp == 3 && a/10 !=0)
                {
                    
                    var = var + ",";
                    temp = 1;
                }
                else
                    temp += 1;
            }
            string var1 = "";
            int l = var.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                var1 = var1 + var[i];
           
            }

            return var1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text.Trim());
            string var = comboBox1.GetItemText(comboBox1.SelectedItem);
            switch (var)
            {
                case "USD (Đô la Mỹ)":
                    textBox2.Text = SoTien(22772 * number).ToString();
                    textBox3.Text = "1 USD = 22,772 VND";
                    break;
                case "EUR (Đồng tiền chung châu Âu)":
                    textBox2.Text = SoTien(28132 * number).ToString();
                    textBox3.Text = "1 EUR = 28,132 VND";
                    break;
                case "GBP (Đồng Bảng Anh Đô la Mỹ)":
                    textBox2.Text = SoTien(31538 * number).ToString();
                    textBox3.Text = "1 GDB = 31,538 VND";
                    break;
                case "SGD (Đô la Singapore)":
                    textBox2.Text = SoTien(14286 * number).ToString();
                    textBox3.Text = "1 SGD = 17,286 VND";
                    break;
                case "JPY (Yên Nhật)":
                    textBox2.Text = SoTien(214 * number).ToString();
                    textBox3.Text = "1 JPY = 214 VND";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            button1.Enabled = false;
            button3.Enabled = false;
        }
    }
}
