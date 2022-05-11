namespace WallHavenGetter.Forms
{
    partial class FrmAbout
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbWallhavenSmallImgUrlRegex = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWallhavenBaseUrl = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenSmallImgUrlRegex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbWallhavenBaseUrl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "说明";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWallhavenSmallImgUrlRegex
            // 
            this.tbWallhavenSmallImgUrlRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenSmallImgUrlRegex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenSmallImgUrlRegex", true));
            this.tbWallhavenSmallImgUrlRegex.Location = new System.Drawing.Point(79, 70);
            this.tbWallhavenSmallImgUrlRegex.Name = "tbWallhavenSmallImgUrlRegex";
            this.tbWallhavenSmallImgUrlRegex.ReadOnly = true;
            this.tbWallhavenSmallImgUrlRegex.Size = new System.Drawing.Size(281, 24);
            this.tbWallhavenSmallImgUrlRegex.TabIndex = 9;
            this.tbWallhavenSmallImgUrlRegex.Text = "1193247828";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WallHavenGetter.Models.AppOptions);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "版本";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "作者";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "QQ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWallhavenBaseUrl
            // 
            this.tbWallhavenBaseUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWallhavenBaseUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenBaseUrl", true));
            this.tbWallhavenBaseUrl.Location = new System.Drawing.Point(79, 37);
            this.tbWallhavenBaseUrl.Name = "tbWallhavenBaseUrl";
            this.tbWallhavenBaseUrl.ReadOnly = true;
            this.tbWallhavenBaseUrl.Size = new System.Drawing.Size(281, 24);
            this.tbWallhavenBaseUrl.TabIndex = 8;
            this.tbWallhavenBaseUrl.Text = "Joont";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "WallhavenBaseUrl", true));
            this.textBox1.Location = new System.Drawing.Point(79, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(281, 24);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "V1.0.1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox1.Location = new System.Drawing.Point(79, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(281, 139);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "本站所有图片均来自网络。\n\t1.https://wallhaven.cc/";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox tbWallhavenSmallImgUrlRegex;
        private Label label1;
        private Label label3;
        private TextBox tbWallhavenBaseUrl;
        private BindingSource bindingSource1;
        private Label label4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}