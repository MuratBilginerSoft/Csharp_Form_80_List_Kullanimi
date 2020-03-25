using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List_Kullanımı_v1._0
{
    public partial class Form1 : Form
    {
        List<int> sayılar = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayılar.Add(int.Parse(textBox1.Text));
            label2.Text += textBox1.Text + "-";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int item in sayılar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayılar.Sort();

            foreach (int item in sayılar)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayılar.Sort();
            sayılar.Reverse();

            foreach (int item in sayılar)
            {
                listBox3.Items.Add(item);
            }
        }
    }
}
