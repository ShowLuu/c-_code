using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 算数练习器
{
    public partial class 查找替换文字 : Form
    {
        public 查找替换文字()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            string str = textBox3.Text;
            textBox3.Text = str.Replace(str1,str2);
        }

    }
}
