using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public int CompareTo(Student other)
    {
        int marksCompare = other.Marks.CompareTo(this.Marks); 
        if (marksCompare != 0)
            return marksCompare;

        return this.Age.CompareTo(other.Age); 
        return 1;
    }
}



class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sandeep", Age = 21, Marks = 85 },
            new Student { Name = "Raman", Age = 19, Marks = 92 },
            new Student { Name = "Satyam", Age = 20, Marks = 92 },
            new Student { Name = "Akshat", Age = 22, Marks = 85 }
        };

        var sortedStudents = students.OrderByDescending(s => s.Marks).ThenBy(s => s.Age).ToList();

        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name+" "+s.Marks+" "+s.Age);
        }
        Console.WriteLine();
        
        List<Student> student1 = new List<Student>
        {
            new Student { Name = "Sandeep", Age = 21, Marks = 85 },
            new Student { Name = "Raman", Age = 19, Marks = 92 },
            new Student { Name = "Satyam", Age = 20, Marks = 92 },
            new Student { Name = "Akshat", Age = 22, Marks = 85 }
        };
        student1.Sort();

        foreach (var s in student1)
        {
            Console.WriteLine(s.Name+" "+s.Marks+" "+s.Age);
        }
    }
}
