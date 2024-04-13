using SUT23_Labb1_LINQ.Data;
using SUT23_Labb1_LINQ.Models;
using System.Linq;

namespace SUT23_Labb1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SchoolDbContext context = new SchoolDbContext();
            MainMenu(context);
            //var Result = context.Students.Where(n => n.Name == "Anna");

            //foreach (var student in Result)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("Enter Subject");
            //string input = Console.ReadLine();

            //bool contains = context.Subjects.Any(s => s.SubjectName == input);

            //if(contains)
            //{
            //    Console.WriteLine("Yes, the subject is thought at the school");
            //}
            //else
            //{
            //    Console.WriteLine("No, the subject is not thought at the school");
            //}
        }
        private static void MainMenu(SchoolDbContext context)
        {
            bool programRunning = false;
            while (!programRunning)
            {
                Console.WriteLine("Option [1] Retreive all Teachers by Subject");
                Console.WriteLine("Option [2] Retreive all Students by Teacher");
                Console.WriteLine("Option [3] Look up Subject");
                Console.WriteLine("Option [4] Edit Subject Name");
                Console.WriteLine("Option [5] Update Student records");
                Console.WriteLine("Option [6] Exit Program");
                Console.WriteLine("Choose an option from the menu...");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        RetrieveTeacherBySubject(context);
                        break;
                    case "2":
                        Console.Clear();
                        RetrieveByTeacher(context);
                        Console.ReadKey();
                        break;
                    case "3":
                        RetrieveSubject(context);
                        break;
                    case "4":
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        programRunning = true;
                        break;
                }
            }
        }
        private static void RetrieveTeacherBySubject(SchoolDbContext context)
        {
            Console.WriteLine("Enter the Name of the Subject...");
            Console.Write("Name: ");
           
            string subjectName = Console.ReadLine();
            var teachers = context.TblTeacherSubjectsTest
            .Where(ts => ts.Subject.SubjectName == subjectName)
            .Select(ts => ts.Teacher.Name)
            .Distinct()
            .ToList();

            Console.WriteLine("List of Teachers:");
            foreach (var teacherName in teachers)
            {
                Console.WriteLine(teacherName);
            }
        }
        private static void RetrieveByTeacher(SchoolDbContext context)
        {
            Console.WriteLine("Enter the Name of the Teacher...");
            Console.Write("Name: ");
            string teacherName = Console.ReadLine();

            ICollection<Student> studentByTeacher = context.Students
                .Where(s => s.Teacher.Name == teacherName)
                .ToList();
            Console.WriteLine("List of Students ");
            foreach (Student student in studentByTeacher)
            {
                Console.WriteLine(student.Name);
            }
        }
        private static void RetrieveSubject(SchoolDbContext context)
        {
            Console.WriteLine("Enter Subject...");
            Console.Write("Subject: ");
            string input = Console.ReadLine();
            
            bool contains = context.Subjects.Any(s => s.SubjectName == input);

            if (contains)
            {
                Console.WriteLine("Yes, the subject is thought at the school");
            }
            else
            {
                Console.WriteLine("No, the subject is not thought at the school");
            }
        }
    }
}
