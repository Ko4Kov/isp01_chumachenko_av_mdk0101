using chumaxhenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedkov_chumaxhenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec01 = new Vector(45, 56, 100);
            Vector vec02 = new Vector(32, 67, 23);
            Console.WriteLine($"Вектор1: {vec01.ToString()}");
            Console.WriteLine($"Вектор2: {vec02.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Длина 1 вектора: {vec01.Length()}.");
            Console.WriteLine($"Длина 2 вектора: {vec02.Length()}.");
            Console.WriteLine();
            Console.WriteLine($"Скалярное произведение: {vec01.SkalComposotion(vec01)}.");
            Console.WriteLine($"Векторное произведение: {vec01.Composotion(vec02)}.");
            Console.ReadKey();
        }
    }
}
