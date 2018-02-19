using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 算术练习器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            button1.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            Random rm = new Random();
            int a, b, c;
            a = rm.Next(1, 100);
            b = rm.Next(1, 100);
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
            switch(rm.Next(0,3)){
                case 0: c = a + b; textBox3.Text = c.ToString(); break;
                case 1: c = a + b + rm.Next(1,10); textBox3.Text = c.ToString(); break;
                case 2: c = a + b - rm.Next(1,10); textBox3.Text = c.ToString(); break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                if (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) == int.Parse(textBox3.Text))
                    textBox4.Text = "判断正确";
                else
                    textBox4.Text="判断错误";
            button1.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                if (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) == int.Parse(textBox3.Text))
                    textBox4.Text = "判断正确";
                else
                    textBox4.Text = "判断错误";
            button1.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

    }
}
