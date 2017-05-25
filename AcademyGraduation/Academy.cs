using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGraduation
{
    class Academy
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student currentStudent = new Student();
                string name = Console.ReadLine();
                currentStudent.Name = name;
                for (int j = 0; j < 1; j++)
                {
                    List<double> grades = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToList();
                    currentStudent.Grades = grades;
                    currentStudent.Grade = grades.Average();
                }
                students.Add(currentStudent);
            }
            foreach (var student in students.OrderBy(s=>s.Name))
            {
                Console.WriteLine($"{student.Name} is graduated with {student.Grade}");
            }

        }

        public class Student
        {
            public Student()
            {
                this.Grades = new List<double>();
            }
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double Grade { get; set; }
        }
    }
}
