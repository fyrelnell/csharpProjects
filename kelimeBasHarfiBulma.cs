using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        // Girilen metinin içinde istenilen baş harfe göre kaç kelime olduğunu bulan program

        static void Main(string[] args)
        {
            string cumle;
            char h;
            int sayac1 = 0;
            int sayac2 = 0;
            

            Console.Write("Bir Cümle Giriniz:  ");
            cumle = Console.ReadLine();

            Console.Write("\nHangi harfi aramak istiyorsunuz: ");
            h = Convert.ToChar(Console.ReadLine());

            char[] bharf = new char[cumle.Length];
            bharf[0] = cumle[0];

            for (int k = 0; k < cumle.Length; k++)
            {
                if (cumle[k] == ' ')
                {
                    bharf[sayac1 + 1] = cumle[k + 1];
                    sayac1++;
                }
            }
            for (int y = 0; y <= sayac1; y++)
            {
                if (bharf[y] == char.ToUpper(h) || bharf[y] == char.ToLower(h))
                    sayac2++;
            }

            Console.WriteLine("\n  Baş harfi {0} ile başlayan {1} adet kelime var.", char.ToUpper(h), sayac2);


            Console.ReadKey();
        }
    }
}
