using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简易记事本
{
    public partial class Form1 : Form
    {
        string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void mnufile_new_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Modified)
            {
                if (MessageBox.Show("内容已修改，是否保存？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    mnufile_save_Click(sender,e);
            }
            richTextBox1.Clear();
            filename = "";
            this.Text = "简易记事本";
        }

        private void mnufile_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "RTF file( * .rtf)| * .rtf";
            dialog.FilterIndex = 1;
            if(dialog.ShowDialog()==DialogResult.OK&&dialog.FileName!="")
            {
                filename = dialog.FileName;
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                this.Text = "简易记事本 - " + filename;
            }
        }

        private void mnufile_save_Click(object sender, EventArgs e)
        {
            if (filename == null || filename == "")
                mnufile_saveas_Click(sender, e);
            else 
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                richTextBox1.Modified = false;
            }
                
            
        }

        private void mnufile_saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "RTF file( * .rtf)| * .rtf";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileName != "")
            {
                filename = dialog.FileName;
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                richTextBox1.Modified = false;
                this.Text = "文字编辑器" + filename;
            }
        }

        private void mnufile_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuedit_undo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }

        private void mnuedit_copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void mnuedit_cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void mnuedit_paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Rtf));
        }

        private void mnuedit_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void mnuview_tool_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void mnuview_stat_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void mnuform_font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.Color = richTextBox1.SelectionColor;
            font.Font = richTextBox1.SelectionFont;
            if(font.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
                richTextBox1.SelectionColor = font.Color;
            }
        }

        private void mnuform_wordwrap_Click(object sender, EventArgs e)
        {
            mnuform_wordwrap.Checked = richTextBox1.WordWrap;
        }

        private void mnuform_color_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = true;
            color.AnyColor = true;
            color.Color = richTextBox1.SelectionColor;
            if (color.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = color.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified)
                if (MessageBox.Show("文件没有保存,是否退出？", "警告", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statu2.Text = DateTime.Now.ToLongTimeString();
        }

        private void copybutton_Click(object sender, EventArgs e)
        {
            mnuedit_copy_Click(sender, e);
        }

        private void cutbutton_Click(object sender, EventArgs e)
        {
            mnuedit_cut_Click(sender,e);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            mnufile_save_Click(sender,e);
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            mnufile_new_Click(sender,e);
        }

        private void 复制toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mnuedit_copy_Click(sender, e);
        }

        private void 粘贴toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mnuedit_paste_Click(sender, e);
        }

        private void 剪贴toolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuedit_cut_Click(sender, e);
        }

        private void 退出toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
