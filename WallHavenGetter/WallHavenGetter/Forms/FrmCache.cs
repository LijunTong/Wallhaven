using Microsoft.Extensions.Logging;
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
    public partial class FrmCache : Form
    {
        private OptionsService _optionsService;
        private AppOptions _appOptions;
        private ILogger<FrmCache> _logger;
        public FrmCache(OptionsService optionsService, ILogger<FrmCache> logger)
        {
            _optionsService = optionsService;
            _appOptions = optionsService.GetAppOptions();
            InitializeComponent();
            _logger = logger;
        }

        private void FrmCache_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblSmallImg.Text = GetDirSize(_appOptions.SmallImageDir);
                this.lblFullimg.Text = GetDirSize(_appOptions.FullImageDir);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show("加载失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetDirSize(string dir)
        {
            long size = 0;
            FileHelper.GetDirSizeByPath(dir,ref  size);
            if (size >= 0 && size < 1024)
            {
                return $"{size}B";
            }
            else if (size >= 1024 && size < 1024 * 1024)
            {
                return $"{(double)size / 1024:f1}Kb";
            }
            else if (size >= 1024 * 1024 && size < 1024 * 1024 * 1024)
            {
                return $"{(double)size / (1024 * 1024):f1}Mb";
            }
            else
            {
                return $"{(double)size / (1024 * 1024 * 1024):f1}G";
            }
        }

        private void btnCleanSmallImg_Click(object sender, EventArgs e)
        {
            try
            {
                FileHelper.DelectDirectorys(_appOptions.SmallImageDir);
                this.lblSmallImg.Text = GetDirSize(_appOptions.SmallImageDir);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show("清除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleanFullImg_Click(object sender, EventArgs e)
        {
            try
            {
                FileHelper.DelectDirectorys(_appOptions.FullImageDir);
                this.lblFullimg.Text = GetDirSize(_appOptions.FullImageDir);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show("清除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
