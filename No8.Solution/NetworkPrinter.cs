using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    public class NetworkPrinter : IPrinter
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Print(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }

            return null;
        }
    }
}
