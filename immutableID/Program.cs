using System;
namespace Demo
{
    class Program 
    {

    public record Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }// student 
        // parameterized constructor
        public Student(int i)
        {
            Id = i;
            FirstName = string.Empty;
            LastName = string.Empty;
        }// student 

        public Student(int i, string firstname, string lastname)
        {
            Id = i;
            FirstName = firstname;
            LastName = lastname;
        }// student 

    }// student 
    public static void Main()
        {

        Student student1 = new(1);
        student1.FirstName = "Dan";
        student1.LastName = "Smith";

        Student student2 = new(2, "Bob", "Williams");

        Console.WriteLine(student1);
        Console.WriteLine(student2);

    }
    }
}

