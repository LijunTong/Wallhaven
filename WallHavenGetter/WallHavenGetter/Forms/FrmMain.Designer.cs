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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolItemSet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemCache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLoadStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPBarLoadStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblKey = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxInput = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownCategories = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolItemGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemAnime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolitemPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sFWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nSFWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabelSort = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageListView1 = new Manina.Windows.Forms.ImageListView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemSet,
            this.toolItemCache,
            this.toolItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolItemSet
            // 
            this.toolItemSet.Name = "toolItemSet";
            this.toolItemSet.Size = new System.Drawing.Size(53, 24);
            this.toolItemSet.Text = "设置";
            this.toolItemSet.Click += new System.EventHandler(this.toolItemSet_Click);
            // 
            // toolItemCache
            // 
            this.toolItemCache.Name = "toolItemCache";
            this.toolItemCache.Size = new System.Drawing.Size(53, 24);
            this.toolItemCache.Text = "缓存";
            this.toolItemCache.Click += new System.EventHandler(this.toolItemCache_Click);
            // 
            // toolItemAbout
            // 
            this.toolItemAbout.Name = "toolItemAbout";
            this.toolItemAbout.Size = new System.Drawing.Size(53, 24);
            this.toolItemAbout.Text = "关于";
            this.toolItemAbout.Click += new System.EventHandler(this.toolItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoadStatus,
            this.tsPBarLoadStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1238, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLoadStatus
            // 
            this.tsLoadStatus.Name = "tsLoadStatus";
            this.tsLoadStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPBarLoadStatus
            // 
            this.tsPBarLoadStatus.Name = "tsPBarLoadStatus";
            this.tsPBarLoadStatus.Size = new System.Drawing.Size(225, 15);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxUrl});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(1238, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel1.Text = "网址";
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.ReadOnly = true;
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(1012, 27);
            // 
            // toolStripToolBar
            // 
            this.toolStripToolBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripComboBoxType,
            this.toolStripSeparator2,
            this.tsLblKey,
            this.toolStripTextBoxInput,
            this.toolStripDropDownCategories,
            this.toolStripDropDownButton1,
            this.toolStripLabelSort,
            this.toolStripComboBoxSort,
            this.toolStripLabel4,
            this.toolStripTextBoxPage,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripButtonGet,
            this.toolStripButtonDownload,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripToolBar.Location = new System.Drawing.Point(0, 59);
            this.toolStripToolBar.Name = "toolStripToolBar";
            this.toolStripToolBar.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripToolBar.Size = new System.Drawing.Size(1238, 32);
            this.toolStripToolBar.TabIndex = 3;
            this.toolStripToolBar.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 25);
            this.toolStripLabel2.Text = "主题：";
            // 
            // toolStripComboBoxType
            // 
            this.toolStripComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxType.Name = "toolStripComboBoxType";
            this.toolStripComboBoxType.Size = new System.Drawing.Size(136, 28);
            this.toolStripComboBoxType.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxType_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsLblKey
            // 
            this.tsLblKey.Name = "tsLblKey";
            this.tsLblKey.Size = new System.Drawing.Size(69, 25);
            this.tsLblKey.Text = "关键词：";
            // 
            // toolStripTextBoxInput
            // 
            this.toolStripTextBoxInput.Name = "toolStripTextBoxInput";
            this.toolStripTextBoxInput.Size = new System.Drawing.Size(168, 28);
            this.toolStripTextBoxInput.TextChanged += new System.EventHandler(this.toolStripTextBoxInput_TextChanged);
            // 
            // toolStripDropDownCategories
            // 
            this.toolStripDropDownCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownCategories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemGeneral,
            this.toolItemAnime,
            this.toolitemPeople});
            this.toolStripDropDownCategories.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownCategories.Image")));
            this.toolStripDropDownCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownCategories.Name = "toolStripDropDownCategories";
            this.toolStripDropDownCategories.Size = new System.Drawing.Size(53, 25);
            this.toolStripDropDownCategories.Text = "类别";
            // 
            // toolItemGeneral
            // 
            this.toolItemGeneral.Checked = true;
            this.toolItemGeneral.CheckOnClick = true;
            this.toolItemGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolItemGeneral.Name = "toolItemGeneral";
            this.toolItemGeneral.Size = new System.Drawing.Size(122, 26);
            this.toolItemGeneral.Text = "常规";
            this.toolItemGeneral.CheckedChanged += new System.EventHandler(this.toolItemGeneral_CheckedChanged);
            // 
            // toolItemAnime
            // 
            this.toolItemAnime.Checked = true;
            this.toolItemAnime.CheckOnClick = true;
            this.toolItemAnime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolItemAnime.Name = "toolItemAnime";
            this.toolItemAnime.Size = new System.Drawing.Size(122, 26);
            this.toolItemAnime.Text = "动漫";
            this.toolItemAnime.CheckedChanged += new System.EventHandler(this.toolItemGeneral_CheckedChanged);
            // 
            // toolitemPeople
            // 
            this.toolitemPeople.Checked = true;
            this.toolitemPeople.CheckOnClick = true;
            this.toolitemPeople.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolitemPeople.Name = "toolitemPeople";
            this.toolitemPeople.Size = new System.Drawing.Size(122, 26);
            this.toolitemPeople.Text = "人";
            this.toolitemPeople.CheckedChanged += new System.EventHandler(this.toolItemGeneral_CheckedChanged);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sFWToolStripMenuItem,
            this.sketToolStripMenuItem,
            this.nSFWToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(83, 25);
            this.toolStripDropDownButton1.Text = "安全程度";
            // 
            // sFWToolStripMenuItem
            // 
            this.sFWToolStripMenuItem.Checked = true;
            this.sFWToolStripMenuItem.CheckOnClick = true;
            this.sFWToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sFWToolStripMenuItem.Name = "sFWToolStripMenuItem";
            this.sFWToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sFWToolStripMenuItem.Text = "SFW";
            this.sFWToolStripMenuItem.ToolTipText = "\"Safe for work\" wallpapers grandma approves";
            this.sFWToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sFWToolStripMenuItem_CheckedChanged);
            // 
            // sketToolStripMenuItem
            // 
            this.sketToolStripMenuItem.Checked = true;
            this.sketToolStripMenuItem.CheckOnClick = true;
            this.sketToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sketToolStripMenuItem.Name = "sketToolStripMenuItem";
            this.sketToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sketToolStripMenuItem.Text = "Sketchy";
            this.sketToolStripMenuItem.ToolTipText = "Not quite SFW not quite NSFW. Grandma might be uncomfortable";
            this.sketToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sFWToolStripMenuItem_CheckedChanged);
            // 
            // nSFWToolStripMenuItem
            // 
            this.nSFWToolStripMenuItem.CheckOnClick = true;
            this.nSFWToolStripMenuItem.Name = "nSFWToolStripMenuItem";
            this.nSFWToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nSFWToolStripMenuItem.Text = "NSFW";
            this.nSFWToolStripMenuItem.ToolTipText = "\"Not safe for work\" Grandma isn\'t sure who you are anymore";
            this.nSFWToolStripMenuItem.CheckedChanged += new System.EventHandler(this.sFWToolStripMenuItem_CheckedChanged);
            // 
            // toolStripLabelSort
            // 
            this.toolStripLabelSort.Name = "toolStripLabelSort";
            this.toolStripLabelSort.Size = new System.Drawing.Size(39, 25);
            this.toolStripLabelSort.Text = "排序";
            // 
            // toolStripComboBoxSort
            // 
            this.toolStripComboBoxSort.Name = "toolStripComboBoxSort";
            this.toolStripComboBoxSort.Size = new System.Drawing.Size(136, 28);
            this.toolStripComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSort_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(39, 25);
            this.toolStripLabel4.Text = "页数";
            // 
            // toolStripTextBoxPage
            // 
            this.toolStripTextBoxPage.Name = "toolStripTextBoxPage";
            this.toolStripTextBoxPage.Size = new System.Drawing.Size(33, 28);
            this.toolStripTextBoxPage.Text = "1";
            this.toolStripTextBoxPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPage_KeyPress);
            this.toolStripTextBoxPage.MouseLeave += new System.EventHandler(this.toolStripTextBoxPage_MouseLeave);
            this.toolStripTextBoxPage.TextChanged += new System.EventHandler(this.toolStripTextBoxPage_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 25);
            this.toolStripLabel3.Text = "每页24";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonGet
            // 
            this.toolStripButtonGet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGet.Image")));
            this.toolStripButtonGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGet.Name = "toolStripButtonGet";
            this.toolStripButtonGet.Size = new System.Drawing.Size(43, 25);
            this.toolStripButtonGet.Text = "搜索";
            this.toolStripButtonGet.Click += new System.EventHandler(this.toolStripButtonGet_Click);
            // 
            // toolStripButtonDownload
            // 
            this.toolStripButtonDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDownload.Image")));
            this.toolStripButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownload.Name = "toolStripButtonDownload";
            this.toolStripButtonDownload.Size = new System.Drawing.Size(43, 25);
            this.toolStripButtonDownload.Text = "下载";
            this.toolStripButtonDownload.Click += new System.EventHandler(this.toolStripButtonDownload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 25);
            this.toolStripButton1.Text = "下载全部";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(103, 25);
            this.toolStripButton2.Text = "打开下载目录";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageListView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 490);
            this.panel1.TabIndex = 4;
            // 
            // imageListView1
            // 
            this.imageListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView1.Location = new System.Drawing.Point(0, 0);
            this.imageListView1.Name = "imageListView1";
            this.imageListView1.PersistentCacheDirectory = "";
            this.imageListView1.PersistentCacheSize = ((long)(100));
            this.imageListView1.Size = new System.Drawing.Size(1238, 490);
            this.imageListView1.TabIndex = 4;
            this.imageListView1.UseWIC = true;
            this.imageListView1.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.imageListView1_ItemDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripToolBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WallHaven";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripToolBar.ResumeLayout(false);
            this.toolStripToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripButton toolStripButtonDownload;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
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
    }
}