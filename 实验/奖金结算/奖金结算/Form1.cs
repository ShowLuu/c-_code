using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 奖金结算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(textBox1.Text);
                int num = Convert.ToInt32(n / 10);
                double result = 0;
                String s;
                switch (num)
                {
                    case 0: s = "10%"; result = n * 0.1; break;
                    case 1: s = "10%-7.5%"; result = 10 * 0.1 + (n - 10) * 0.075; break;
                    case 2:
                    case 3: s = "10%-5%"; result = 10 * 0.1 + 10 * 0.075 + (n - 20) * 0.005; break;
                    case 4:
                    case 5: s = "10%-3%"; result = 10 * 0.1 + 10 * 0.075 + 20 * 0.005 + (n) * 0.003; break;
                    case 6:
                    case 7:
                    case 8:
                    case 9: s = "10%-1.5%"; result = 10 * 0.1 + 10 * 0.075 + 20 * 0.005 + 20 * 0.003 + (n - 60) * 0.0015; break;
                    default: s = "10%-1%"; result = 10 * 0.1 + 10 * 0.075 + 20 * 0.005 + 20 * 0.003 + 40 * 0.0015 + (n - 100) * 0.0001; break;
                }

                label2.Text = "奖金可提成:" + s + "\n" + "应得到的奖金为：" + result + "万元";
            }
            catch( Exception )
            {
                MessageBox.Show("请输入数字信息");
            }
        }
    }
}
