using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Book
    {
        public string Name { get; set; }
        public string Authors { get; set; } //список авторов
        public double Price { get; set; }
        public override string ToString()
        {
            return ($"Книга: {Name} {Authors} {Price}");
        }
        public Book(string name, string authors, double price)
        {
            Name = name;
            Authors = authors;
            Price = price;
        }
    }
}
