using System.Text;

namespace _3_Modul.Lesson_6__File_.HomeTask._1_vazifa
{
    internal class FileTest
    {
        string filePath = @"C:\Desktopp\Desktop\FileTest\FileTest.txt";

        public void FileStart()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
            Console.ReadLine();

        }
        public void FileStart2()
        {
            // File.Create
            string filePath = @"C:\Desktopp\Desktop\FileTest\FileTest.txt";
            using (FileStream fs = File.Create(filePath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is a test.");
                fs.Write(info, 0, info.Length);
            }
            Console.WriteLine("File created successfully at: " + filePath);

            // File.Open
            if (File.Exists(filePath))
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine("File contents:");
                        Console.WriteLine(temp.GetString(b));
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist at: " + filePath);
            }

            // File.OpenRead
            if (File.Exists(filePath))
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine("File contents:");
                        Console.WriteLine(temp.GetString(b));
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist at: " + filePath);
            }

            // File.OpenWrite
            using (FileStream fs = File.OpenWrite(filePath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is an append test.");
                fs.Write(info, 0, info.Length);
            }
            Console.WriteLine("Data written successfully to: " + filePath);

            // File.ReadAllText
            string contents = File.ReadAllText(filePath);
            Console.WriteLine("File contents: " + contents);

            // File.WriteAllText
            string textToWrite = "This is a new test.";
            File.WriteAllText(filePath, textToWrite);
            Console.WriteLine("Data written successfully to: " + filePath);

            // File.Copy
            string sourceFile = filePath;
            string destinationFile = @"C:\Desktopp\Desktop\FileTest\FileTest2.txt";
            File.Copy(sourceFile, destinationFile, true);
            Console.WriteLine("File copied successfully from: " + sourceFile + " to: " + destinationFile);

            // File.Delete
            File.Delete(filePath);
            Console.WriteLine("File deleted successfully: " + filePath);
        }

        public static void SearchFilesAndDirectories(string directory, string searchText)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    if (Path.GetFileName(dir).Contains(searchText))
                    {
                        Console.WriteLine("Directory: " + dir);
                    }
                    SearchFilesAndDirectories(dir, searchText);
                }

                foreach (string file in Directory.GetFiles(directory))
                {
                    if (Path.GetFileName(file).Contains(searchText))
                    {
                        Console.WriteLine("File: " + file);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


    }
}

