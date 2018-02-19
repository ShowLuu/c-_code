using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 猴子吃桃
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0, remain = 1;
            for (int day = 9; day >= 1; day--)
            {
                sum = (remain + 1) * 2;
                remain = sum;
                label1.Text += "第" + day + "天还有" + remain + "个桃子"+"\n";
            }
        }
    }
}
