using StudentManagementApp;

class Program
{
    // A sample promotion rule
    public static bool PromoteIfAdult(Student student)
    {
        return student.Age >= 18;
    }

    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();

        // Add students
        manager.AddStudent(new Student(1, "Alice", 17));
        manager.AddStudent(new Student(2, "Bob", 19));
        manager.AddStudent(new Student(3, "Charlie", 16));
        manager.AddStudent(new Student(4, "Diana", 18));

        // DisplayStudents
        manager.DisplayStudents();

        // Display promotable students (using the PromoteIfAdult rule)
        Console.WriteLine();
        manager.PromoteStudents(PromoteIfAdult);
        Console.WriteLine();


        // Question 1 : Part 2
        try
        {
            Console.WriteLine("Input a student:");
            Student newStudent = StudentManager.InputStudent();
            manager.AddStudent(newStudent);

            Console.WriteLine("\nInput another student:");
            newStudent = StudentManager.InputStudent();
            manager.AddStudent(newStudent);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return; // Stop if input is invalid
        }

        // DisplayStudents
        Console.WriteLine();
        manager.DisplayStudents();

        // PromoteStudents
        Console.WriteLine();
        manager.PromoteStudents(PromoteIfAdult);
    }
}