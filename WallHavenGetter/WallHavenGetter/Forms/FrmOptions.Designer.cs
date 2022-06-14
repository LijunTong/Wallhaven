namespace WallHavenGetter.Forms
{
    partial class FrmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbWallhavenImgBaseUrlFormat = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbWallhavenImgDetialsUrlFormat = new System.Windows.Forms.TextBox();
            this.tbWallhavenSmallImgUrlRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWallhavenBaseUrl = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownThreadCnt = new System.Windows.Forms.NumericUpDown();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSmallImgPath = new System.Windows.Forms.TextBox();
            this.tbFullImgPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApi = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCnt)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenImgBaseUrlFormat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenImgDetialsUrlFormat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenSmallImgUrlRegex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenBaseUrl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 304);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbWallhavenImgBaseUrlFormat
            // 
            this.tbWallhavenImgBaseUrlFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenImgBaseUrlFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenSmallImgUrlRegex", true));
            this.tbWallhavenImgBaseUrlFormat.Location = new System.Drawing.Point(148, 109);
            this.tbWallhavenImgBaseUrlFormat.Name = "tbWallhavenImgBaseUrlFormat";
            this.tbWallhavenImgBaseUrlFormat.Size = new System.Drawing.Size(576, 27);
            this.tbWallhavenImgBaseUrlFormat.TabIndex = 11;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WallHavenGetter.Models.AppOptions);
            // 
            // tbWallhavenImgDetialsUrlFormat
            // 
            this.tbWallhavenImgDetialsUrlFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenImgDetialsUrlFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenImgDetialsUrlFormat", true));
            this.tbWallhavenImgDetialsUrlFormat.Location = new System.Drawing.Point(148, 74);
            this.tbWallhavenImgDetialsUrlFormat.Name = "tbWallhavenImgDetialsUrlFormat";
            this.tbWallhavenImgDetialsUrlFormat.Size = new System.Drawing.Size(576, 27);
            this.tbWallhavenImgDetialsUrlFormat.TabIndex = 10;
            // 
            // tbWallhavenSmallImgUrlRegex
            // 
            this.tbWallhavenSmallImgUrlRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenSmallImgUrlRegex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenSmallImgUrlRegex", true));
            this.tbWallhavenSmallImgUrlRegex.Location = new System.Drawing.Point(148, 39);
            this.tbWallhavenSmallImgUrlRegex.Name = "tbWallhavenSmallImgUrlRegex";
            this.tbWallhavenSmallImgUrlRegex.Size = new System.Drawing.Size(576, 27);
            this.tbWallhavenSmallImgUrlRegex.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wallhaven地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "缩略图地址正则";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "详情地址格式";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "高清图地址格式";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWallhavenBaseUrl
            // 
            this.tbWallhavenBaseUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenBaseUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenBaseUrl", true));
            this.tbWallhavenBaseUrl.Location = new System.Drawing.Point(148, 4);
            this.tbWallhavenBaseUrl.Name = "tbWallhavenBaseUrl";
            this.tbWallhavenBaseUrl.Size = new System.Drawing.Size(576, 27);
            this.tbWallhavenBaseUrl.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(327, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(227, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系统";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownThreadCnt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbMode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbSmallImgPath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbFullImgPath, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 304);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "最大线程数";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "请求模式";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownThreadCnt
            // 
            this.numericUpDownThreadCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownThreadCnt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "ThreadCount", true));
            this.numericUpDownThreadCnt.Location = new System.Drawing.Point(148, 4);
            this.numericUpDownThreadCnt.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownThreadCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreadCnt.Name = "numericUpDownThreadCnt";
            this.numericUpDownThreadCnt.Size = new System.Drawing.Size(112, 27);
            this.numericUpDownThreadCnt.TabIndex = 5;
            this.numericUpDownThreadCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMode
            // 
            this.cmbMode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "Mode", true));
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "爬虫",
            "Api"});
            this.cmbMode.Location = new System.Drawing.Point(148, 38);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(151, 28);
            this.cmbMode.TabIndex = 6;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "缩略图缓存地址";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "下载地址";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSmallImgPath
            // 
            this.tbSmallImgPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSmallImgPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SmallImageDir", true));
            this.tbSmallImgPath.Location = new System.Drawing.Point(148, 74);
            this.tbSmallImgPath.Name = "tbSmallImgPath";
            this.tbSmallImgPath.Size = new System.Drawing.Size(576, 27);
            this.tbSmallImgPath.TabIndex = 17;
            // 
            // tbFullImgPath
            // 
            this.tbFullImgPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFullImgPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FullImageDir", true));
            this.tbFullImgPath.Location = new System.Drawing.Point(148, 109);
            this.tbFullImgPath.Name = "tbFullImgPath";
            this.tbFullImgPath.Size = new System.Drawing.Size(576, 27);
            this.tbFullImgPath.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "爬虫";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Api";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbApi, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbApiKey, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(768, 304);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Api地址";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApi
            // 
            this.tbApi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbApi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ApiUrl", true));
            this.tbApi.Location = new System.Drawing.Point(148, 4);
            this.tbApi.Name = "tbApi";
            this.tbApi.Size = new System.Drawing.Size(576, 27);
            this.tbApi.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(427, 349);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 29);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "API Key";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbApiKey
            // 
            this.tbApiKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbApiKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ApiUrl", true));
            this.tbApiKey.Location = new System.Drawing.Point(148, 39);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(576, 27);
            this.tbApiKey.TabIndex = 10;
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 380);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "FrmOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCnt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbWallhavenImgDetialsUrlFormat;
        private TextBox tbWallhavenSmallImgUrlRegex;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbWallhavenBaseUrl;
        private TextBox tbWallhavenImgBaseUrlFormat;
        private Label label5;
        private BindingSource bindingSource1;
        private Button btnCancel;
        private Button btnSave;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnApply;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDownThreadCnt;
        private ComboBox cmbMode;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox tbApi;
        private Label label6;
        private Label label7;
        private TextBox tbSmallImgPath;
        private TextBox tbFullImgPath;
        private Button button1;
        private Button button2;
        private Label label10;
        private TextBox tbApiKey;
    }
}