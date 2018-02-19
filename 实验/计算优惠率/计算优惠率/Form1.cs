using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算优惠率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month,count;
            double price;
            month = int.Parse(textBox1.Text);
            count = int.Parse(textBox2.Text);
            price = double.Parse(textBox3.Text);
            double result=0;
            switch (month)
            { 
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 10:
                case 11:
                    if (count >= 20){
                        result=price*(1-0.3)*count;
                        label10.Text = "优惠率为30%后 只需付款"+result+"元";
                     }
                    else
                        result = price * (1 - 0.2) * count;
                        label10.Text = "优惠率为20%后 只需付款" + result + "元";
                    break;
                case 7:
                case 8:
                case 9:
                    if (count >= 20)
                    {
                        result = price * (1 - 0.15) * count;
                        label10.Text = "优惠率为15%后 只需付款" + result + "元";
                    }
                    else
                        result = price * (1 - 0.05) * count;
                        label10.Text = "优惠率为20%后 只需付款" + result + "元";
                    break;
                default:
                    result = price * (1 - 0.1) * count;
                    label10.Text = "优惠率为20%后 只需付款" + result + "元";break;
            }
        }

 
    }
}
