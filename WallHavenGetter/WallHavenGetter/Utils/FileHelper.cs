using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public class FileHelper
    {
        /// <summary>
        /// 获取某一文件夹的大小
        /// </summary>
        /// <param name="dir">文件夹目录</param>
        /// <param name="dirSize">文件夹大小</param>
        public static void GetDirSizeByPath(string dir, ref long dirSize)
        {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);

                DirectoryInfo[] dirs = dirInfo.GetDirectories();
                FileInfo[] files = dirInfo.GetFiles();

                foreach (var item in dirs)
                {
                    GetDirSizeByPath(item.FullName, ref dirSize);
                }

                foreach (var item in files)
                {
                    dirSize += item.Length;
                }

        }

        /// <summary>
        /// 删除一个文件夹下所有的文件
        /// </summary>
        /// <param name="srcPath"></param>
        public static void DelectDirectorys(string srcPath)
        {
            DirectoryInfo dir = new DirectoryInfo(srcPath);
            FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
            foreach (FileSystemInfo i in fileinfo)
            {
                if (i is DirectoryInfo)//判断是否文件夹
                {
                    DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                    subdir.Delete(true); //删除子目录和文件
                }
                else
                {
                    File.Delete(i.FullName); //删除指定文件
                }
            }
        }

    }
}
