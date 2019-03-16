using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726031_C0727100
{

    public delegate void Sort_DataStructure();

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Run();
        }
    }

    class Student
    {
        List<string> StudentList = new List<string>();
        String Student_name;
        String StudentID;
        double StudentGPA;

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }
}