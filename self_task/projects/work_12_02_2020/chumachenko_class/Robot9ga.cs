using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Robot9ga //служащий
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkExperience { get; set; } //рабочий стаж
        public override string ToString()
        {
            return ($"Роботяга: {Name} {Profession} {WorkExperience}");
        }
        public Robot9ga(string name, string profession, int workExperience)
        {
            Name = name;
            Profession = profession;
            WorkExperience = workExperience;
        }
    }
}
