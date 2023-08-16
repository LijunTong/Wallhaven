namespace WallHavenGetter.Forms
{
    partial class FrmLog
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
            toolStrip1 = new ToolStrip();
            toolStripComboBoxDate = new ToolStripComboBox();
            toolStripComboBoxType = new ToolStripComboBox();
            rtbLog = new RichTextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBoxDate, toolStripComboBoxType });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxDate
            // 
            toolStripComboBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxDate.Name = "toolStripComboBoxDate";
            toolStripComboBoxDate.Size = new Size(121, 25);
            toolStripComboBoxDate.SelectedIndexChanged += toolStripComboBoxDate_SelectedIndexChanged;
            // 
            // toolStripComboBoxType
            // 
            toolStripComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxType.Name = "toolStripComboBoxType";
            toolStripComboBoxType.Size = new Size(121, 25);
            toolStripComboBoxType.SelectedIndexChanged += toolStripComboBoxType_SelectedIndexChanged;
            // 
            // rtbLog
            // 
            rtbLog.BackColor = SystemColors.InfoText;
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.ForeColor = SystemColors.Window;
            rtbLog.Location = new Point(0, 25);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(800, 425);
            rtbLog.TabIndex = 1;
            rtbLog.Text = "";
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbLog);
            Controls.Add(toolStrip1);
            Name = "FrmLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "日志";
            Load += FrmLog_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBoxDate;
        private ToolStripComboBox toolStripComboBoxType;
        private RichTextBox rtbLog;
    }
}