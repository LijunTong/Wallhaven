using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallHavenGetter.Utils
{
    public static class StreamHelper
    {
        public static string SaveAs(this Stream stream, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            int size = 1024 * 1024;
            byte[] buffer = new byte[size];
            int bytesRead = stream.Read(buffer, 0, size);
            while (bytesRead > 0)
            {
                fileStream.Write(buffer, 0, bytesRead);
                bytesRead = stream.Read(buffer, 0, size);
            }
            fileStream.Close();
            stream.Close();
            return path;
        }
    }
}
