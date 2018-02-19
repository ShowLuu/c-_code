using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoubleBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] total;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strText = textBox1.Text;
            string[] strArr = strText.Split(',');          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            total=new int[7];
            for (int i = 0; i < total.Length;i++ )
            {
                total[i] = r.Next(1, 34);
                if(i==6){
                    total[i] = r.Next(1,16);
                }

            }
            string[] result = total.Select(i => i.ToString()).ToArray();
            string str = string.Join(",", result);
            string str1 = System.Text.RegularExpressions.Regex.Replace(str, ",", "");
            textBox2.Text = str;

            string strText = textBox1.Text;
            string[] strArr = strText.Split(',');

            for (int i = 0; i < 6; i++)
            {
                int count=0;
                textBox3.Text = "一个都没猜中";
                if (strArr[i] == result[i])
                {
                    count++;
                    textBox3.Text = "猜中"+count+"个数很遗憾";
                    if(count==5){
                        textBox3.Text = "猜中" + count + "个数，鼓励奖";
                    }
                    if (count == 6)
                    {
                        textBox3.Text = "猜中" + count + "个数，特等奖";
                    }
                    if (count == 7)
                    {
                        textBox3.Text = "恭喜你，全中，中大奖";
                    }
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font("楷书", 9, FontStyle.Bold);
             this.label1.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font("楷书", 9, FontStyle.Bold);
            this.label1.ForeColor = Color.Red;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
