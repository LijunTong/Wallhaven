using Manina.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;
using WallHavenGetter.Forms;
using WallHavenGetter.Models;
using WallHavenGetter.Services;
using WallHavenGetter.Utils;
using static Manina.Windows.Forms.ImageListView;

namespace WallHavenGetter
{
    public partial class FrmMain : Form
    {
        List<WallhavenImgInfo> _imgInfos = new List<WallhavenImgInfo>();
        private int _threadCnt = 4;
        private int _index = -1;
        private object _lockerSaveAs = new object();
        private object _locker = new object();
        private readonly ILogger<FrmMain> logger;
        private readonly FrmImageShowParams frmImageShowParams;
        private AppOptions _appOptions;
        private readonly OptionsService _optionsService;
        private readonly WallhavenService _whHtmlParseService;
        
        public FrmMain(ILogger<FrmMain> logger,
                       FrmImageShowParams frmImageShowParams,
                       OptionsService optionsService,
                       WallhavenService whHtmlParseService)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.logger = logger;
            this.frmImageShowParams = frmImageShowParams;
            _optionsService = optionsService;
            _appOptions = _optionsService.GetAppOptions();
            _whHtmlParseService = whHtmlParseService;
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            logger.LogInformation("程序启动");
            Init();
        }

        private void toolStripComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyVal keyVal = this.toolStripComboBoxType.SelectedItem as KeyVal;
            if (keyVal.Value == "input")
            {
                this.tsLblKey.Visible = true;
                this.toolStripTextBoxInput.Visible = true;
                this.toolStripDropDownOption.Visible = true;
                this.toolStripLabelSort.Visible = true;
                this.toolStripComboBoxSort.Visible = true;
                this.toolStripTextBoxInput.Text = String.Empty;
            }
            else
            {
                this.tsLblKey.Visible = false;
                this.toolStripTextBoxInput.Visible = false;
                this.toolStripDropDownOption.Visible = false;
                this.toolStripLabelSort.Visible = false;
                this.toolStripComboBoxSort.Visible = false;
                this.toolStripTextBoxInput.Text = String.Empty;
            }
            SetUrl();
        }

        #region 方法

        private void Init()
        {
            this.toolStripComboBoxSort.Items.AddRange(Constant.SortType.ToArray());
            this.toolStripComboBoxSort.SelectedIndex = 0;

            this.toolStripComboBoxType.Items.AddRange(Constant.SerachType.ToArray());
            this.toolStripComboBoxType.SelectedIndex = 4;


            this.tsPBarLoadStatus.Visible = false;
        }

        private SerachParam GetSerachParam()
        {
            SerachParam serachParam = new SerachParam();
            serachParam.BaseUrl = _appOptions.WallhavenBaseUrl;
            KeyVal keyValType = toolStripComboBoxType.SelectedItem as KeyVal;

            if (keyValType != null)
            {
                serachParam.Type = keyValType.Value;
            }
            
            int.TryParse(this.toolStripTextBoxPage.Text,out int page);
            if (page == 0)
            {
                page = 1;
            }
            else if (page > 100)
            {
                page = 100;
            }
            serachParam.Page = page;
            serachParam.Q = this.toolStripTextBoxInput.Text;
            string general = this.toolItemGeneral.Checked ? "1" : "0";
            string anime = this.toolItemAnime.Checked ? "1" : "0";
            string people = this.toolitemPeople.Checked ? "1" : "0";
            serachParam.Categories = $"{general}{anime}{people}";
            KeyVal keyValSort = toolStripComboBoxSort.SelectedItem as KeyVal;
            if (keyValSort != null)
            {
                serachParam.Sorting = keyValSort.Value;

            }
            return serachParam;
        }

        private List<WallhavenImgInfo> GetList(SerachParam serachParam)
        {
            List<WallhavenImgInfo> imgList = new List<WallhavenImgInfo>();
            try
            {
                toolStripToolBar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                var urls = serachParam.PageUrls();
                InitPBar(urls.Count);
                foreach (var url in urls)
                {
                    SetPBar(urls.IndexOf(url) + 1);
                    SetStatus($"正在加载：{urls.IndexOf(url) + 1}/{urls.Count}页", Color.Red);
                    
                    if (string.IsNullOrEmpty(url))
                    {
                        continue;
                    }
                    Uri uri = new Uri(url);
                    var smallUrls = _whHtmlParseService.GetSmallImgUrl(uri);
                    var imgs = _whHtmlParseService.ParseImgUrl(smallUrls);
                    imgList.AddRange(imgs);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(message: ex.ToString());
                MessageBox.Show("获取失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus($"获取失败", Color.Red);

            }
            finally
            {
                toolStripToolBar.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            return imgList;
        }

        private void Get(SerachParam serachParam)
        {
            string dir = Path.Combine(_appOptions.SmallImageDir, this.toolStripComboBoxType.Text);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            this.imageListView1.Items.Clear();
            this._imgInfos.Clear();
            _index = -1;
            Task.Run(() =>
            {
                _imgInfos = GetList(serachParam);
                if (_imgInfos.Count > 0)
                {
                    toolStripToolBar.Enabled = false;
                    InitPBar(_imgInfos.Count);
                    int barVal = 0;
                    TaskRun(_threadCnt,
                        () =>
                        {
                            GetSmallImage(_imgInfos.Count,ref barVal, dir);
                        },
                        () =>
                        {
                            GetCallBack(_imgInfos.Count);
                        });
                }
                else
                {
                    SetStatus("无匹配结果，尝试使用英文关键字",Color.Red);
                    DisPBar();
                }
            });
        }

        private void SetStatus(string text,Color color)
        {
            this.tsLoadStatus.Text = text;
            this.tsLoadStatus.ForeColor = color;
        }

        private void InitPBar(int maxVal)
        {
            this.tsPBarLoadStatus.Visible = true;
            this.tsPBarLoadStatus.Maximum = maxVal;
        }

        private void SetPBar(int val)
        {
            if (val <= this.tsPBarLoadStatus.Maximum)
            {
                this.tsPBarLoadStatus.Value = val;
            }
        }

        private void DisPBar()
        {
            this.tsPBarLoadStatus.Maximum = 0;
            this.tsPBarLoadStatus.Visible = false;
            this.tsPBarLoadStatus.Value = 0;
        }

        private void GetSmallImage(int total,ref int barVal,string dir)
        {
            while (_index < _imgInfos.Count)
            {
                Interlocked.Increment(ref _index);
                int index = _index;
                if (index >= _imgInfos.Count)
                {
                    continue;
                }
                var item = _imgInfos[index];
                item.ImageType = this.toolStripComboBoxType.Text;
                string path = Path.Combine(dir, item.ImageName + "." + item.Extension);
                if (!File.Exists(path))
                {
                    Stream stream = _whHtmlParseService.DownSmallImg(item.SmallUrl);
                    if (stream != null)
                    {
                        lock (_lockerSaveAs)
                        {
                            stream.SaveAs(path);
                        }
                    }
                }
                ImageListViewItem image = new ImageListViewItem(path);
                lock (_locker)
                {
                    this.imageListView1.Items.Add(image);
                }
                Interlocked.Increment(ref barVal);
                SetPBar(barVal);
                SetStatus($"正在加载：{barVal}/{total}", Color.Red);
                
                Application.DoEvents();
            }
        }
        private void GetCallBack(int total)
        {
            DisPBar();
            _imgInfos = _imgInfos.OrderBy(x => this.imageListView1.Items.ToList().IndexOf(this.imageListView1.Items.FirstOrDefault(o => o.Text.StartsWith(x.ImageName)))).ToList();
            toolStripToolBar.Enabled = true;
            SetStatus($"加载完成：{total}", Color.Red);
        }

        private void Downlad(ImageListViewSelectedItemCollection listViewItems)
        {
            this.toolStripToolBar.Enabled = false;
            this.imageListView1.Enabled = false;
            string dir = Path.Combine(_appOptions.FullImageDir, this.toolStripComboBoxType.Text);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            SetStatus($"正在下载：{listViewItems.Count}", Color.Red);
            InitPBar(listViewItems.Count);
            int mIndex = -1;
            int bVal = 0;
            int downloadOkCnt = 0;
            TaskRun(_threadCnt, () =>
            {
                while (mIndex < listViewItems.Count)
                {
                    int index = Interlocked.Increment(ref mIndex);
                    if (index >= listViewItems.Count)
                    {
                        continue;
                    }
                    var item = listViewItems[index];

                    var wallhaven = _imgInfos.FirstOrDefault(x => item.Text.StartsWith(x.ImageName));
                    if (wallhaven != null)
                    {
                        string path = _whHtmlParseService.DownloadFullImage(wallhaven, dir);
                        if (!string.IsNullOrEmpty(path))
                        {
                            Interlocked.Increment(ref downloadOkCnt);
                        }
                    }
                    Interlocked.Increment(ref bVal);
                    SetPBar(bVal);
                    SetStatus($"正在下载：{bVal}/{listViewItems.Count}", Color.Red);
                    Application.DoEvents();
                }
            }, () =>
            {
                this.toolStripToolBar.Enabled = true;
                this.imageListView1.Enabled = true;
                DisPBar();
                SetStatus($"下载成功：{downloadOkCnt}/{listViewItems.Count}", Color.Green);
            });




        }

        #endregion


        private void toolStripTextBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            
        }

        private void toolStripTextBoxPage_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonGet_Click(object sender, EventArgs e)
        {
            SerachParam serachParam = GetSerachParam();
            Get(serachParam);
            //if (serachParam != null)
            //{
            //    if (serachParam.Type == "input" && string.IsNullOrWhiteSpace(serachParam.Q))
            //    {
            //        MessageBox.Show("请输入关键词", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
                
            //}
        }

            private void imageListView1_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            ImageListViewItem image = e.Item;
            frmImageShowParams.WallhavenImgInfos = _imgInfos;
            frmImageShowParams.Name = image.Text;
            var frmImageShow = AppContext.GetService<FrmImageShow>();
            frmImageShow.ShowDialog();
        }

        private void toolStripButtonDownload_Click(object sender, EventArgs e)
        {
            if (this.imageListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Task.Run(() =>
            {
                Downlad(this.imageListView1.SelectedItems);
            });
           
        }

        

        private void TaskRun(int threadCnt, Action action, Action callback)
        {
            Task[] tasks = new Task[threadCnt];
            for (int i = 0; i < threadCnt; i++)
            {
                var task = Task.Run(action);
                tasks[i] = task;
            }
            Task.WaitAll(tasks);
            callback.Invoke();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.imageListView1.Items)
            {
                item.Selected = true;
            }
            this.imageListView1.Update();

            toolStripButtonDownload_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string dir = Path.Combine(_appOptions.FullImageDir);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + dir;
            System.Diagnostics.Process.Start(psi);
        }

        private void toolStripTextBoxPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.toolStripTextBoxPage.Text))
            {
                this.toolStripTextBoxPage.Text = "1";
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.LogInformation("程序退出");
        }

        private void toolItemSet_Click(object sender, EventArgs e)
        {
            var frm = AppContext.GetService<FrmOptions>();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _appOptions = _optionsService.GetAppOptions();
            }
        }

        private void toolItemCache_Click(object sender, EventArgs e)
        {
            var frm = AppContext.GetService<FrmCache>();
            frm.ShowDialog();
        }

        private void toolItemAbout_Click(object sender, EventArgs e)
        {
            var frm = AppContext.GetService<FrmAbout>();
            frm.ShowDialog();
        }


        private void toolStripTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            SetUrl();
        }

        private void toolStripComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUrl();
        }

        private void SetUrl()
        {
            var serachParam = GetSerachParam();
            this.toolStripTextBoxUrl.Text = serachParam.Url;
        }

        private void toolItemGeneral_CheckedChanged(object sender, EventArgs e)
        {
            SetUrl();
        }
    }
}