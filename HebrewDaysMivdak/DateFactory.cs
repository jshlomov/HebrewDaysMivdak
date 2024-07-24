﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDaysMivdak
{
    public class DateFactory
    {

        public DateFactory() { }

        public Dictionary<string, string> CreateDaysDictionary()
        {
            return new Dictionary<string, string>()
            {
                { "ראשון", "אחד בשבת" },
                {"שני", "שני בשבת" },
                {"שלישי","שלישי בשבת" },
                {"רביעי","רביעי בשבת" },
                {"חמישי","חמישי בשבת" },
                {"שישי","שישי בשבת" }
            };
        }

        public Dictionary<int, string> CreateDaysInMonthDictionary()
        {
            return new Dictionary<int, string>()
            {
                {1 , "יום אחד" },
                {2 , "שני ימים" },
                {3 , "שלשה ימים" },
                {4 , "ארבעה ימים" },
                {5 , "חמישה ימים" },
                {6 , "ששה ימים" },
                {7 , "שבעה ימים" },
                {8 , "שמנה ימים" },
                {9 , "תשעה ימים" },
                {10 , "עשרה ימים" },
                {11 , "אחד עשר יום" },
                {12 , "שנים עשר" },
                {13 , "שלשה עשר יום" },
                {14 , "ארבעה עשר יום" },
                {15, "חמשה עשר יום" },
                {16 , "ששה עשר יום"},
                {17 , "שבעה עשר יום" },
                {18 , "שמנה עשר יום" },
                {19 , "תשעה עשר יום" },
                {20 , "עשרים יום" },
                {21 , "אחד ועשרים יום" },
                {22 , "שניים ועשרים יום" },
                {23 , "שלשה ועשרים יום" },
                {24 , "ארבעה ועשרים יום" },
                {25 , "חמישה ועשרים יום" },
                {26 , "ששה ועשרים יום" },
                {27 , "שבעה ועשרים יום" },
                {28 , "שמונה ושערים יום" },
                {29 , "תשעה ושערים יום" },
                {30 , "יום שלשים" },
            };
        }

        public Dictionary<string, string> CreateYearsDictionary()
        {
            return new Dictionary<string, string>()
            {
                {"תשפ\"ד", "שמנים וארבע" },
                {"תשפ\"ה", "שמנים וחמש" },
                {"תשפ\"ו", "שמנים ושש" },
                {"תשפ\"ז", "שמנים ושבע" },
                {"תשפ\"ח", "שמנים ושמנה" },
                {"תשפ\"ט", "שמנים ותשע" },
                {"תש\"צ", "תשעים" },
                {"תשצ\"א", "תשעים ואחת" },
                {"תשצ\"ב", "תשעים ושתים" },
                {"תשצ\"ג", "תשעים ושלוש" },
            };
        }


        public string[] CreateMonthsArray()
        {
            return new string[] {"תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון",
                   "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" };
        }




    }
}