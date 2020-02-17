using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Adres
    {
        public int Index { get; set; }
        public string City { get; set; }
        public string Square { get; set; }
        public int NumberOfHouse { get; set; }
        public int Flat { get; set; }
        public override string ToString()
        {
            return ($"Адрес:  {Index} {City} {Square} {NumberOfHouse} {Flat}");
        }
        public Adres(int index, string city, string square, int numberOfHouse, int flat) 
        { 
            Index = index;
            City = city;
            Square = square;
            NumberOfHouse = numberOfHouse;
            Flat = flat;
        }
    }
}
