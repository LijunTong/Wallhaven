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
            this.tbFullImgPath = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSmallImgPath = new System.Windows.Forms.TextBox();
            this.tbWallhavenImgBaseUrlFormat = new System.Windows.Forms.TextBox();
            this.tbWallhavenImgDetialsUrlFormat = new System.Windows.Forms.TextBox();
            this.tbWallhavenSmallImgUrlRegex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownThreadCnt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWallhavenBaseUrl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCnt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tbFullImgPath, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbSmallImgPath, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenImgBaseUrlFormat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenImgDetialsUrlFormat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenSmallImgUrlRegex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownThreadCnt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenBaseUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbFullImgPath
            // 
            this.tbFullImgPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFullImgPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "FullImageDir", true));
            this.tbFullImgPath.Location = new System.Drawing.Point(151, 214);
            this.tbFullImgPath.Name = "tbFullImgPath";
            this.tbFullImgPath.Size = new System.Drawing.Size(584, 27);
            this.tbFullImgPath.TabIndex = 12;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WallHavenGetter.Models.AppOptions);
            // 
            // tbSmallImgPath
            // 
            this.tbSmallImgPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSmallImgPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SmallImageDir", true));
            this.tbSmallImgPath.Location = new System.Drawing.Point(151, 179);
            this.tbSmallImgPath.Name = "tbSmallImgPath";
            this.tbSmallImgPath.Size = new System.Drawing.Size(584, 27);
            this.tbSmallImgPath.TabIndex = 12;
            // 
            // tbWallhavenImgBaseUrlFormat
            // 
            this.tbWallhavenImgBaseUrlFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenImgBaseUrlFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenSmallImgUrlRegex", true));
            this.tbWallhavenImgBaseUrlFormat.Location = new System.Drawing.Point(151, 144);
            this.tbWallhavenImgBaseUrlFormat.Name = "tbWallhavenImgBaseUrlFormat";
            this.tbWallhavenImgBaseUrlFormat.Size = new System.Drawing.Size(584, 27);
            this.tbWallhavenImgBaseUrlFormat.TabIndex = 11;
            // 
            // tbWallhavenImgDetialsUrlFormat
            // 
            this.tbWallhavenImgDetialsUrlFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenImgDetialsUrlFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenImgDetialsUrlFormat", true));
            this.tbWallhavenImgDetialsUrlFormat.Location = new System.Drawing.Point(151, 109);
            this.tbWallhavenImgDetialsUrlFormat.Name = "tbWallhavenImgDetialsUrlFormat";
            this.tbWallhavenImgDetialsUrlFormat.Size = new System.Drawing.Size(584, 27);
            this.tbWallhavenImgDetialsUrlFormat.TabIndex = 10;
            // 
            // tbWallhavenSmallImgUrlRegex
            // 
            this.tbWallhavenSmallImgUrlRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenSmallImgUrlRegex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenSmallImgUrlRegex", true));
            this.tbWallhavenSmallImgUrlRegex.Location = new System.Drawing.Point(151, 74);
            this.tbWallhavenSmallImgUrlRegex.Name = "tbWallhavenSmallImgUrlRegex";
            this.tbWallhavenSmallImgUrlRegex.Size = new System.Drawing.Size(584, 27);
            this.tbWallhavenSmallImgUrlRegex.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大线程数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownThreadCnt
            // 
            this.numericUpDownThreadCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownThreadCnt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "ThreadCount", true));
            this.numericUpDownThreadCnt.Location = new System.Drawing.Point(151, 4);
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
            this.numericUpDownThreadCnt.TabIndex = 3;
            this.numericUpDownThreadCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
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
            this.label3.Location = new System.Drawing.Point(31, 77);
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
            this.label4.Location = new System.Drawing.Point(46, 112);
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
            this.label5.Location = new System.Drawing.Point(31, 147);
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
            this.tbWallhavenBaseUrl.Location = new System.Drawing.Point(151, 39);
            this.tbWallhavenBaseUrl.Name = "tbWallhavenBaseUrl";
            this.tbWallhavenBaseUrl.Size = new System.Drawing.Size(584, 27);
            this.tbWallhavenBaseUrl.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(151, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 129);
            this.panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(103, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "缩略图缓存地址";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "下载地址";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选项";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadCnt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private NumericUpDown numericUpDownThreadCnt;
        private TextBox tbWallhavenImgDetialsUrlFormat;
        private TextBox tbWallhavenSmallImgUrlRegex;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbWallhavenBaseUrl;
        private TextBox tbWallhavenImgBaseUrlFormat;
        private Label label5;
        private BindingSource bindingSource1;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbFullImgPath;
        private TextBox tbSmallImgPath;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}