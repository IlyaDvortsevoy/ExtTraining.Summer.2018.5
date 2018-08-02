using System;
using System.IO;
using System.Text;

namespace No8.Solution
{
    // Реализует конкретную функциональность логирвоания в файл
    public class FileLogger : ILog
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(
                    $"Argument should exist {nameof(path)}");
            }

            _path = path;
        }

        public void Log(string s)
        {
            using (FileStream fs = File.Create(_path))
            {
               
                byte[] info = new UTF8Encoding(true).GetBytes(s);
                fs.Write(info, 0, info.Length);
               
                byte[] data = new byte[] { 0x0 };
                fs.Write(data, 0, data.Length);
            }
        }
    }
}
