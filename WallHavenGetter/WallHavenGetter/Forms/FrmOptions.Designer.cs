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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbWallhavenImgBaseUrlFormat = new TextBox();
            bindingSource1 = new BindingSource(components);
            tbWallhavenImgDetialsUrlFormat = new TextBox();
            tbWallhavenSmallImgUrlRegex = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbWallhavenBaseUrl = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            numericUpDownThreadCnt = new NumericUpDown();
            cmbMode = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            tbSmallImgPath = new TextBox();
            tbFullImgPath = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tbApi = new TextBox();
            label10 = new Label();
            tbApiKey = new TextBox();
            btnApply = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThreadCnt).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(tbWallhavenImgBaseUrlFormat, 1, 3);
            tableLayoutPanel1.Controls.Add(tbWallhavenImgDetialsUrlFormat, 1, 2);
            tableLayoutPanel1.Controls.Add(tbWallhavenSmallImgUrlRegex, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(tbWallhavenBaseUrl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 3);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.Size = new Size(596, 256);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbWallhavenImgBaseUrlFormat
            // 
            tbWallhavenImgBaseUrlFormat.Anchor = AnchorStyles.Left;
            tbWallhavenImgBaseUrlFormat.DataBindings.Add(new Binding("Text", bindingSource1, "WallhavenSmallImgUrlRegex", true));
            tbWallhavenImgBaseUrlFormat.Location = new Point(114, 93);
            tbWallhavenImgBaseUrlFormat.Margin = new Padding(2, 3, 2, 3);
            tbWallhavenImgBaseUrlFormat.Name = "tbWallhavenImgBaseUrlFormat";
            tbWallhavenImgBaseUrlFormat.Size = new Size(447, 23);
            tbWallhavenImgBaseUrlFormat.TabIndex = 11;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.AppOptions);
            // 
            // tbWallhavenImgDetialsUrlFormat
            // 
            tbWallhavenImgDetialsUrlFormat.Anchor = AnchorStyles.Left;
            tbWallhavenImgDetialsUrlFormat.DataBindings.Add(new Binding("Text", bindingSource1, "WallhavenImgDetialsUrlFormat", true));
            tbWallhavenImgDetialsUrlFormat.Location = new Point(114, 63);
            tbWallhavenImgDetialsUrlFormat.Margin = new Padding(2, 3, 2, 3);
            tbWallhavenImgDetialsUrlFormat.Name = "tbWallhavenImgDetialsUrlFormat";
            tbWallhavenImgDetialsUrlFormat.Size = new Size(447, 23);
            tbWallhavenImgDetialsUrlFormat.TabIndex = 10;
            // 
            // tbWallhavenSmallImgUrlRegex
            // 
            tbWallhavenSmallImgUrlRegex.Anchor = AnchorStyles.Left;
            tbWallhavenSmallImgUrlRegex.DataBindings.Add(new Binding("Text", bindingSource1, "WallhavenSmallImgUrlRegex", true));
            tbWallhavenSmallImgUrlRegex.Location = new Point(114, 33);
            tbWallhavenSmallImgUrlRegex.Margin = new Padding(2, 3, 2, 3);
            tbWallhavenSmallImgUrlRegex.Name = "tbWallhavenSmallImgUrlRegex";
            tbWallhavenSmallImgUrlRegex.Size = new Size(447, 23);
            tbWallhavenSmallImgUrlRegex.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(19, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 4;
            label1.Text = "Wallhaven地址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(18, 36);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 5;
            label3.Text = "缩略图地址正则";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(30, 66);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "详情地址格式";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(18, 96);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 7;
            label5.Text = "高清图地址格式";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbWallhavenBaseUrl
            // 
            tbWallhavenBaseUrl.Anchor = AnchorStyles.Left;
            tbWallhavenBaseUrl.DataBindings.Add(new Binding("Text", bindingSource1, "WallhavenBaseUrl", true));
            tbWallhavenBaseUrl.Location = new Point(114, 3);
            tbWallhavenBaseUrl.Margin = new Padding(2, 3, 2, 3);
            tbWallhavenBaseUrl.Name = "tbWallhavenBaseUrl";
            tbWallhavenBaseUrl.Size = new Size(447, 23);
            tbWallhavenBaseUrl.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(254, 297);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 25);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Location = new Point(177, 297);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(608, 292);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(600, 262);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "系统";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(numericUpDownThreadCnt, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbMode, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(tbSmallImgPath, 1, 2);
            tableLayoutPanel2.Controls.Add(tbFullImgPath, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 2, 2);
            tableLayoutPanel2.Controls.Add(button2, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 3);
            tableLayoutPanel2.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel2.Size = new Size(596, 256);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(42, 6);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 2;
            label8.Text = "最大线程数";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(54, 36);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 4;
            label9.Text = "请求模式";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownThreadCnt
            // 
            numericUpDownThreadCnt.Anchor = AnchorStyles.Left;
            numericUpDownThreadCnt.DataBindings.Add(new Binding("Value", bindingSource1, "ThreadCount", true));
            numericUpDownThreadCnt.Location = new Point(114, 3);
            numericUpDownThreadCnt.Margin = new Padding(2, 3, 2, 3);
            numericUpDownThreadCnt.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownThreadCnt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownThreadCnt.Name = "numericUpDownThreadCnt";
            numericUpDownThreadCnt.Size = new Size(87, 23);
            numericUpDownThreadCnt.TabIndex = 5;
            numericUpDownThreadCnt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbMode
            // 
            cmbMode.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "Mode", true));
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.FormattingEnabled = true;
            cmbMode.Items.AddRange(new object[] { "爬虫", "Api" });
            cmbMode.Location = new Point(114, 33);
            cmbMode.Margin = new Padding(2, 3, 2, 3);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(118, 25);
            cmbMode.TabIndex = 6;
            cmbMode.SelectedIndexChanged += cmbMode_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(18, 66);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 15;
            label6.Text = "缩略图缓存地址";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(54, 96);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 16;
            label7.Text = "下载地址";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbSmallImgPath
            // 
            tbSmallImgPath.Anchor = AnchorStyles.Left;
            tbSmallImgPath.DataBindings.Add(new Binding("Text", bindingSource1, "SmallImageDir", true));
            tbSmallImgPath.Location = new Point(114, 63);
            tbSmallImgPath.Margin = new Padding(2, 3, 2, 3);
            tbSmallImgPath.Name = "tbSmallImgPath";
            tbSmallImgPath.Size = new Size(447, 23);
            tbSmallImgPath.TabIndex = 17;
            // 
            // tbFullImgPath
            // 
            tbFullImgPath.Anchor = AnchorStyles.Left;
            tbFullImgPath.DataBindings.Add(new Binding("Text", bindingSource1, "FullImageDir", true));
            tbFullImgPath.Location = new Point(114, 93);
            tbFullImgPath.Margin = new Padding(2, 3, 2, 3);
            tbFullImgPath.Name = "tbFullImgPath";
            tbFullImgPath.Size = new Size(447, 23);
            tbFullImgPath.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(565, 63);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(27, 24);
            button1.TabIndex = 19;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(565, 93);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(27, 24);
            button2.TabIndex = 20;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(600, 262);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "爬虫";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Margin = new Padding(2, 3, 2, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 3, 2, 3);
            tabPage3.Size = new Size(600, 262);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Api";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(tbApi, 1, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 1);
            tableLayoutPanel3.Controls.Add(tbApiKey, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 3);
            tableLayoutPanel3.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel3.Size = new Size(596, 256);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(59, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 4;
            label2.Text = "Api地址";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbApi
            // 
            tbApi.Anchor = AnchorStyles.Left;
            tbApi.DataBindings.Add(new Binding("Text", bindingSource1, "ApiUrl", true));
            tbApi.Location = new Point(114, 3);
            tbApi.Margin = new Padding(2, 3, 2, 3);
            tbApi.Name = "tbApi";
            tbApi.Size = new Size(447, 23);
            tbApi.TabIndex = 8;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(58, 36);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 17);
            label10.TabIndex = 9;
            label10.Text = "API Key";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbApiKey
            // 
            tbApiKey.Anchor = AnchorStyles.Left;
            tbApiKey.DataBindings.Add(new Binding("Text", bindingSource1, "ApiKey", true));
            tbApiKey.Location = new Point(114, 33);
            tbApiKey.Margin = new Padding(2, 3, 2, 3);
            tbApiKey.Name = "tbApiKey";
            tbApiKey.Size = new Size(447, 23);
            tbApiKey.TabIndex = 10;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApply.Location = new Point(332, 297);
            btnApply.Margin = new Padding(2, 3, 2, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(73, 25);
            btnApply.TabIndex = 2;
            btnApply.Text = "应用";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // FrmOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 323);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "FrmOptions";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "选项";
            Load += FrmOptions_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThreadCnt).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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