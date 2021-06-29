using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public Student()
        {
            
        }

        public Student(int studentId, string name, string surname, int age)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, Name, Surname, Age);
        }
    }
}
