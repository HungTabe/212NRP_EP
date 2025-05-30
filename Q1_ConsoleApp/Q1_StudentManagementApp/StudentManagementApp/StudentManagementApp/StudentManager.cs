using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (Student student in students)
            {
                student.Display();
            }
        }

        public void PromoteStudents(IsPromotable isPromotable)
        {
            Console.WriteLine("Promotable Students:");
            foreach (Student student in students)
            {
                if (isPromotable(student))
                {
                    student.Display();
                }
            }
        }

        public static Student InputStudent()
        {
            Console.WriteLine("Enter student information:");

            Console.Write("Id: ");
            string idInput = Console.ReadLine();
            if (!int.TryParse(idInput, out int id))
            {
                throw new FormatException("Id must be an integer.");
            }

            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new FormatException("Name cannot be empty.");
            }

            Console.Write("Age: ");
            string ageInput = Console.ReadLine();
            if (!int.TryParse(ageInput, out int age))
            {
                throw new FormatException("Age must be an integer.");
            }

            return new Student(id, name, age);
        }
    }
}
