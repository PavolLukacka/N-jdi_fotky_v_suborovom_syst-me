using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"\\192.168.0.175\projekty\E-PROJEKT\Klienti\LOKÁLNE ZDROJE";
        string targetPath = @"C:\Users\mepla\OneDrive\Počítač\LZ";
        HashSet<string> badWords = new HashSet<string> { "CP", "FA", "p-1", "p-2", "p-3", "p-4", "p-5", "p-6", 
                                                         "p-7", "p-8", "p-9", "p-10", "p-11", "p-12", "p-13", "p-14", "p-15", "audit", "zmluva", "LV", "fázy","layout"};
        
        // Get all image files in the source folder
        string[] images = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories)
        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".gif") || s.EndsWith(".jpeg") || s.EndsWith(".tiff")).ToArray();
        // Get all subfolders in the source folder
        string[] folders = Directory.GetDirectories(sourcePath);

        Console.WriteLine("Found " + images.Length + " images in the source folder.");

        // Copy each image to the target folder
        foreach (string image in images)
        {
            string folder_path = Path.GetDirectoryName(image);
            string fileName = Path.GetFileName(image);
            //check if the folder path contains bad words, those images skip
            if (badWords.Any(fileName.Contains))
            {
                continue;
            }
            // Get the last part of the folder name, which should be the city
            string city = folder_path.Split('\\')[3];
            // Get the target folder for the image
            Console.WriteLine("Found image:{0} with name: {1} ", city, Path.GetFileName(image));
            string destFile = Path.Combine(targetPath, city);
            File.Copy(image, destFile + fileName , true);
        }
    }
}