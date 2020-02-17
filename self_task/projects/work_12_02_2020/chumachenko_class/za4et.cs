using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Chumachenko_Dedkov
{
    class za4et
    {
        public string StudentFio { get; set; }
        public string TeacherFio { get; set; }
        public string Date { get; set; }
        public int Rating { get; set; } //оценка
        public override string ToString()
        {
            return ($"Зачет: {StudentFio} {TeacherFio} {Date} {Rating}");
        }
        public za4et(string studentFio, string teacherFio, string date, int rating)
        {
            StudentFio = studentFio;
            TeacherFio = teacherFio;
            Date = date;
            Rating = rating;
        }
    }
}
