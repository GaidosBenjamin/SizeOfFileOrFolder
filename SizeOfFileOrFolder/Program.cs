using System;
using System.IO;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti path-ul folderului: ");
            string path = Console.ReadLine();

            SizeOfFileOrFolder s = new SizeOfFileOrFolder(path);
            s.size();
            
        }

    }
}
