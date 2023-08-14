namespace WallHavenGetter
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            toolItemSet = new ToolStripMenuItem();
            toolItemCache = new ToolStripMenuItem();
            toolItemAbout = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsLoadStatus = new ToolStripStatusLabel();
            tsPBarLoadStatus = new ToolStripProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBoxUrl = new ToolStripTextBox();
            toolStripToolBar = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripComboBoxType = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            tsLblKey = new ToolStripLabel();
            toolStripTextBoxInput = new ToolStripTextBox();
            toolStripDropDownCategories = new ToolStripDropDownButton();
            toolItemGeneral = new ToolStripMenuItem();
            toolItemAnime = new ToolStripMenuItem();
            toolitemPeople = new ToolStripMenuItem();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            sFWToolStripMenuItem = new ToolStripMenuItem();
            sketToolStripMenuItem = new ToolStripMenuItem();
            nSFWToolStripMenuItem = new ToolStripMenuItem();
            toolStripLabelSort = new ToolStripLabel();
            toolStripComboBoxSort = new ToolStripComboBox();
            toolStripLabel4 = new ToolStripLabel();
            toolStripTextBoxPage = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonGet = new ToolStripButton();
            toolStripButtonDownload = new ToolStripSplitButton();
            toolStripMenuItemCancel = new ToolStripMenuItem();
            打开下载目录ToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            imageListView1 = new Manina.Windows.Forms.ImageListView();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStripToolBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolItemSet, toolItemCache, toolItemAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1279, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolItemSet
            // 
            toolItemSet.Name = "toolItemSet";
            toolItemSet.Size = new Size(44, 21);
            toolItemSet.Text = "设置";
            toolItemSet.Click += toolItemSet_Click;
            // 
            // toolItemCache
            // 
            toolItemCache.Name = "toolItemCache";
            toolItemCache.Size = new Size(44, 21);
            toolItemCache.Text = "缓存";
            toolItemCache.Click += toolItemCache_Click;
            // 
            // toolItemAbout
            // 
            toolItemAbout.Name = "toolItemAbout";
            toolItemAbout.Size = new Size(44, 21);
            toolItemAbout.Text = "关于";
            toolItemAbout.Click += toolItemAbout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsLoadStatus, tsPBarLoadStatus });
            statusStrip1.Location = new Point(0, 635);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1279, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsLoadStatus
            // 
            tsLoadStatus.Name = "tsLoadStatus";
            tsLoadStatus.Size = new Size(0, 17);
            // 
            // tsPBarLoadStatus
            // 
            tsPBarLoadStatus.Name = "tsPBarLoadStatus";
            tsPBarLoadStatus.Size = new Size(175, 16);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBoxUrl });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(2);
            toolStrip1.Size = new Size(1279, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(32, 20);
            toolStripLabel1.Text = "网址";
            // 
            // toolStripTextBoxUrl
            // 
            toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            toolStripTextBoxUrl.ReadOnly = true;
            toolStripTextBoxUrl.Size = new Size(788, 23);
            // 
            // toolStripToolBar
            // 
            toolStripToolBar.BackColor = SystemColors.ControlLight;
            toolStripToolBar.ImageScalingSize = new Size(20, 20);
            toolStripToolBar.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripComboBoxType, toolStripSeparator2, tsLblKey, toolStripTextBoxInput, toolStripDropDownCategories, toolStripDropDownButton1, toolStripLabelSort, toolStripComboBoxSort, toolStripLabel4, toolStripTextBoxPage, toolStripLabel3, toolStripSeparator1, toolStripButtonGet, toolStripButtonDownload });
            toolStripToolBar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripToolBar.Location = new Point(0, 52);
            toolStripToolBar.Name = "toolStripToolBar";
            toolStripToolBar.Padding = new Padding(2);
            toolStripToolBar.Size = new Size(1279, 29);
            toolStripToolBar.TabIndex = 3;
            toolStripToolBar.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(44, 22);
            toolStripLabel2.Text = "主题：";
            // 
            // toolStripComboBoxType
            // 
            toolStripComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxType.Name = "toolStripComboBoxType";
            toolStripComboBoxType.Size = new Size(106, 25);
            toolStripComboBoxType.SelectedIndexChanged += toolStripComboBoxType_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsLblKey
            // 
            tsLblKey.Name = "tsLblKey";
            tsLblKey.Size = new Size(56, 22);
            tsLblKey.Text = "关键词：";
            // 
            // toolStripTextBoxInput
            // 
            toolStripTextBoxInput.Name = "toolStripTextBoxInput";
            toolStripTextBoxInput.Size = new Size(132, 25);
            toolStripTextBoxInput.TextChanged += toolStripTextBoxInput_TextChanged;
            // 
            // toolStripDropDownCategories
            // 
            toolStripDropDownCategories.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownCategories.DropDownItems.AddRange(new ToolStripItem[] { toolItemGeneral, toolItemAnime, toolitemPeople });
            toolStripDropDownCategories.Image = (Image)resources.GetObject("toolStripDropDownCategories.Image");
            toolStripDropDownCategories.ImageTransparentColor = Color.Magenta;
            toolStripDropDownCategories.Name = "toolStripDropDownCategories";
            toolStripDropDownCategories.Size = new Size(45, 22);
            toolStripDropDownCategories.Text = "类别";
            // 
            // toolItemGeneral
            // 
            toolItemGeneral.Checked = true;
            toolItemGeneral.CheckOnClick = true;
            toolItemGeneral.CheckState = CheckState.Checked;
            toolItemGeneral.Name = "toolItemGeneral";
            toolItemGeneral.Size = new Size(100, 22);
            toolItemGeneral.Text = "常规";
            toolItemGeneral.CheckedChanged += toolItemGeneral_CheckedChanged;
            // 
            // toolItemAnime
            // 
            toolItemAnime.Checked = true;
            toolItemAnime.CheckOnClick = true;
            toolItemAnime.CheckState = CheckState.Checked;
            toolItemAnime.Name = "toolItemAnime";
            toolItemAnime.Size = new Size(100, 22);
            toolItemAnime.Text = "动漫";
            toolItemAnime.CheckedChanged += toolItemGeneral_CheckedChanged;
            // 
            // toolitemPeople
            // 
            toolitemPeople.Checked = true;
            toolitemPeople.CheckOnClick = true;
            toolitemPeople.CheckState = CheckState.Checked;
            toolitemPeople.Name = "toolitemPeople";
            toolitemPeople.Size = new Size(100, 22);
            toolitemPeople.Text = "人";
            toolitemPeople.CheckedChanged += toolItemGeneral_CheckedChanged;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { sFWToolStripMenuItem, sketToolStripMenuItem, nSFWToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(69, 22);
            toolStripDropDownButton1.Text = "安全程度";
            // 
            // sFWToolStripMenuItem
            // 
            sFWToolStripMenuItem.Checked = true;
            sFWToolStripMenuItem.CheckOnClick = true;
            sFWToolStripMenuItem.CheckState = CheckState.Checked;
            sFWToolStripMenuItem.Name = "sFWToolStripMenuItem";
            sFWToolStripMenuItem.Size = new Size(120, 22);
            sFWToolStripMenuItem.Text = "SFW";
            sFWToolStripMenuItem.ToolTipText = "\"Safe for work\" wallpapers grandma approves";
            sFWToolStripMenuItem.CheckedChanged += sFWToolStripMenuItem_CheckedChanged;
            // 
            // sketToolStripMenuItem
            // 
            sketToolStripMenuItem.Checked = true;
            sketToolStripMenuItem.CheckOnClick = true;
            sketToolStripMenuItem.CheckState = CheckState.Checked;
            sketToolStripMenuItem.Name = "sketToolStripMenuItem";
            sketToolStripMenuItem.Size = new Size(120, 22);
            sketToolStripMenuItem.Text = "Sketchy";
            sketToolStripMenuItem.ToolTipText = "Not quite SFW not quite NSFW. Grandma might be uncomfortable";
            sketToolStripMenuItem.CheckedChanged += sFWToolStripMenuItem_CheckedChanged;
            // 
            // nSFWToolStripMenuItem
            // 
            nSFWToolStripMenuItem.CheckOnClick = true;
            nSFWToolStripMenuItem.Name = "nSFWToolStripMenuItem";
            nSFWToolStripMenuItem.Size = new Size(120, 22);
            nSFWToolStripMenuItem.Text = "NSFW";
            nSFWToolStripMenuItem.ToolTipText = "\"Not safe for work\" Grandma isn't sure who you are anymore";
            nSFWToolStripMenuItem.CheckedChanged += sFWToolStripMenuItem_CheckedChanged;
            // 
            // toolStripLabelSort
            // 
            toolStripLabelSort.Name = "toolStripLabelSort";
            toolStripLabelSort.Size = new Size(32, 22);
            toolStripLabelSort.Text = "排序";
            // 
            // toolStripComboBoxSort
            // 
            toolStripComboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxSort.Name = "toolStripComboBoxSort";
            toolStripComboBoxSort.Size = new Size(106, 25);
            toolStripComboBoxSort.SelectedIndexChanged += toolStripComboBoxSort_SelectedIndexChanged;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(32, 22);
            toolStripLabel4.Text = "页数";
            // 
            // toolStripTextBoxPage
            // 
            toolStripTextBoxPage.Name = "toolStripTextBoxPage";
            toolStripTextBoxPage.Size = new Size(27, 25);
            toolStripTextBoxPage.Text = "1";
            toolStripTextBoxPage.KeyPress += toolStripTextBoxPage_KeyPress;
            toolStripTextBoxPage.MouseLeave += toolStripTextBoxPage_MouseLeave;
            toolStripTextBoxPage.TextChanged += toolStripTextBoxPage_TextChanged;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(46, 22);
            toolStripLabel3.Text = "每页24";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonGet
            // 
            toolStripButtonGet.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGet.Image = (Image)resources.GetObject("toolStripButtonGet.Image");
            toolStripButtonGet.ImageTransparentColor = Color.Magenta;
            toolStripButtonGet.Name = "toolStripButtonGet";
            toolStripButtonGet.Size = new Size(36, 22);
            toolStripButtonGet.Text = "搜索";
            toolStripButtonGet.Click += toolStripButtonGet_Click;
            // 
            // toolStripButtonDownload
            // 
            toolStripButtonDownload.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDownload.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCancel, 打开下载目录ToolStripMenuItem });
            toolStripButtonDownload.Image = (Image)resources.GetObject("toolStripButtonDownload.Image");
            toolStripButtonDownload.ImageTransparentColor = Color.Magenta;
            toolStripButtonDownload.Name = "toolStripButtonDownload";
            toolStripButtonDownload.Size = new Size(48, 22);
            toolStripButtonDownload.Text = "下载";
            toolStripButtonDownload.ButtonClick += toolStripButtonDownload_Click;
            // 
            // toolStripMenuItemCancel
            // 
            toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            toolStripMenuItemCancel.Size = new Size(148, 22);
            toolStripMenuItemCancel.Text = "取消下载";
            toolStripMenuItemCancel.Visible = false;
            toolStripMenuItemCancel.Click += toolStripMenuItemCancel_Click;
            // 
            // 打开下载目录ToolStripMenuItem
            // 
            打开下载目录ToolStripMenuItem.Name = "打开下载目录ToolStripMenuItem";
            打开下载目录ToolStripMenuItem.Size = new Size(148, 22);
            打开下载目录ToolStripMenuItem.Text = "打开下载目录";
            打开下载目录ToolStripMenuItem.Click += toolStripButton2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(imageListView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 554);
            panel1.TabIndex = 4;
            // 
            // imageListView1
            // 
            imageListView1.Dock = DockStyle.Fill;
            imageListView1.Location = new Point(0, 0);
            imageListView1.Name = "imageListView1";
            imageListView1.PersistentCacheDirectory = "";
            imageListView1.PersistentCacheSize = 100L;
            imageListView1.Size = new Size(1279, 554);
            imageListView1.TabIndex = 4;
            imageListView1.UseWIC = true;
            imageListView1.ItemDoubleClick += imageListView1_ItemDoubleClick;
            imageListView1.KeyDown += imageListView1_KeyDown;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 657);
            Controls.Add(panel1);
            Controls.Add(toolStripToolBar);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WallHaven";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripToolBar.ResumeLayout(false);
            toolStripToolBar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBoxUrl;
        private ToolStrip toolStripToolBar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox toolStripTextBoxPage;
        private ToolStripLabel toolStripLabel3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonGet;
        private Panel panel1;
        private ToolStripStatusLabel tsLoadStatus;
        private ToolStripProgressBar tsPBarLoadStatus;
        private ToolStripMenuItem toolItemSet;
        private ToolStripMenuItem toolItemCache;
        private ToolStripMenuItem toolItemAbout;
        private ToolStripTextBox toolStripTextBoxInput;
        private ToolStripLabel tsLblKey;
        private Manina.Windows.Forms.ImageListView imageListView1;
        private ToolStripDropDownButton toolStripDropDownCategories;
        private ToolStripMenuItem toolItemGeneral;
        private ToolStripMenuItem toolItemAnime;
        private ToolStripMenuItem toolitemPeople;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox toolStripComboBoxType;
        private ToolStripComboBox toolStripComboBoxSort;
        private ToolStripLabel toolStripLabelSort;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem sFWToolStripMenuItem;
        private ToolStripMenuItem sketToolStripMenuItem;
        private ToolStripMenuItem nSFWToolStripMenuItem;
        private ToolStripSplitButton toolStripButtonDownload;
        private ToolStripMenuItem 打开下载目录ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemCancel;
    }
}