using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDaysMivdak
{
    public class HebrewDateModel
    {
        public string Day { get; set; }
        public int DayMonth { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Result { get; set; }

        public HebrewDateModel(string day, int dayMonth, string month, string year, string result)
        {
            Day = day;
            DayMonth = dayMonth;
            Month = month;
            Year = year;
            Result = result;
        }
    }
}
