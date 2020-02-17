using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{

    class Program
    {
        static void Main(string[] args)
        {

            Adres adres01 = new Adres(404106, "Волжский,", "улица,", 228, 1);
            ComputerGame computerGame01 = new ComputerGame("Сапунка,", "Чумаченко А.В,", 2019, "Action RPG");
            Banknote banknote01 = new Banknote(1337227, 5000, "пять тысяч");
            Group group01 = new Group("09.02.07,", 17, 2018, "ИСП");
            Product product01 = new Product("Пиво,", 999, 30.99,"до 10.06.2019");
            za4et zachet01 = new za4et("Сапунов Роман Алишерович,", "Чумаченко Андрей Вячеславович,", "12.02.2020,", 2);
            Book book01 = new Book("12 стульев,", "Сапуненко Роман и Алишер Вражинович,", 227.99);
            WorkShop workShop01 = new WorkShop("ABC", 1488);
            Robot9ga worker01 = new Robot9ga("Сапунов Роман,", "Слесарь,", 3);
            Student student01 = new Student("Чумаченко Андрей Вячеславович,", 2, "Мужской");
            Console.WriteLine($"{adres01}\n{computerGame01}\n{banknote01}\n{group01}\n{product01}\n{zachet01}\n{book01}\n{workShop01}\n{worker01}\n{student01}");
            Console.ReadKey();
        }
        
    }
}
