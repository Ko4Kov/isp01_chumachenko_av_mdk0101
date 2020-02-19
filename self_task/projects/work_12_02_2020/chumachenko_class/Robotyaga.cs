using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Robotyaga //служащий
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkExperience { get; set; } //рабочий стаж
        public override string ToString()
        {
            return ($"Роботяга: {Name} {Profession} {WorkExperience}");
        }
        public Robotyaga(string name, string profession, int workExperience)
        {
            Name = name;
            Profession = profession;
            WorkExperience = workExperience;
        }
    }
}
