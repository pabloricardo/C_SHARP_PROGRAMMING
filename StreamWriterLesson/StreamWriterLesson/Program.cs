using System;
using System.IO;

namespace StreamWriterLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            String baseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            String file1 = "file1.txt";
            String fileUper1 = "fileUper1.txt";
            String pathFile1 = baseDirectory + file1;
            String pathFileUper1 = baseDirectory + fileUper1;

            try
            {
                string[] lines = File.ReadAllLines(pathFile1);
                using (StreamWriter sw = File.AppendText(pathFileUper1))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
