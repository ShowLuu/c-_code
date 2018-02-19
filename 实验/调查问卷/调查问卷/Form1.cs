using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 调查问卷
{
    public partial class Form1 : Form
    {
        String res_1 = "";
        String res_2 = "";
        String res_3 = "";
        String res_4 = "";
        String res_5 = "";
        String res_6 = "";
        String res_7 = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked)
                res_1 = radioButton1.Text;
            else if (radioButton2.Checked)
                res_1 = radioButton2.Text;
            else if (radioButton3.Checked)
                res_1 = radioButton3.Text;
            else if (radioButton4.Checked)
                res_1 = radioButton4.Text;
            else if (radioButton5.Checked)
                res_1 = radioButton5.Text;

            if (radioButton6.Checked)
                res_2 = radioButton6.Text;
            else if (radioButton7.Checked)
                res_2 = radioButton7.Text;
            else if (radioButton8.Checked)
                res_2 = radioButton8.Text;
            else if (radioButton9.Checked)
                res_2 = radioButton9.Text;
            else if (radioButton10.Checked)
                res_2 = radioButton10.Text;
            else if (radioButton11.Checked)
                res_2 = radioButton11.Text;

            if (radioButton12.Checked)
                res_3 = radioButton12.Text;
            else if (radioButton13.Checked)
                res_3 = radioButton13.Text;
            else if (radioButton14.Checked)
                res_3 = radioButton14.Text;
            else if (radioButton15.Checked)
                res_3 = radioButton15.Text;
            else if (radioButton16.Checked)
                res_3 = radioButton16.Text;
            else if (radioButton17.Checked)
                res_3 = radioButton17.Text;
            else if (radioButton18.Checked)
                res_3 = radioButton18.Text;

            if (radioButton19.Checked)
                res_4 = radioButton19.Text;
            else if (radioButton20.Checked)
                res_4 = radioButton20.Text;
            else if (radioButton21.Checked)
                res_4 = radioButton21.Text;
            else if (radioButton22.Checked)
                res_4 = radioButton22.Text;
            else if (radioButton23.Checked)
                res_4 = radioButton23.Text;

            if(checkBox1.Checked)
                res_5 = checkBox1.Text; 
            else{
                if(checkBox2.Checked)
                res_5 = checkBox2.Text;
            else if (checkBox3.Checked)
                res_5 = checkBox3.Text;
            else if (checkBox4.Checked)
                res_5 = checkBox4.Text;
            else if (checkBox5.Checked)
                res_5 = checkBox5.Text;
            }

            if (checkBox6.Checked)
                res_6 = checkBox6.Text;
            else if (checkBox7.Checked)
                res_6 = checkBox7.Text;
            else if (checkBox8.Checked)
                res_6 = checkBox8.Text;
            else if (checkBox9.Checked)
                res_6 = checkBox9.Text;
            else if (checkBox10.Checked)
                res_6 = checkBox10.Text;
            else if (checkBox11.Checked)
                res_6 = checkBox11.Text;

            if (checkBox12.Checked)
                res_7 = checkBox12.Text;
            else if (checkBox13.Checked)
                res_7 = checkBox13.Text;
            else if (checkBox14.Checked)
                res_7 = checkBox14.Text;
            else if (checkBox15.Checked)
                res_7 = checkBox15.Text;
            else if (checkBox16.Checked)
                res_7 = checkBox16.Text;
            else if (checkBox17.Checked)
                res_7 = checkBox17.Text;

            /*
          foreach(Control control in groupBox1.Controls){
              if (control is RadioButton)
              {
                  RadioButton t = (RadioButton)control;
                  res_1=t.Text.ToString();
              } 
          }

          foreach (Control control in groupBox2.Controls)
          {
              if (control is RadioButton)
              {
                  RadioButton t = (RadioButton)control;
                  res_2 = t.Text.ToString();
              }
          }
              * */

            string name = textBox1.Text;
            string age = textBox2.Text;

            string gender = "";
            if(comboBox1.Text=="男"){
                gender = "先生";
            }else if(comboBox1.Text=="女"){
                gender = "女士";
            }

            string str = name+"("+age+")"+gender+" 您好！"+"\n"+"\t"
                +"\n"+"\t"
                + groupBox1.Text + "\n" + "    " + res_1 + "\n" + "\t"
                + groupBox2.Text + "\n" + "    " + res_2 + "\n" + "\t"
                + groupBox3.Text + "\n" + "    " + res_3 + "\n" + "\t"
                + groupBox4.Text + "\n" + "    " + res_4 + "\n" + "\t"
                + label8.Text + "\n"  + "    " + res_5 + "\n" + "\t"
                + label10.Text + "\n" + "    " + res_6 + "\n" + "\t"
                + label12.Text + "\n" + "    " + res_7 + "\n" + "\t"
                ;
             MessageBox.Show(str,"调查问卷结果显示");
         
        }

    }
}
