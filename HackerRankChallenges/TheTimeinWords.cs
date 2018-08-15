using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankChallenges
{
    public class TheTimeinWords
    {
        private static readonly Dictionary<int, string> NumbersToString = new Dictionary<int, string>()
        {
            {1 , "one"},
            {2 , "two"},
            {3 , "three"},
            {4 , "four"},
            {5 , "five"},
            {6 , "six"},
            {7 , "seven"},
            {8 , "eight"},
            {9 , "nine"},
            {10 , "ten"},
            {11 , "eleven"},
            {12 , "twelve"},
            {13 , "thirteen"},
            {14 , "fourteen"},
            {15 , "fifteen"},
            {16 , "sixteen"},
            {17 , "seventeen"},
            {18 , "eighteen"},
            {19, "nineteen"}
        };


     
        static string TimeInWords(int h, int m)
        {

            string placeHolderText = string.Empty;

            if (m <= 30)
            {
                placeHolderText = "past";
            }
            else
            {
                h = h + 1;
                m = 60 - m;
                placeHolderText = "to";
            }

            if (m == 00)
            {
                return $"{NumbersToString[h]} o' clock";
            }
            else if (m == 30)
            {
                return $"half past {NumbersToString[h]}";
            }
            else if (m == 15)
            {
                return $"quarter {placeHolderText} {NumbersToString[h]}";
            }
            else if (m == 01)
            {
                return $"one minute {placeHolderText} {NumbersToString[h]}";
            }
            else if (m <= 20)
            {
                return $"{NumbersToString[m]} minutes {placeHolderText} {NumbersToString[h]}";
            }
            else
            {
                string lastMinute = m.ToString();
                return $"twenty {NumbersToString[Convert.ToInt32(lastMinute.Substring(1))]} minutes {placeHolderText} {NumbersToString[h]}";
            }

        }

    }
}
