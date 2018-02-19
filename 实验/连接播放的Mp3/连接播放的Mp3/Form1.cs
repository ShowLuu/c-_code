using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace File
{
    /// <summary>
    /// Form1 的摘要说明。
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axMediaPlayer1 = new AxMediaPlayer.AxMediaPlayer();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MP3文件|*.mp3";
            this.openFileDialog1.Multiselect = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "浏览";
            this.button1.Click = new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "播放";
            this.button2.Click = new System.EventHandler(this.button2_Click);
            // 
            // axMediaPlayer1
            // 
            this.axMediaPlayer1.Location = new System.Drawing.Point(0, 152);
            this.axMediaPlayer1.Name = "axMediaPlayer1";
            this.axMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer1.OcxState")));
            this.axMediaPlayer1.Size = new System.Drawing.Size(392, 144);
            this.axMediaPlayer1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "暂停";
            this.button4.Click = new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "停止 ";
            this.button5.Click = new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(320, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "上一首";
            this.button6.Click = new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(320, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "下一首";
            this.button7.Click = new System.EventHandler(this.button7_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                        this.columnHeader1,
                                                                                        this.columnHeader2,
                                                                                        this.columnHeader3,
                                                                                        this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 8);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 144);
            this.listView1.TabIndex = 9;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " 曲名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "作者";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "大小";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "      位   置";
            this.columnHeader4.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.axMediaPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "演示播放MP3文件";
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {//浏览MP3文件
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.listView1.Items.Clear();
                string []FileNames=this.openFileDialog1.FileNames;
                foreach(string FileName in FileNames)
                {
                    //取得文件大小
                    FileInfo MyFileInfo=new FileInfo(FileName);
                    float MyFileSize=(float)MyFileInfo.Length/(1024*1024);
                    this.axMediaPlayer1.FileName=FileName;
                    //取得作者信息
                    string MyAuthor=this.axMediaPlayer1.GetMediaInfoString(MediaPlayer.MPMediaInfoType.mpClipAuthor);
                    //取得不含路径的文件名
                    string MyShortFileName=FileName.Substring(FileName.LastIndexOf("\\") 1);                
                    MyShortFileName=MyShortFileName.Substring(0,MyShortFileName.Length-4);
                    //填充歌曲列表    
                    string[] SubItem={MyShortFileName,MyAuthor,MyFileSize.ToString().Substring(0,4) "M",FileName};
                    ListViewItem Item=new ListViewItem(SubItem);
                    this.listView1.Items.Add(Item);
                    this.listView1.Items[0].Selected=true;                  
                }                               
                 
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {//播放MP3文件
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    int iPos = this.listView1.SelectedItems[0].Index;
                    string FileName = this.listView1.Items[iPos].SubItems[3].Text;
                    this.axMediaPlayer1.FileName = FileName;
                    this.axMediaPlayer1.Play();
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button4_Click(object sender, System.EventArgs e)
        {//暂停播放
            if (this.axMediaPlayer1.FileName.Length > 0)
                this.axMediaPlayer1.Pause();
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {//停止播放
            if (this.axMediaPlayer1.FileName.Length > 0)
                this.axMediaPlayer1.Stop();
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {//上一首歌曲
            if (this.listView1.Items.Count > 0)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    int iPos = this.listView1.SelectedItems[0].Index;
                    if (iPos > 0)
                    {
                        this.listView1.Items[iPos - 1].Selected = true;
                        string FileName = this.listView1.Items[iPos - 1].SubItems[3].Text;
                        this.axMediaPlayer1.FileName = FileName;
                        this.axMediaPlayer1.Play();
                    }
                    else
                    {
                        MessageBox.Show("已经是第一首歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, System.EventArgs e)
        {//下一首歌曲
            if(this.listView1.Items.Count>0)
            {
                if(this.listView1.SelectedItems.Count>0)
                {
                    int iPos=this.listView1.SelectedItems[0].Index;
                    if(iPos<this.listView1.Items.Count-1)
                    {
                        this.listView1.Items[iPos 1].Selected=true;
                        string FileName=this.listView1.Items[iPos 1].SubItems[3].Text;
                        this.axMediaPlayer1.FileName=FileName;
                        this.axMediaPlayer1.Play();                 
                    }
                    else
                    {
                        MessageBox.Show("已经是最后一首歌曲！","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择歌曲！","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
        }
    }
}