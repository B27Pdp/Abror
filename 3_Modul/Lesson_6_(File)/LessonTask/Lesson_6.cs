using _3_Modul.Lesson_6__File_.HomeTask._1_vazifa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6__File_.LessonTask
{
    internal class Lesson_6
    {        
        public void Main_6()  
        {
            //vazifa_1();  
            //vazifaFul();  


            
            SearchFilesAndDirectories();
        }
        public void vazifa_1()
        {
           FileTest test= new FileTest();
            test.FileStart();
        }
        public void vazifaFul()
        {
            FileTest test = new FileTest();
            test.FileStart2();
        }

        public  void SearchFilesAndDirectories()
        {
            string rootDirectory = @"C:\Users\VICTUS";
            string searchText = "example";

            Console.WriteLine("Search results:");
            FileTest.SearchFilesAndDirectories(rootDirectory, searchText);
            using (StreamReader read = File.OpenText(files[0].FullName))
            {
                readFile = read.ReadToEnd();
            }
            Console.WriteLine(readFile);
        }

    }
}
