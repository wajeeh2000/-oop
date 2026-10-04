using System;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Console.WriteLine("Person constructor");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine(Name + " - " + Email);
    }
}

class Student : Person
{
    public int StudentId;
    public double GPA;

    public Student(string name, string email, int id, double gpa)
        : base(name, email)
    {
        Console.WriteLine("Student constructor");
        StudentId = id;
        GPA = gpa;
    }
}

class Employee : Person
{
    public int EmployeeId;
    public double Salary;

    public Employee(string name, string email, int id, double salary)
        : base(name, email)
    {
        Console.WriteLine("Employee constructor");
        EmployeeId = id;
        Salary = salary;
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, int id, double salary, string course)
        : base(name, email, id, salary)
    {
        Console.WriteLine("Teacher constructor");
        CourseName = course;
    }

    public void Teach()
    {
        Console.WriteLine("Teacher teaches " + CourseName);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Ali", "ali@gmail.com", 123, 3.5);

        Console.WriteLine();

        Teacher t = new Teacher("ahmed", "ahmed@gmail.com", 555, 5000, "C#");

        Console.WriteLine();

        s.DisplayBasicInfo();
        t.DisplayBasicInfo();
        t.Teach();
    }
}
