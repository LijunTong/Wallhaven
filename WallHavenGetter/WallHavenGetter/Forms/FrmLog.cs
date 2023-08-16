using Jt.Common.Tool.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallHavenGetter.Forms
{
    public partial class FrmLog : Form
    {
        private FileSystemWatcher _watcher;
        private long _lastPosition = 0; // 上次读取的位置
        private string _filePath;

        public FrmLog()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                this.toolStripComboBoxDate.Items.Add(DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd"));
            }

            this.toolStripComboBoxType.Items.Add("错误日志");
            this.toolStripComboBoxType.Items.Add("其它日志");
        }

        private void toolStripComboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date
                 = this.toolStripComboBoxDate.SelectedItem?.ToString();
            string type = this.toolStripComboBoxType.SelectedItem?.ToString();
            if (date.IsNotNullOrWhiteSpace() && type.IsNotNullOrWhiteSpace())
            {
                _filePath = LoadLog(date, type);
                InitializeWatcher(_filePath);
            }
        }

        private void toolStripComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date
                 = this.toolStripComboBoxDate.SelectedItem?.ToString();
            string type = this.toolStripComboBoxType.SelectedItem?.ToString();
            if (date.IsNotNullOrWhiteSpace() && type.IsNotNullOrWhiteSpace())
            {
                _filePath = LoadLog(date, type);
                InitializeWatcher(_filePath);
            }
        }

        private string LoadLog(string date, string type)
        {
            if (type == "错误日志")
            {
                type = "Error";
            }
            else
            {
                type = "Info";
            }

            this.rtbLog.Clear();
            string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", date, type + ".log");
            if (!System.IO.File.Exists(logPath))
            {
                File.Create(logPath);
            }

            string[] lines = System.IO.File.ReadAllLines(logPath);
            foreach (string line in lines)
            {
                this.rtbLog.AppendText(line);
                this.rtbLog.AppendText(Environment.NewLine);
            }

            // 将光标定位到最后一行的开头
            rtbLog.SelectionStart = rtbLog.TextLength;

            // 滚动 RichTextBox 到光标所在位置
            rtbLog.ScrollToCaret();
            return logPath;
        }

        private void InitializeWatcher(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                _lastPosition = stream.Length; // 初始化上次读取的位置为文件长度

                _watcher = new FileSystemWatcher(Path.GetDirectoryName(filePath), Path.GetFileName(filePath));
                _watcher.NotifyFilter = NotifyFilters.Size;
                _watcher.Changed += OnFileChanged;
                _watcher.EnableRaisingEvents = true;
            }
        }

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            if (this.IsDisposed)
            {
                return;
            }

            if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                using (FileStream stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    stream.Seek(_lastPosition, SeekOrigin.Begin); // 移动到上次读取的位置
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string addedContent = reader.ReadToEnd(); // 读取新增的内容
                        if (addedContent.IsNullOrWhiteSpace())
                        {
                            return;
                        }

                        this.rtbLog.AppendText(addedContent);
                        // 将光标定位到最后一行的开头
                        rtbLog.SelectionStart = rtbLog.TextLength;

                        // 滚动 RichTextBox 到光标所在位置
                        rtbLog.ScrollToCaret();

                        _lastPosition = stream.Position; // 更新上次读取的位置
                    }
                }
            }
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            this.toolStripComboBoxDate.SelectedIndex = 0;
            this.toolStripComboBoxType.SelectedIndex = 0;
        }
    }
}
