using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
                // Girilen 10 sayıdan kaç tanesinin üç basamaklı olduğunu bulma

            int v1;
            int sayac = 0;


            for (int m = 0; m < 10; m++)
            {
                int i = 1;
                Console.Write("Bir Sayı Giriniz: ");
                v1 = Convert.ToInt32(Console.ReadLine());

                while (v1 > 9 || -9 > v1)
                {

                    v1 = v1 / 10;
                    i++;

                }
                if (i == 3)
                    sayac++;

            }

            Console.WriteLine("\n3 Basamaklı Sayıların Adedi:" + sayac);

                Console.ReadKey();
        }
    }
}
