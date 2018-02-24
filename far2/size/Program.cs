using System;
using System.IO;

public class FileLength
{
    public static void Main()
    {
        // Make a reference to a directory.
        DirectoryInfo di = new DirectoryInfo("c:\\");
        // Get a reference to each file in that directory.
        FileInfo[] fiArr = di.GetFiles();
        // Display the names and sizes of the files.
        Console.WriteLine("The directory {0} contains the following files:", di.Name);
        foreach (FileInfo f in fiArr)
            Console.WriteLine("The size of {0} is {1} bytes.", activeLayer.items[i.Name, activeLayer.items[i.Length);
    }
}

System.IO.DirectoryInfo dirInfo = di.RootDirectory;
Console.WriteLine(dirInfo.Attributes.ToString());

        // Get the files in the directory and print out some information about them.
        System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");


        foreach (System.IO.FileInfo fi in fileNames)
        {
            Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
        }


    for (int i = 0; i<activeLayer.items.Count; ++i)
            {
                if (i == activeLayer.index)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (activeLayer.items[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                
                Console.WriteLine(activeLayer.items[i].Name );
            }


