using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Group
    {
        public string Shifre { get; set; } // шифр специальности
        public int NumberOfStudents { get; set; } // кол-во студентов
        public int YearOfFormation { get; set; } // год формирования
        public string Speciality { get; set; } // специальность
        public override string ToString()
        {
            return ($"Группа: {Shifre} {NumberOfStudents} {YearOfFormation} {Speciality}");
        }
        public Group(string shifre, int numberOfStudents, int yearOfFormation, string speciality)
        {
            Shifre = shifre;
            NumberOfStudents = numberOfStudents;
            YearOfFormation = yearOfFormation;
            Speciality = speciality;
        }
    }
}
