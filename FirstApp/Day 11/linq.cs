using System;
using System.Linq;
class linq
{
    public static void func1()
    {
        int[] number = {1,2,3,4,5,6,7,8};
        var evenNumbers = number.Where(n => n%2==0);
        var oddNumbers = number.Where(n=> n%2!=0);
        Console.WriteLine(evenNumbers);
        foreach(var i in evenNumbers)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        foreach(var i in oddNumbers)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();

        var result = number.Where(n=> n>3).Select(n=> n*3);
        foreach(var i in result)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
    public static void func2()
    {
        List<Student2> student = new List<Student2>()
        {
            new Student2 { Name = "Satyam", Marks = 70 },
            new Student2 { Name = "Sandeep", Marks = 50 }
        };

        
        var result3 = student.Select(s=> new
        {
            s.Name,s.Marks,
            Result=s.Marks>60 ? "Pass" : "Fail"
        });
        var result4 = student.Select(s=> new
        {
            s.Name,s.Marks,
            Result=s.Marks>60 ? "Pass" : "Fail"
        }).ToList();
        

        foreach(var i in result3)
        {
            Console.WriteLine(i+" ");
        }
        Console.WriteLine();
        Console.WriteLine(result3.GetType());
        Console.WriteLine(result4.GetType());
    }
    public static void func3()
    {
        List<int> numbers = new List<int>{5,2,8,1,3};
        var asc = numbers.OrderBy(n=> n);
        var desc = numbers.OrderByDescending(n=> n);

        foreach(var i in asc)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        foreach(var i in desc)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();

        List<Student2> ls = new List<Student2>()
        {
            new Student2 {Name="Satyam",Result="Pass",Marks=100},
            new Student2 {Name="Sandeep",Result="Pass",Marks=80},
            new Student2 {Name="Raman",Result="Fail",Marks=60},
        };

        var sortedByMarks=ls.OrderBy(n=> n.Marks);

        foreach(var i in sortedByMarks)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
class Student2
{
    public string Name;
    public string Result ;
    public int Marks;

}