using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\task4\students.dat";

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\task4\students\");

            if (directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            BinaryFormatter formatter = new BinaryFormatter();  

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Student[] student = (Student[])formatter.Deserialize(fs);

                Console.WriteLine("из файла считано:");

                Console.WriteLine(student.name);
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateofBirth { get; set; }

    }
}

