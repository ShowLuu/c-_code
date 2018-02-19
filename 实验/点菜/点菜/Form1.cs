using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 点菜
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count;i++ )
            {
                listBox2.Items.Add(listBox1.SelectedItem); 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            bool b = true;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (str == listBox1.Items[i].ToString())
                {
                    b = false;
                    MessageBox.Show("已经添加过了");
                    break;
                }
            }

            if(b)
                listBox1.Items.Add(str);
                textBox1.Text = "";                     
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
