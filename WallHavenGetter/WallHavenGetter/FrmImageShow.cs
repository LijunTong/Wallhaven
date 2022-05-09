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
using WallHavenGetter.Utils;

namespace WallHavenGetter
{
    public partial class FrmImageShow : Form
    {
        private readonly List<WallhavenImgInfo> _wallhavenImgInfos;
        private int _index = 0;
        private Stream _stream;

        public FrmImageShow(List<WallhavenImgInfo> wallhavenImgInfos,string name)
        {
            InitializeComponent();
            this._wallhavenImgInfos = wallhavenImgInfos;
            _index = this._wallhavenImgInfos.IndexOf(this._wallhavenImgInfos.FirstOrDefault(x => x.ImageName+"."+x.Extension == name));
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
                    string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "full", image.ImageType);
                    string path = WallhavenHtmlParse.DownloadFullImage(image, dir);
                    if (string.IsNullOrEmpty(path))
                    {
                        return;
                    }
                    this.pictureBox1.Image = new Bitmap(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            });
        }
    }
}
