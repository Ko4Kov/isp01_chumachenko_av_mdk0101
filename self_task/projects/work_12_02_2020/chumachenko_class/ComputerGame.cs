using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class ComputerGame
    {
        public string Name { get; set; }
        public string DevelopersTeamName { get; set; } // фирма разработчик
        public int YearName { get; set; }
        public string JanreName { get; set; }
        public override string ToString()
        {
            return ($"Компьютерная игра:  {Name} {DevelopersTeamName} {YearName} {JanreName}");
        }
        public ComputerGame(string name, string developersTeamName, int yearName, string janreName)
        {
            Name = name;
            DevelopersTeamName = developersTeamName;
            YearName = yearName;
            JanreName = janreName;
        }
    }
}
