using System;
using System.Linq;


namespace StudentCrudCLI
{

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                AppMenu();
                int choice = GetValidInt("Enter Your Choice: ");
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudent();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                }
            }
        }
        static void AppMenu()
        {
            Console.Clear();
            Console.WriteLine("Student DataBase:");
            Console.WriteLine("Select your choice from below");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View Student");
            Console.WriteLine("3.Update Student");
            Console.WriteLine("4.Delete Student");
            Console.WriteLine("5.Exit");
        }
        static void AddStudent()
        {
            using(var db = new StudentContext())
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                int age = GetValidInt("Enter Age: ");

                var students = new Model { Name = name, Age = age };
                db.Students.Add(students);
                db.SaveChanges();

                Console.WriteLine("Student added successfully.");
                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
            }
        }
        static void ViewStudent()
        {
            using (var db = new StudentContext())
            {
                var student = db.Students.ToList();
                Console.WriteLine("\nStudent List:");
                foreach(var students in student)
                {
                    Console.WriteLine($"ID: {students.Id} Name: {students.Name} Age: {students.Age}");

                }
                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
            }
        }
        static void UpdateStudent()
        {
            using (var db = new StudentContext())
            {
                int id = GetValidInt("Enter id: ");
                var student = db.Students.Find(id);
                if (student != null)
                {
                    Console.Write("Enter Name: ");
                    student.Name = Console.ReadLine();
                    student.Age = GetValidInt("Enter Age: ");

                    db.SaveChanges();

                    Console.WriteLine("Student updated successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found!");
                }
                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
            }

        }
        static void DeleteStudent()
        {
            using (var db = new StudentContext())
            {
                int id = GetValidInt("Enter id: ");
                var student = db.Students.Find(id);
                if (student != null)
                {

                    db.Students.Remove(student);
                    db.SaveChanges();

                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found!");
                }
                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
            }

        }
        public static int GetValidInt(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int n))
                    return n;
                else
                    Console.WriteLine("Please enter valid id");
            }
        }
    }
}
