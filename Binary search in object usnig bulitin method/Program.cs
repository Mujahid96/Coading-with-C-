using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var studentList = new List<Student>();
        studentList.Add(new Student { StudentId = 181400096, StudentName = "Tahmid", Grade = 3.94 });
        studentList.Add(new Student { StudentId = 181400095, StudentName = "Ahsan", Grade = 3.24 });
        studentList.Add(new Student { StudentId = 181400054, StudentName = "Akash", Grade = 3.80 });
        studentList.Add(new Student { StudentId = 181400087, StudentName = "Rahim", Grade = 3.11 });


        var comparer = new StudentSearchComparer();
        studentList.Sort(comparer);
        Console.WriteLine("Sorted Array");
        foreach (var st in studentList)
        {
            Console.WriteLine("Student Name :: {0} Id :: {1} Grade :: {2}", st.StudentName, st.StudentId, st.Grade);
        }

        var searchingStudent = studentList.FirstOrDefault(f => f.StudentId == 181400095);
        int searchedStudentPosition = studentList.BinarySearch(searchingStudent, comparer);
        Console.WriteLine("Stundet {0} is at position number: {1}", searchingStudent.StudentName, searchedStudentPosition);
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public double Grade { get; set; }
}

public class StudentSearchComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        if (x.StudentId == y.StudentId && x.StudentName == y.StudentName && x.Grade == y.Grade)
        {
            return 0;
        }
        if (x.StudentId > y.StudentId)
        {
            return 1;
        }
        else if (x.StudentId < y.StudentId)
        {
            return -1;
        }
        else return 0;


    }
}