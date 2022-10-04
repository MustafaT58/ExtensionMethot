using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethot
{
    public static class Extensions
    {
        public static string IlkHarfbuyuk(this string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1);

        }
        public static string AyAdi(this DateTime date)
        {
            int ay = date.Month;
            string ayYaz=" ";
            switch (ay)
            {
                case 1:
                    ayYaz ="Ocak"; break;
                case 2:
                    ayYaz ="Şubat"; break;
                case 3:
                    ayYaz ="Mart"; break;
                case 4:
                    ayYaz ="Nisan"; break;
                case 5:
                    ayYaz ="Mayıs"; break;
                case 6:
                    ayYaz ="Haziran"; break;
                case 7:
                    ayYaz ="Temmuz"; break;
                case 8:
                    ayYaz ="Ağustos"; break;
                case 9:
                    ayYaz ="Eylül"; break;
                case 10:
                    ayYaz= "Ekim"; break;
                case 11:
                    ayYaz ="Kasım"; break;
                case 12:
                    ayYaz="Aralık"; break;
                default:
                    Console.WriteLine("Yanlış değer");
                    break;
            }
            return date.Day + " " + ayYaz + " " + date.Year;
        }
    }
}
