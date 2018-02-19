using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 倒计时器
{
    public partial class Form1 : Form
    {
        uint reminder;
        uint minute;
        uint second;
        string msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (txtNumber.Text == "")
                    return;
                reminder = Convert.ToUInt32(txtNumber.Text) * 60;
                timer2.Enabled = false;
                timer1.Enabled = true;
                lblTimeEnd.Visible = true;
                txtTimeEnd.Visible = true;
                lblTimeStart.Text = "开始时间";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtTimeStart.Text = DateTime.Now.Hour.ToString() + ": ";
            txtTimeStart.Text += DateTime.Now.Minute.ToString() + ": ";
            txtTimeStart.Text += DateTime.Now.Second.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimeEnd.Text = DateTime.Now.Hour.ToString() + ": ";
            txtTimeEnd.Text += DateTime.Now.Minute.ToString() + ": ";
            txtTimeEnd.Text += DateTime.Now.Second.ToString();
            reminder--;
            minute = reminder / 60;
            second = reminder % 60;
            if (second < 10)
                msg = "剩余时间：" + minute + "分0" + second + "秒";
            else
                msg = "剩余时间：" + minute + "分" + second + "秒";
            lblRemainder.Text = msg;
            if (reminder == 0)
            {
                timer1.Enabled = false;
                lblRemainder.Text += "--时间到！";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblRemainder.Text = "";
            txtNumber.Text = "";
            txtNumber.Focus();
            timer2.Enabled = true;
            lblTimeEnd.Visible = false;
            txtTimeEnd.Visible = false;
        }
    }
}
