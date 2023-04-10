using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:
            int sayac = 0;
            int sayac2 = 0;


            Console.Write("Bir Sayi Giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("\nGirilen Sayi Asaldır.");

                        for (int i = 2; i < sayi; i++)
                        {
                            Random Rastgele = new Random();
                            int sayi2 = Rastgele.Next(sayi, 100);

                            if (sayi2 % i == 0)
                            {
                                sayac2++;
                            }
                        }
                if (sayac2 == 0)
                        {
                            Console.WriteLine(sayi);
                        }
                    }
                
               else
                {
                    Console.WriteLine("\nGirilen Sayi Asal Değildir.");
                }

            Console.ReadKey();
            Console.Clear();
            goto tekrar;
        }
    }
}
