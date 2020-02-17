using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        readonly public string Gender;
        public override string ToString()
        {
            return ($"Студент: {Name} {Course} {Gender}");
        }
        public Student(string name, int course, string gender)
        {
            Name = name;
            Course = course;
            Gender = gender; 
        }
    }
}
