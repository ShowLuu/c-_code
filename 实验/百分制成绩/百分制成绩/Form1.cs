using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 百分制成绩
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mark;
            string grade;
            mark = double.Parse(textBox1.Text);
            if(mark>100||mark<0){
                grade = "成绩输入错误";
            }else if (mark >= 90)
                grade = "优";
            else if (mark >= 80)
                grade = "良";
            else if (mark >= 70)
                grade = "中等";
            else if (mark >= 60)
                grade = "及格";
            else
                grade = "不及格";

            textBox2.Text = grade;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int mark;
            string grade;
            int s = 0;
            mark = int.Parse(textBox1.Text);
            if((mark/10==10&&mark%10!=0)){
                textBox2.Text = "成绩输入错误";
                return;
            }
            switch (mark / 10)
            {
                case 10:
                case 9: grade = "优秀"; break;

                case 8: grade = "良"; break;

                case 7: grade = "中等"; break;

                case 6: grade = "及格"; break;
                default:

                    if ((mark / 10) > 10 || (mark / 10) < 0)
                        grade = "成绩输入错误";
                    else
                        grade = "不及格"; break;
            }
            textBox2.Text = grade;
        }
    }
}
