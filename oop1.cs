using System;
using System.Collections.Generic;

class Person
{
    public string Name;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public int StudentId;

    public override void DisplayInfo()
    {
        Console.WriteLine("Student: " + Name + " ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary;

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee: " + Name + " Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName;

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher: " + Name + " Course: " + CourseName);
    }
}

class Program
{
    static void ShowPerson(Person p)
    {
        p.DisplayInfo();
    }

    static void Main()
    {
        List<Person> list = new List<Person>();

        list.Add(new Student { Name = "Ali", StudentId = 111 });
        list.Add(new Employee { Name = "Ahmed", Salary = 5000 });
        list.Add(new Teacher { Name = "omar", CourseName = "c#" });

        foreach (Person p in list)
        {
            Console.WriteLine(p.GetType().Name);
            p.DisplayInfo();
        }

        ShowPerson(list[0]);
    }
}
