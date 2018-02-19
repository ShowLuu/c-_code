namespace 简易记事本
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufile_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufile_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufile_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufile_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnufile_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuview_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuview_stat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuform = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuform_font = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuform_wordwrap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuform_color = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.copybutton = new System.Windows.Forms.ToolStripButton();
            this.cutbutton = new System.Windows.Forms.ToolStripButton();
            this.savebutton = new System.Windows.Forms.ToolStripButton();
            this.newbutton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statu1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statu2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪贴toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.mnuedit,
            this.mnuview,
            this.mnuform});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile_open,
            this.mnufile_new,
            this.mnufile_save,
            this.mnufile_saveas,
            this.toolStripSeparator1,
            this.mnufile_exit});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(80, 28);
            this.mnufile.Text = "文件(&F)";
            // 
            // mnufile_open
            // 
            this.mnufile_open.Name = "mnufile_open";
            this.mnufile_open.Size = new System.Drawing.Size(159, 28);
            this.mnufile_open.Text = "打开(&O)";
            this.mnufile_open.Click += new System.EventHandler(this.mnufile_open_Click);
            // 
            // mnufile_new
            // 
            this.mnufile_new.Name = "mnufile_new";
            this.mnufile_new.Size = new System.Drawing.Size(159, 28);
            this.mnufile_new.Text = "新建(&N)";
            this.mnufile_new.Click += new System.EventHandler(this.mnufile_new_Click);
            // 
            // mnufile_save
            // 
            this.mnufile_save.Name = "mnufile_save";
            this.mnufile_save.Size = new System.Drawing.Size(159, 28);
            this.mnufile_save.Text = "保存(&S)";
            this.mnufile_save.Click += new System.EventHandler(this.mnufile_save_Click);
            // 
            // mnufile_saveas
            // 
            this.mnufile_saveas.Name = "mnufile_saveas";
            this.mnufile_saveas.Size = new System.Drawing.Size(159, 28);
            this.mnufile_saveas.Text = "另存为(&A)";
            this.mnufile_saveas.Click += new System.EventHandler(this.mnufile_saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // mnufile_exit
            // 
            this.mnufile_exit.Name = "mnufile_exit";
            this.mnufile_exit.Size = new System.Drawing.Size(159, 28);
            this.mnufile_exit.Text = "退出(&X)";
            this.mnufile_exit.Click += new System.EventHandler(this.mnufile_exit_Click);
            // 
            // mnuedit
            // 
            this.mnuedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuedit_undo,
            this.mnuedit_copy,
            this.mnuedit_cut,
            this.mnuedit_paste,
            this.mnuedit_clear});
            this.mnuedit.Name = "mnuedit";
            this.mnuedit.Size = new System.Drawing.Size(80, 28);
            this.mnuedit.Text = "编辑(&E)";
            // 
            // mnuedit_undo
            // 
            this.mnuedit_undo.Name = "mnuedit_undo";
            this.mnuedit_undo.Size = new System.Drawing.Size(141, 28);
            this.mnuedit_undo.Text = "撤销(&U)";
            this.mnuedit_undo.Click += new System.EventHandler(this.mnuedit_undo_Click);
            // 
            // mnuedit_copy
            // 
            this.mnuedit_copy.Name = "mnuedit_copy";
            this.mnuedit_copy.Size = new System.Drawing.Size(141, 28);
            this.mnuedit_copy.Text = "复制(&C)";
            this.mnuedit_copy.Click += new System.EventHandler(this.mnuedit_copy_Click);
            // 
            // mnuedit_cut
            // 
            this.mnuedit_cut.Name = "mnuedit_cut";
            this.mnuedit_cut.Size = new System.Drawing.Size(141, 28);
            this.mnuedit_cut.Text = "剪切(&X)";
            this.mnuedit_cut.Click += new System.EventHandler(this.mnuedit_cut_Click);
            // 
            // mnuedit_paste
            // 
            this.mnuedit_paste.Name = "mnuedit_paste";
            this.mnuedit_paste.Size = new System.Drawing.Size(141, 28);
            this.mnuedit_paste.Text = "粘贴(&P)";
            this.mnuedit_paste.Click += new System.EventHandler(this.mnuedit_paste_Click);
            // 
            // mnuedit_clear
            // 
            this.mnuedit_clear.Name = "mnuedit_clear";
            this.mnuedit_clear.Size = new System.Drawing.Size(141, 28);
            this.mnuedit_clear.Text = "清除(&A)";
            this.mnuedit_clear.Click += new System.EventHandler(this.mnuedit_clear_Click);
            // 
            // mnuview
            // 
            this.mnuview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuview_tool,
            this.mnuview_stat});
            this.mnuview.Name = "mnuview";
            this.mnuview.Size = new System.Drawing.Size(82, 28);
            this.mnuview.Text = "查看(&V)";
            // 
            // mnuview_tool
            // 
            this.mnuview_tool.Name = "mnuview_tool";
            this.mnuview_tool.Size = new System.Drawing.Size(156, 28);
            this.mnuview_tool.Text = "工具栏(&T)";
            this.mnuview_tool.Click += new System.EventHandler(this.mnuview_tool_Click);
            // 
            // mnuview_stat
            // 
            this.mnuview_stat.Name = "mnuview_stat";
            this.mnuview_stat.Size = new System.Drawing.Size(156, 28);
            this.mnuview_stat.Text = "状态栏(&S)";
            this.mnuview_stat.Click += new System.EventHandler(this.mnuview_stat_Click);
            // 
            // mnuform
            // 
            this.mnuform.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuform_font,
            this.mnuform_wordwrap,
            this.mnuform_color});
            this.mnuform.Name = "mnuform";
            this.mnuform.Size = new System.Drawing.Size(85, 28);
            this.mnuform.Text = "格式(&O)";
            // 
            // mnuform_font
            // 
            this.mnuform_font.Name = "mnuform_font";
            this.mnuform_font.Size = new System.Drawing.Size(182, 28);
            this.mnuform_font.Text = "字体(&F)";
            this.mnuform_font.Click += new System.EventHandler(this.mnuform_font_Click);
            // 
            // mnuform_wordwrap
            // 
            this.mnuform_wordwrap.Name = "mnuform_wordwrap";
            this.mnuform_wordwrap.Size = new System.Drawing.Size(182, 28);
            this.mnuform_wordwrap.Text = "自动换行(&W)";
            this.mnuform_wordwrap.Click += new System.EventHandler(this.mnuform_wordwrap_Click);
            // 
            // mnuform_color
            // 
            this.mnuform_color.Name = "mnuform_color";
            this.mnuform_color.Size = new System.Drawing.Size(182, 28);
            this.mnuform_color.Text = "颜色(&R)";
            this.mnuform_color.Click += new System.EventHandler(this.mnuform_color_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copybutton,
            this.cutbutton,
            this.savebutton,
            this.newbutton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // copybutton
            // 
            this.copybutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copybutton.Image = ((System.Drawing.Image)(resources.GetObject("copybutton.Image")));
            this.copybutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copybutton.Name = "copybutton";
            this.copybutton.Size = new System.Drawing.Size(23, 22);
            this.copybutton.Text = "复制";
            this.copybutton.Click += new System.EventHandler(this.copybutton_Click);
            // 
            // cutbutton
            // 
            this.cutbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutbutton.Image = ((System.Drawing.Image)(resources.GetObject("cutbutton.Image")));
            this.cutbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutbutton.Name = "cutbutton";
            this.cutbutton.Size = new System.Drawing.Size(23, 22);
            this.cutbutton.Text = "清除";
            this.cutbutton.Click += new System.EventHandler(this.cutbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savebutton.Image = ((System.Drawing.Image)(resources.GetObject("savebutton.Image")));
            this.savebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(23, 22);
            this.savebutton.Text = "保存";
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // newbutton
            // 
            this.newbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newbutton.Image = ((System.Drawing.Image)(resources.GetObject("newbutton.Image")));
            this.newbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(23, 22);
            this.newbutton.Text = "新建";
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 345);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = " ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statu1,
            this.statu2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(586, 29);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statu1
            // 
            this.statu1.Name = "statu1";
            this.statu1.Size = new System.Drawing.Size(154, 24);
            this.statu1.Text = "状态栏提示信息：";
            // 
            // statu2
            // 
            this.statu2.Name = "statu2";
            this.statu2.Size = new System.Drawing.Size(0, 24);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制toolStripMenuItem,
            this.粘贴toolStripMenuItem,
            this.剪贴toolStripMenuItem,
            this.退出toolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 116);
            // 
            // 复制toolStripMenuItem
            // 
            this.复制toolStripMenuItem.Name = "复制toolStripMenuItem";
            this.复制toolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.复制toolStripMenuItem.Text = "复制";
            this.复制toolStripMenuItem.Click += new System.EventHandler(this.复制toolStripMenuItem_Click_1);
            // 
            // 粘贴toolStripMenuItem
            // 
            this.粘贴toolStripMenuItem.Name = "粘贴toolStripMenuItem";
            this.粘贴toolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.粘贴toolStripMenuItem.Text = "粘贴";
            this.粘贴toolStripMenuItem.Click += new System.EventHandler(this.粘贴toolStripMenuItem_Click_1);
            // 
            // 剪贴toolStripMenuItem
            // 
            this.剪贴toolStripMenuItem.Name = "剪贴toolStripMenuItem";
            this.剪贴toolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.剪贴toolStripMenuItem.Text = "剪贴";
            this.剪贴toolStripMenuItem.Click += new System.EventHandler(this.剪贴toolStripMenuItem_Click);
            // 
            // 退出toolStripMenuItem
            // 
            this.退出toolStripMenuItem.Name = "退出toolStripMenuItem";
            this.退出toolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.退出toolStripMenuItem.Text = "退出";
            this.退出toolStripMenuItem.Click += new System.EventHandler(this.退出toolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 471);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "简易记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnufile_new;
        private System.Windows.Forms.ToolStripMenuItem mnufile_open;
        private System.Windows.Forms.ToolStripMenuItem mnufile_save;
        private System.Windows.Forms.ToolStripMenuItem mnufile_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnufile_exit;
        private System.Windows.Forms.ToolStripMenuItem mnuedit;
        private System.Windows.Forms.ToolStripMenuItem mnuedit_undo;
        private System.Windows.Forms.ToolStripMenuItem mnuedit_copy;
        private System.Windows.Forms.ToolStripMenuItem mnuedit_cut;
        private System.Windows.Forms.ToolStripMenuItem mnuedit_paste;
        private System.Windows.Forms.ToolStripMenuItem mnuedit_clear;
        private System.Windows.Forms.ToolStripMenuItem mnuview;
        private System.Windows.Forms.ToolStripMenuItem mnuview_tool;
        private System.Windows.Forms.ToolStripMenuItem mnuview_stat;
        private System.Windows.Forms.ToolStripMenuItem mnuform;
        private System.Windows.Forms.ToolStripMenuItem mnuform_font;
        private System.Windows.Forms.ToolStripMenuItem mnuform_wordwrap;
        private System.Windows.Forms.ToolStripMenuItem mnuform_color;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton copybutton;
        private System.Windows.Forms.ToolStripButton cutbutton;
        private System.Windows.Forms.ToolStripButton savebutton;
        private System.Windows.Forms.ToolStripButton newbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statu1;
        private System.Windows.Forms.ToolStripStatusLabel statu2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪贴toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出toolStripMenuItem;
    }
}

