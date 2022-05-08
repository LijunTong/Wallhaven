using Manina.Windows.Forms;
using System.IO;
using WallHavenGetter.Models;
using WallHavenGetter.Utils;
using static Manina.Windows.Forms.ImageListView;

namespace WallHavenGetter
{
    public partial class FrmMain : Form
    {
        List<WallhavenImgInfo> _imgInfos = new List<WallhavenImgInfo>();
        SerachParam _serachParam = new SerachParam();
        List<ImageListViewItem> _imageListViewItems = new List<ImageListViewItem>();
        private int _threadCnt = 4;
        private int _index = -1;
        private object _lockerSaveAs = new object();
        private object _locker = new object();

        
        public FrmMain()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void toolStripComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUrlTb();
        }

        #region 方法

        private void Init()
        {
            this.toolStripComboBoxType.Items.AddRange(Constant.SerachType.ToArray());
            this.toolStripComboBoxType.SelectedIndex = 0;
        }

        private string SetUrlTb()
        {
            KeyVal keyVal = toolStripComboBoxType.SelectedItem as KeyVal;
            _serachParam.BaseUrl = Constant.WallhavenBaseUrl;
            _serachParam.Type = keyVal.Value;
            _serachParam.Page = int.Parse(this.toolStripTextBoxPage.Text);
            this.toolStripTextBoxUrl.Text = _serachParam.Url;
            return _serachParam.Url;
        }

        private void InitList(int page, int pageSize)
        {
            _imgInfos.Clear();
            _imageListViewItems.Clear();
            this.imageListView1.Items.Clear();
            int length = page * pageSize; 
            for (int i = 0; i < length; i++)
            {
                _imgInfos.Add(new WallhavenImgInfo());
                _imageListViewItems.Add(new ImageListViewItem());
            }
            this.imageListView1.Items.AddRange(_imageListViewItems.ToArray());
        }

        private List<WallhavenImgInfo> GetList()
        {
            List<WallhavenImgInfo> imgList = new List<WallhavenImgInfo>();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var urls = _serachParam.PageUrls();
                foreach (var url in urls)
                {
                    SetStatus($"正在加载：{urls.IndexOf(url) + 1}/{urls.Count}页", Color.Red);
                    if (string.IsNullOrEmpty(url))
                    {
                        continue;
                    }
                    Uri uri = new Uri(url);
                    var smallUrls = WallhavenHtmlParse.GetSmallImgUrl(uri);
                    var imgs = WallhavenHtmlParse.ParseImgUrl(smallUrls);
                    InitPBar(imgs.Count);
                    imgList.AddRange(imgs);
                }
                SetStatus($"合计：{imgList.Count}", Color.Green);
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus($"获取失败", Color.Red);

            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
            return imgList;
        }

        private void AddImgs(List<WallhavenImgInfo> imgs)
        {
            foreach (WallhavenImgInfo im in imgs)
            {
                if (!_imgInfos.Any(x => x.ImageName == im.ImageName))
                {
                    _imgInfos.Add(im);
                }
            }
        }

        private void Get()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "samll", this.toolStripComboBoxType.Text);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            this.imageListView1.Items.Clear();
            this._imgInfos.Clear();
            _index = -1;
            Task.Run(() =>
            {
                toolStripToolBar.Enabled = false;
                _imgInfos = GetList();
                if (_imgInfos.Count > 0)
                {
                    InitPBar(_imgInfos.Count);
                    int barVal = 0;
                    TaskRun(_threadCnt,
                        () =>
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
                                    Stream stream = HttpHelper.HttpDownload(item.SmallUrl);
                                    if (stream != null)
                                    {
                                        lock (_lockerSaveAs)
                                        {
                                            stream.SaveAs(path);
                                        }
                                    }
                                }
                                ImageListViewItem image = new ImageListViewItem(path);
                                Console.WriteLine(item.DetialsUrl);
                                string url = WallhavenHtmlParse.GetFullImgUrl(item.DetialsUrl);
                                lock (_locker)
                                {
                                    this.imageListView1.Items.Add(image);
                                    item.FullUrl = url;
                                }
                                Console.WriteLine(index+":"+ url);
                                Interlocked.Increment(ref barVal);
                                SetPBar(barVal);
                                Thread.Sleep(20);
                            }
                        },
                        () =>
                        {
                            DisPBar();
                            _imgInfos = _imgInfos.OrderBy(x => this.imageListView1.Items.ToList().IndexOf(this.imageListView1.Items.FirstOrDefault(o => o.Text.StartsWith(x.ImageName)))).ToList();
                            toolStripToolBar.Enabled = true;
                        });
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
            this.tsPBarLoadStatus.Maximum = maxVal;
            this.tsPBarLoadStatus.Visible = true;
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
            if (string.IsNullOrEmpty(this.toolStripTextBoxPage.Text))
            {
                this.toolStripTextBoxPage.Text = "1";
            }
            SetUrlTb();
        }

        private void toolStripButtonGet_Click(object sender, EventArgs e)
        {
            Get();
        }

        private void imageListView1_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            ImageListViewItem image = e.Item;
            FrmImageShow frmImageShow = new FrmImageShow(_imgInfos, image.Text);
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

        private void Downlad(ImageListViewSelectedItemCollection listViewItems)
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "full", this.toolStripComboBoxType.Text);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            SetStatus($"正在下载：{listViewItems.Count}", Color.Red);
            InitPBar(listViewItems.Count);
            int mIndex = -1;
            int bVal = 0;
            TaskRun(_threadCnt, () => 
            {
                while(mIndex< listViewItems.Count)
                {
                    int index = Interlocked.Increment(ref mIndex);
                    if (index >= listViewItems.Count)
                    {
                        continue;
                    }
                    Console.WriteLine(index); 
                    var item = listViewItems[index];
                    
                    var wallhaven = _imgInfos.FirstOrDefault(x => item.Text.StartsWith( x.ImageName));
                    Console.WriteLine(item.Text + "=====" + wallhaven?.FullUrl);
                    if (wallhaven != null && !string.IsNullOrEmpty(wallhaven.FullUrl))
                    {
                        string path = Path.Combine(dir, wallhaven.ImageName + "." + wallhaven.Extension);
                        var stream = HttpHelper.HttpDownload(wallhaven.FullUrl);
                        if (stream != null)
                        {
                            lock (_lockerSaveAs)
                            {
                                stream.SaveAs(path);
                            }
                        }
                    }
                    Interlocked.Increment(ref bVal);
                    SetPBar(bVal);
                }
            }, () => 
            {
                DisPBar();
                SetStatus("下载完成", Color.Green);
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
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "full", this.toolStripComboBoxType.Text);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + dir;
            System.Diagnostics.Process.Start(psi);
        }
    }
}