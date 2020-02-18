using System;
using System.IO;
using System.Reflection;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            String baseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            String fileName = "file1.txt";
            String path = baseDirectory + fileName;
            Console.WriteLine("File path: \n" + path);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
