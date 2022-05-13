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

namespace WallHavenGetter
{
    public partial class FrmImageShow : Form
    {
        private readonly List<WallhavenImgInfo> _wallhavenImgInfos;
        private readonly ILogger<FrmImageShow> _logger;
        private int _index = 0;
        private IWallhavenService wallhavenService;
        private readonly OptionsService optionsService;
        private AppOptions _appOptions;
        public FrmImageShow(FrmImageShowParams frmImageShowParams,
                            ILogger<FrmImageShow> logger, OptionsService optionsService)
        {
            InitializeComponent();
            this._wallhavenImgInfos = frmImageShowParams.WallhavenImgInfos;
            _index = this._wallhavenImgInfos.IndexOf(this._wallhavenImgInfos.FirstOrDefault(x => x.ImageName + "." + x.Extension == frmImageShowParams.Name));
            this._logger = logger;
            _appOptions = optionsService.GetAppOptions();
            this.optionsService = optionsService;
            WallServiceFactory wallServiceFactory = AppContext.GetService<WallServiceFactory>();
            wallhavenService = wallServiceFactory.Get();
        }

        private void FrmImageShow_Load(object sender, EventArgs e)
        {
            InitShow(_index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (++_index < _wallhavenImgInfos.Count)
            {
                InitShow(_index);
            }
            else
            {
                InitShow(--_index);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (--_index >= 0)
            {
                InitShow(_index);
            }
            else
            {
                InitShow(++_index);
            }
        }

        private void InitShow(int index)
        {
            
            Task.Run(() =>
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    Application.DoEvents();

                    var image = _wallhavenImgInfos[index];
                    string dir = Path.Combine(_appOptions.FullImageDir, image.ImageType);
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    string path = wallhavenService.DownloadFullImage(image, dir);
                    if (string.IsNullOrEmpty(path))
                    {
                        this.tbUrl.Text = "";
                        this.pictureBox1.Image = null;
                        this.Text = "获取失败";
                        return;
                    }
                    if (path.EndsWith("jpg"))
                    {
                        this.tbUrl.Text = image.JpgFullUrl;
                    }
                    else
                    {
                        this.tbUrl.Text = image.PngFullUrl;
                    }
                    this.Text = image.ImageName;
                    if (this.pictureBox1.Image != null)
                    {
                        this.pictureBox1.Image.Dispose();
                    }
                    this.pictureBox1.Image = new Bitmap(path);

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    MessageBox.Show("获取失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            });
        }

        private void FrmImageShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
            }
        }
    }
}
