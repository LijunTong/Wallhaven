namespace WallHavenGetter.Forms
{
    partial class FrmCache
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCleanSmallImg = new System.Windows.Forms.Button();
            this.lblSmallImg = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCleanFullImg = new System.Windows.Forms.Button();
            this.lblFullimg = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCleanSmallImg);
            this.groupBox2.Controls.Add(this.lblSmallImg);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缩略图";
            // 
            // btnCleanSmallImg
            // 
            this.btnCleanSmallImg.Location = new System.Drawing.Point(156, 0);
            this.btnCleanSmallImg.Name = "btnCleanSmallImg";
            this.btnCleanSmallImg.Size = new System.Drawing.Size(45, 29);
            this.btnCleanSmallImg.TabIndex = 3;
            this.btnCleanSmallImg.Text = "清除";
            this.btnCleanSmallImg.UseVisualStyleBackColor = true;
            this.btnCleanSmallImg.Click += new System.EventHandler(this.btnCleanSmallImg_Click);
            // 
            // lblSmallImg
            // 
            this.lblSmallImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSmallImg.AutoSize = true;
            this.lblSmallImg.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmallImg.Location = new System.Drawing.Point(68, 39);
            this.lblSmallImg.Name = "lblSmallImg";
            this.lblSmallImg.Size = new System.Drawing.Size(70, 28);
            this.lblSmallImg.TabIndex = 2;
            this.lblSmallImg.Text = "50Mb";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCleanFullImg);
            this.groupBox3.Controls.Add(this.lblFullimg);
            this.groupBox3.Location = new System.Drawing.Point(231, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "下载文件";
            // 
            // btnCleanFullImg
            // 
            this.btnCleanFullImg.Location = new System.Drawing.Point(155, 0);
            this.btnCleanFullImg.Name = "btnCleanFullImg";
            this.btnCleanFullImg.Size = new System.Drawing.Size(45, 29);
            this.btnCleanFullImg.TabIndex = 3;
            this.btnCleanFullImg.Text = "清除";
            this.btnCleanFullImg.UseVisualStyleBackColor = true;
            this.btnCleanFullImg.Click += new System.EventHandler(this.btnCleanFullImg_Click);
            // 
            // lblFullimg
            // 
            this.lblFullimg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullimg.AutoSize = true;
            this.lblFullimg.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullimg.Location = new System.Drawing.Point(67, 39);
            this.lblFullimg.Name = "lblFullimg";
            this.lblFullimg.Size = new System.Drawing.Size(70, 28);
            this.lblFullimg.TabIndex = 2;
            this.lblFullimg.Text = "50Mb";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 213);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 213);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmCache";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "缓存";
            this.Load += new System.EventHandler(this.FrmCache_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnCleanSmallImg;
        private Label lblSmallImg;
        private Button btnCleanFullImg;
        private Label lblFullimg;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}