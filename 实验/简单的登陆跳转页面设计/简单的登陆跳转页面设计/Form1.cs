using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单的登陆跳转页面设计
{
    public partial class Form1 : Form
    {
       private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user")
            {
                if (textBox2.Text == "123")
                {
                    this.Hide();
                    form2.Show();
                }
                else {
                    label4.Text = "密码错误";
                }
                
            }
            else {
                label4.Text = "账号不存在";
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
