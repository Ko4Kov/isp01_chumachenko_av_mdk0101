using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class Banknote
    {
        public int SerieesAndNumber { get; set; } // серия и номер
        public int Rating { get; set; } // номинал
        public string RatingOfString { get; set; } // номинал прописью
        public override string ToString()
        {
            return ($"Купюра: {SerieesAndNumber} {Rating} {RatingOfString}");
        }
        public Banknote(int seriesAndNumber, int rating, string ratingOfString)
        {
            SerieesAndNumber = seriesAndNumber;
            Rating = rating;
            RatingOfString = ratingOfString;
        }
    }
}
