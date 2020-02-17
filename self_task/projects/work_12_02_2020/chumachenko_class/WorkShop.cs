using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class WorkShop //цех
    {
        public string StringCipher { get; set; } //строковый шифр
        public int NumberOfEmpliyees { get; set; } //кол-во служащих
        public override string ToString()
        {
            return ($" Рабочий цех:  {StringCipher} {NumberOfEmpliyees}");
        }
        public WorkShop(string stringCipher, int numberOfEmpliyees)
        {
            StringCipher = stringCipher;
            NumberOfEmpliyees = numberOfEmpliyees;
        }
    }
}
