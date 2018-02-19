using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 乘法表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9;i++ )
            {
                int s=0;
                for (int j = 1; j <= i;j++ )
                {
                    if(i==3&&j==3||i==4&&j==3){
                        label1.Text += " ";
                    }
                    s=i*j;
                    label1.Text += i.ToString() + "*" + j.ToString() + "=" + s.ToString() + " ";
                }
                label1.Text += "\n";
            }
        }
    }
}
