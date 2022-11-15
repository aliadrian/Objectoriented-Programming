using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //public delegate bool FileFilter(string filePath);
    public class FileFinder
    {
        public void GetFiles(string dirPath, Func<string, bool> fileFilter)
        {
            string[] filePaths = Directory.GetFiles(dirPath);
            foreach (string filePath in filePaths)
            {
                if (fileFilter(filePath))
                {
                    Console.WriteLine(filePath);
                }
            }
        }
    }
}
