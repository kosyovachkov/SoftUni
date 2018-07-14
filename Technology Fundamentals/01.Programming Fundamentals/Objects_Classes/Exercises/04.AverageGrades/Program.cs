using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{

    class Student
    {
        public string Name { get; set; }
        public double[] Grade { get; set; }
        public double AverageGrade { get; set; }

        public static Student ReadStudent(string[] input)
        {
            Student student = new Student();
            student.Name = input[0];
            student.Grade = input.Skip(1).Select(double.Parse).ToArray();
            student.AverageGrade = student.Grade.Average();
            return student;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> studentList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                studentList.Add(Student.ReadStudent(input));
            }

            foreach (var item in studentList.Where(x => x.AverageGrade>=5.00).OrderBy(x => x.Name).ThenBy(x =>-x.AverageGrade))
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade:f2}");
            }

            


        }
    }

   
}
