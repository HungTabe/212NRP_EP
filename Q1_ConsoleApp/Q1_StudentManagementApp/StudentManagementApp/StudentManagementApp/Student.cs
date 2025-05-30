using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{

    public delegate bool IsPromotable(Student student);

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}
