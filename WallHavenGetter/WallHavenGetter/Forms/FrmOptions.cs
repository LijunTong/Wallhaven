using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallHavenGetter.Models;
using WallHavenGetter.Services;
using WallHavenGetter.Utils;

namespace WallHavenGetter.Forms
{
    public partial class FrmOptions : Form
    {
        private readonly OptionsService optionsService;

        public FrmOptions(OptionsService optionsService)
        {
            InitializeComponent();
            this.optionsService = optionsService;
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            var data = optionsService.GetAppOptions();
            this.appOptionsBindingSource.DataSource = data;
            this.appOptionsBindingSource.EndEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Apply())
            {
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = this.tbSmallImgPath.Text;
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbSmallImgPath.Text = folderBrowserDialog.SelectedPath;
                this.appOptionsBindingSource.EndEdit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = this.tbFullImgPath.Text;
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbFullImgPath.Text = folderBrowserDialog.SelectedPath;
                this.appOptionsBindingSource.EndEdit();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private bool Apply()
        {
            AppOptions appOptions = this.appOptionsBindingSource.DataSource as AppOptions;
            if (string.IsNullOrEmpty(appOptions.WallhavenBaseUrl))
            {
                MessageBox.Show("Wallhaven地址不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenSmallImgUrlRegex))
            {
                MessageBox.Show("缩略图地址正则不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenImgDetialsUrlFormat))
            {
                MessageBox.Show("详情地址格式不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenImgBaseUrlFormat))
            {
                MessageBox.Show("高清图地址格式不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(appOptions.SmallImageDir))
            {
                MessageBox.Show("缩略图目录不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Directory.Exists(appOptions.SmallImageDir))
            {
                Directory.CreateDirectory(appOptions.SmallImageDir);
            }
            if (string.IsNullOrEmpty(appOptions.FullImageDir))
            {
                MessageBox.Show("下载目录不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Directory.Exists(appOptions.FullImageDir))
            {
                Directory.CreateDirectory(appOptions.FullImageDir);
            }
            optionsService.SetAppOptions(appOptions);
            return true;
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMode.SelectedItem.ToString() == "爬虫")
            {
                this.tabControl1.SelectedIndex = 1;
            }
            else
            {
                this.tabControl1.SelectedIndex = 2;
            }
        }

        private void btnSelectCachePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSmallImgPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelectDownPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbFullImgPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
