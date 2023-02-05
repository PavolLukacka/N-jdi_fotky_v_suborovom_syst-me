using System;
using System.IO;

namespace PhotoRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mepla\OneDrive\Počítač\FOTO -bezwattermark MZ";
            int index = 1;
            string[] extensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

            string[] files = Directory.GetFiles(path);
            Array.Sort(files);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                if (Array.IndexOf(extensions, extension) == -1)
                {
                    continue;
                }

                string newName = index.ToString() + extension;
                string newPath = Path.Combine(path, newName);

                File.Move(file, newPath);
                index++;
            }
        }
    }
}
