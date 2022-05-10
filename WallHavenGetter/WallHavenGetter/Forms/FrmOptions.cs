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

        public FrmOptions(IniFileHelper iniFileHelper, OptionsService optionsService)
        {
            InitializeComponent();
            this.optionsService = optionsService;
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            this.bindingSource1.DataSource = optionsService.GetAppOptions();
            this.bindingSource1.EndEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppOptions appOptions = this.bindingSource1.DataSource as AppOptions;
            if (string.IsNullOrEmpty(appOptions.WallhavenBaseUrl))
            {
                MessageBox.Show("Wallhaven地址不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenSmallImgUrlRegex))
            {
                MessageBox.Show("缩略图地址正则不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenImgDetialsUrlFormat))
            {
                MessageBox.Show("详情地址格式不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(appOptions.WallhavenImgBaseUrlFormat))
            {
                MessageBox.Show("高清图地址格式不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(appOptions.SmallImageDir))
            {
                MessageBox.Show("缩略图目录不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(appOptions.SmallImageDir))
            {
                Directory.CreateDirectory(appOptions.SmallImageDir);
            }
            if (string.IsNullOrEmpty(appOptions.FullImageDir))
            {
                MessageBox.Show("下载目录不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(appOptions.FullImageDir))
            {
                Directory.CreateDirectory(appOptions.FullImageDir);
            }
            optionsService.SetAppOptions(appOptions);
            MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbSmallImgPath.Text = folderBrowserDialog.SelectedPath;
                this.bindingSource1.EndEdit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbFullImgPath.Text = folderBrowserDialog.SelectedPath;
                this.bindingSource1.EndEdit();
            }
        }
    }
}
