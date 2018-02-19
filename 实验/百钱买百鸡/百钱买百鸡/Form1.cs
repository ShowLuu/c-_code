using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 百钱买百鸡
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 20; x++)
            {
                //母鸡的上线
                for (int y = 1; y < 33; y++)
                {
                    //剩余小鸡
                    int z = 100 - x - y;

                    if ((z % 3 == 0) && (x * 5 + y * 3 + z / 3 == 100))
                    {
                        label1.Text+="    公鸡:" + x + "只，母鸡:" + y + "只,小鸡:" + z + "只"+"\n";
                    }
                }
            }
        }
    }
}
