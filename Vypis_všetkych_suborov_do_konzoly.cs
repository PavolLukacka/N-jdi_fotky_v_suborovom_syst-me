
using System;
using System.Collections.Generic;
using System.IO;

namespace ImageComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Users\mepla\OneDrive\Počítač\FOTO- wattermark";
            List<string> folderFiles = new List<string>(Directory.GetFiles(folderPath));
            foreach (string file in folderFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}