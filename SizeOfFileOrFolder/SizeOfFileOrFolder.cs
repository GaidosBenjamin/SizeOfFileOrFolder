using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SizeOfFileOrFolder
{
    public class SizeOfFileOrFolder
    {
        private static long totalSize;

        public SizeOfFileOrFolder(string path)
        {
            totalSize = 0;
            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessFolder(path);
            }
        }

        private static void ProcessFile(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi)
            {
                Console.WriteLine("FileName: {0}, FileSize: {1}", f.Name, f.Length);
                totalSize += f.Length;
            }
        }

        private static void ProcessFolder(string path)
        {
            ProcessFile(path);

            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
                ProcessFolder(folder);
        }

        public void size()
        {
            Console.WriteLine("Total size of File/Folder is: {0} bytes.", totalSize);
        }
    }
}
