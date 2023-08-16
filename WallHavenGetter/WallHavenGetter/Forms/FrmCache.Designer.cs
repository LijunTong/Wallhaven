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
            groupBox2 = new GroupBox();
            btnCleanSmallImg = new Button();
            lblSmallImg = new Label();
            groupBox3 = new GroupBox();
            btnCleanFullImg = new Button();
            lblFullimg = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCleanSmallImg);
            groupBox2.Controls.Add(lblSmallImg);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 89);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "缩略图";
            // 
            // btnCleanSmallImg
            // 
            btnCleanSmallImg.Location = new Point(136, 0);
            btnCleanSmallImg.Name = "btnCleanSmallImg";
            btnCleanSmallImg.Size = new Size(42, 26);
            btnCleanSmallImg.TabIndex = 3;
            btnCleanSmallImg.Text = "清除";
            btnCleanSmallImg.UseVisualStyleBackColor = true;
            btnCleanSmallImg.Click += btnCleanSmallImg_Click;
            // 
            // lblSmallImg
            // 
            lblSmallImg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSmallImg.AutoSize = true;
            lblSmallImg.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSmallImg.Location = new Point(60, 35);
            lblSmallImg.Name = "lblSmallImg";
            lblSmallImg.Size = new Size(70, 28);
            lblSmallImg.TabIndex = 2;
            lblSmallImg.Text = "50Mb";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCleanFullImg);
            groupBox3.Controls.Add(lblFullimg);
            groupBox3.Location = new Point(203, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(194, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "下载文件";
            // 
            // btnCleanFullImg
            // 
            btnCleanFullImg.Location = new Point(136, 0);
            btnCleanFullImg.Name = "btnCleanFullImg";
            btnCleanFullImg.Size = new Size(41, 26);
            btnCleanFullImg.TabIndex = 3;
            btnCleanFullImg.Text = "清除";
            btnCleanFullImg.UseVisualStyleBackColor = true;
            btnCleanFullImg.Click += btnCleanFullImg_Click;
            // 
            // lblFullimg
            // 
            lblFullimg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFullimg.AutoSize = true;
            lblFullimg.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullimg.Location = new Point(59, 35);
            lblFullimg.Name = "lblFullimg";
            lblFullimg.Size = new Size(70, 28);
            lblFullimg.TabIndex = 2;
            lblFullimg.Text = "50Mb";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 191);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmCache
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 191);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "FrmCache";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "缓存";
            Load += FrmCache_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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