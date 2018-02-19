using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单的文件管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                listBox1.MultiColumn = true;
            if (radioButton2.Checked)
                listBox1.MultiColumn = false;
            this.listBox1.Items.Clear();
            String path = this.comboBox1.Text;
            if (path.Length > 0)
            {
                if (System.IO.Directory.Exists(path))
                {
                    String[] files = System.IO.Directory.GetFileSystemEntries(path);
                    this.listBox1.Items.AddRange(files);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (listBox1.SelectedIndex < 0)
                MessageBox.Show("请选定显示文件", "未选定提示框");
            else
                textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n;
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            { toolStripProgressBar1.Value = toolStripProgressBar1.Minimum; }
            else
            { toolStripProgressBar1.PerformStep(); }
            n = 100 * (toolStripProgressBar1.Value - toolStripProgressBar1.Minimum) / (toolStripProgressBar1.Maximum - toolStripProgressBar1.Minimum);
            toolStripStatusLabel3.Text = Convert.ToInt16(n).ToString() + "%";
            if (comboBox2.SelectedIndex == 0)
            {
                this.listView1.View = View.LargeIcon;
                toolStripStatusLabel1.Text = "以大图标方式显示";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                this.listView1.View = View.SmallIcon;
                toolStripStatusLabel1.Text = "以小图标方式显示";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                this.listView1.View = View.List;
                toolStripStatusLabel1.Text = "以列表方式显示";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                this.listView1.View = View.Details;
                toolStripStatusLabel1.Text = "以详细资料方式显示";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                MessageBox.Show("你现在看到的是光盘图标");
            else
                MessageBox.Show("你现在看到的是磁盘图标");
        }
    }
}
