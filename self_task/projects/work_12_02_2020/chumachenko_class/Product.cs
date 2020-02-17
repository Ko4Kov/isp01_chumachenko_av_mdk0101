using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Product
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public string ShelfLife{ get; set; } // срок годности
        public override string ToString()
        {
            return ($"Товар: {Name} {Number} {Price} {ShelfLife}");
        }
        public Product(string name, int number, double price, string shelfLife)
        {
            Name = name;
            Number = number;
            Price = price;
            ShelfLife = shelfLife;
        }
    }
}
