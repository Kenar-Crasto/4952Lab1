using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChineseZodiacsLAB1.Models
{
    public class Utils
    {
        public static string GetZodiac(int year) {
    string[] zodiac = new string[12];
    zodiac[0] = "monkey";
    zodiac[1] = "rooster";
    zodiac[2] = "dog";
    zodiac[3] = "pig";
    zodiac[4] = "rat";
    zodiac[5] = "ox";
    zodiac[6] = "tiger";
    zodiac[7] = "rabbit";
    zodiac[8] = "dragon";
    zodiac[9] = "snake";
    zodiac[10] = "horse";
    zodiac[11] = "goat";

    int remainder = year % 12;
    return zodiac[remainder];
}



    }
}