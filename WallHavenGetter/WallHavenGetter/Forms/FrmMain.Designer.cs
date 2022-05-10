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
            this.toolItemCache});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolItemSet
            // 
            this.toolItemSet.Name = "toolItemSet";
            this.toolItemSet.Size = new System.Drawing.Size(47, 23);
            this.toolItemSet.Text = "设置";
            this.toolItemSet.Click += new System.EventHandler(this.toolItemSet_Click);
            // 
            // toolItemCache
            // 
            this.toolItemCache.Name = "toolItemCache";
            this.toolItemCache.Size = new System.Drawing.Size(47, 23);
            this.toolItemCache.Text = "缓存";
            this.toolItemCache.Click += new System.EventHandler(this.toolItemCache_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoadStatus,
            this.tsPBarLoadStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
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
            this.tsPBarLoadStatus.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxUrl});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(1100, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 21);
            this.toolStripLabel1.Text = "地址：";
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(400, 24);
            // 
            // toolStripToolBar
            // 
            this.toolStripToolBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripComboBoxType,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.toolStripTextBoxPage,
            this.toolStripLabel3,
            this.toolStripSeparator1,
            this.toolStripButtonGet,
            this.toolStripButtonDownload,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripToolBar.Location = new System.Drawing.Point(0, 55);
            this.toolStripToolBar.Name = "toolStripToolBar";
            this.toolStripToolBar.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripToolBar.Size = new System.Drawing.Size(1100, 31);
            this.toolStripToolBar.TabIndex = 3;
            this.toolStripToolBar.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(48, 24);
            this.toolStripLabel2.Text = "主题：";
            // 
            // toolStripComboBoxType
            // 
            this.toolStripComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxType.Name = "toolStripComboBoxType";
            this.toolStripComboBoxType.Size = new System.Drawing.Size(121, 27);
            this.toolStripComboBoxType.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxType_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel4.Text = "页数";
            // 
            // toolStripTextBoxPage
            // 
            this.toolStripTextBoxPage.Name = "toolStripTextBoxPage";
            this.toolStripTextBoxPage.Size = new System.Drawing.Size(30, 27);
            this.toolStripTextBoxPage.Text = "10";
            this.toolStripTextBoxPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxPage_KeyPress);
            this.toolStripTextBoxPage.MouseLeave += new System.EventHandler(this.toolStripTextBoxPage_MouseLeave);
            this.toolStripTextBoxPage.TextChanged += new System.EventHandler(this.toolStripTextBoxPage_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(51, 24);
            this.toolStripLabel3.Text = "每页24";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonGet
            // 
            this.toolStripButtonGet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGet.Image")));
            this.toolStripButtonGet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGet.Name = "toolStripButtonGet";
            this.toolStripButtonGet.Size = new System.Drawing.Size(39, 24);
            this.toolStripButtonGet.Text = "搜索";
            this.toolStripButtonGet.Click += new System.EventHandler(this.toolStripButtonGet_Click);
            // 
            // toolStripButtonDownload
            // 
            this.toolStripButtonDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDownload.Image")));
            this.toolStripButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownload.Name = "toolStripButtonDownload";
            this.toolStripButtonDownload.Size = new System.Drawing.Size(39, 24);
            this.toolStripButtonDownload.Text = "下载";
            this.toolStripButtonDownload.Click += new System.EventHandler(this.toolStripButtonDownload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 24);
            this.toolStripButton1.Text = "下载全部";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(91, 24);
            this.toolStripButton2.Text = "打开下载目录";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageListView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 466);
            this.panel1.TabIndex = 4;
            // 
            // imageListView1
            // 
            this.imageListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView1.Location = new System.Drawing.Point(0, 0);
            this.imageListView1.Name = "imageListView1";
            this.imageListView1.PersistentCacheDirectory = "";
            this.imageListView1.PersistentCacheSize = ((long)(100));
            this.imageListView1.Size = new System.Drawing.Size(1100, 466);
            this.imageListView1.TabIndex = 0;
            this.imageListView1.UseWIC = true;
            this.imageListView1.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.imageListView1_ItemDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 574);
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
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox toolStripComboBoxType;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox toolStripTextBoxPage;
        private ToolStripLabel toolStripLabel3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonGet;
        private Panel panel1;
        private Manina.Windows.Forms.ImageListView imageListView1;
        private ToolStripStatusLabel tsLoadStatus;
        private ToolStripProgressBar tsPBarLoadStatus;
        private ToolStripButton toolStripButtonDownload;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem toolItemSet;
        private ToolStripMenuItem toolItemCache;
    }
}