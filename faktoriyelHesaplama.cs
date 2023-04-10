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
            tekrar:
            int rakam;
            int rakam2;
            decimal sonuc = 1;
            int a = 0;

            Console.Write("Bir Sayı Giriniz: ");
            rakam = Convert.ToInt16(Console.ReadLine());

            rakam2= rakam + a;
            while (rakam > 1)
            {
                sonuc *= rakam;
                rakam--;
            }
            Console.WriteLine("\n**********");
            Console.WriteLine("{0} Sayısının Faktöriyeli: {1}\n",rakam2, sonuc );


            Console.ReadKey();
            Console.Clear();
            goto tekrar;
        }
    }
}
