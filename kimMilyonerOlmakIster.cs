using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Milyoner_yarisma
{
    class Program
    {
        static void Main(string[] args)
        {
                        
                        // Zamanında lisede yaptığım çok verimsiz ve kompleks bir bilgi yarışması  

            ArrayList sayilar = new ArrayList();
            Random rastgele = new Random();
            ArrayList c = new ArrayList();
            String[] dcvp = new String[50];
            char[] dsecenek = new char[50];
            bool jr1 = false, jr2 = false, jr3 = false, jr4 = false;
            bool sss = false;
            bool geri = false;
            int dogruc = 0;
            int yanlisc = 0;
            string jrcevap;
            string bl;
            int h = 1;
            int j = 1;
            char cevap = 'z';
            int f = 1;
            string cdeger;
            int zaman = 2000;
            int toplamp = 0;
            int barajp = 0;
            int uzn;


            // SORULAR

            c.Add("Hangisi metrekare ölçüsü ile \nsatın alınır ?");        // Soru [0]. Index'e atandı.
            c.Add("Doğalgaz"); c.Add("Perde"); c.Add("Kömür"); c.Add("İplik");     //Cevaplar 1-4 Indexlerinde.
            dsecenek[1] = 'B'; dsecenek[2] = 'b'; dcvp[1] = "Perde";    // Doğru Cevap 'dcvp' Listesine Eklendi.

            c.Add("''Dal Sarkar Kartal Kalkar'' Şeklinde \nBiten Tekerlemenin Başı Nasıldır ?");  // [5]
            c.Add("Kartal uçar dal sarkar"); c.Add("Kartal kalkar dal düşer"); c.Add("Kartal kalkar dal salkar"); c.Add("Kartal uçar dal düşer");  //6-9
            dsecenek[3] = 'C'; dsecenek[4] = 'c'; dcvp[2] = "Kartal kalkar dal salkar";

            c.Add("Patates Cipsi Paketleri, içinde cipslerin \ntaze kalması için hangi gazla doldurulur ?");  // [10]
            c.Add("Oksijen"); c.Add("Hidrojen"); c.Add("Helyum"); c.Add("Azot");   //11-14
            dsecenek[5] = 'D'; dsecenek[6] = 'd'; dcvp[3] = "Azot";

            c.Add("'Büyük Lokma Ye'şeklinde başlayan \natasözü nasıl devam eder ?");
            c.Add("Yudum yudum iç"); c.Add("Büyük söz söyleme"); c.Add("Az ve öz konuş"); c.Add("Çiğnemeden yutma");
            dsecenek[7] = 'B'; dsecenek[8] = 'b'; dcvp[4] = "Büyük söz söyleme";

            c.Add("Bir çiftçi, tarlayı sürüp hiçbir şey ekmeden \n bıraktıysa hangisini yapmış demektir ?");
            c.Add("İmece"); c.Add("Nadas"); c.Add("Çeltik"); c.Add("Hasat");
            dsecenek[9] = 'B'; dsecenek[10] = 'b'; dcvp[5] = "Nadas";

            c.Add("Düdük futbol maçlarında kullanılmadan önce \nHakemler hangisini kullanırlardı ?");
            c.Add("Beyaz Mendil"); c.Add("Şapka"); c.Add("Gong"); c.Add("Çan");
            dsecenek[11] = 'A'; dsecenek[12] = 'a'; dcvp[6] = "Beyaz Mendil";

            c.Add("'Sarı Sayfalar' olarak adlandırılan \ngazete bölümünde hangisi bulunur ?");
            c.Add("Magazin Haberleri"); c.Add("Seri İlanlar"); c.Add("Spor Haberleri "); c.Add("Televizyon Rehberi");
            dsecenek[13] = 'B'; dsecenek[14] = 'b'; dcvp[7] = "Seri İlanlar";

            c.Add("Hababam Sınıfı filmlerindeki Mahmut Hoca ne öğretmenidir ?");
            c.Add("Tarih"); c.Add("Matematik"); c.Add("Edebiyat"); c.Add("Coğrafya");
            dsecenek[15] = 'A'; dsecenek[16] = 'a'; dcvp[8] = "Tarih";

            c.Add("Üç ülkeyle sınırı olan ilimiz hangisidir ?");
            c.Add("Edirne"); c.Add("Artvin"); c.Add("Hakkari"); c.Add("Iğdır");
            dsecenek[17] = 'D'; dsecenek[18] = 'd'; dcvp[9] = "Iğdır";

            c.Add("Günümüzde popüler bir söz olan \"şehir efsanesi\" için eski kuşakların kullandığı kelime hangisidir?");
            c.Add("Teamül"); c.Add("Tahayyül"); c.Add("Tevatür"); c.Add("Tezahür");
            dsecenek[19] = 'C'; dsecenek[20] = 'c'; dcvp[10] = "Tevatür";

            c.Add("\"Meracılık\" yaptığını söyleyen birinin işi hangisiyle ilgilidir ?");
            c.Add("Çiftçilik"); c.Add("Hayvancılık"); c.Add("Madencilik"); c.Add("Ormancılık");
            dsecenek[21] = 'B'; dsecenek[22] = 'b'; dcvp[11] = "Hayvancılık";

            c.Add("Osmanlı İmparatorluğunun'nun son dört padişahının babası kimdir ?");
            c.Add("V.Murad"); c.Add("II.Mahmud"); c.Add("Abdülmecid"); c.Add("Abdülaziz");
            dsecenek[23] = 'C'; dsecenek[24] = 'c'; dcvp[12] = "Abdülmecid";

            c.Add("\"Hippopotomonstrosesquippedaliophobia\" \nkorkusundan muzdarip biri hangisinden korkar ?");
            c.Add("Su aygırlarından"); c.Add("Karışık Kelimelerden"); c.Add("Uzun Kelimelerden"); c.Add("Hatalı Hecelemekten");
            dsecenek[25] = 'C'; dsecenek[26] = 'c'; dcvp[13] = "Uzun Kelimelerden";

            
            baslangic:

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Clear();
            Console.WriteLine("\n                               KİM 500 BİN İSTER ? \n"); Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n                             - NASIL OYNANIR ? (HELP) -");
            Console.WriteLine("\n                                    - BAŞLA - ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bir Seçenek Giriniz: ");
            bl = Console.ReadLine();

            uzn = c.Count / 5;

            int s = 0;

            if (bl == "Kurallar" || bl == "kurallar" || bl == "kural" || bl == "Kural" ||bl == "HELP" || bl == "Help" || bl == "help" )
            {
                Console.Clear();
                Console.WriteLine("        - KURALLAR - \n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Soru havuzu toplamda 12 sorudan oluşmaktadır *\n");
                Console.WriteLine("* Bu sorulardan 2 tanesi baraj sorusudur * \n");
                Console.WriteLine("* İlk baraj 2.soruda, diğer baraj ise 7.soruda karşımıza çıkıyor * \n");
                Console.WriteLine("* Joker kullanmak için '+' cevabını giriniz  * \n");
                Console.WriteLine("* 'Soru Değiştirme' Jokeri barajlarda ve 7.sorudan sonra kullanılamaz ! * \n");
                Console.WriteLine("* Geri çekilme durumunda en son cevaplanan sorunun ödülü verilecektir * \n");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Menüye dönmek için bir tuşa basınız . . .");
                Console.ReadKey();
                goto baslangic;
            }
            else if (bl == "Başla" || bl == "başla" || bl == "Basla" || bl == "basla")
            {
                Console.WriteLine("\nBol şans. . .");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                for (int m = 1; m < uzn + 1; m++)
                {
                    bool mtn = false;
                    bool aa = false, bb = false, cc = false, dd = false;
                    bool dogruA = false, dogruB = false, dogruC = false, dogruD = false;
                    bool yanlisA = false, yanlisB = false, yanlisC = false, yanlisD = false;
                    bool sorgu = false;
                    bool durum2 = false;
                    geri = false;
                    bool durum = false;
                    int i = 0;
                    int v = 0;
                    int x = 5;
                    int hata = 0;

                renk:
                    // SORU
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("         SORU: {0}\n", m); Console.ResetColor();
                    if (mtn == false && sss == false) System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(c[s] + "\n"); if (mtn == false) System.Threading.Thread.Sleep(1000);// Değer 'false' ise Şıkları 1 saniye Aralıklarla Yazacak.

                    //ŞIKLAR
                    if (aa == true) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (dogruA == true) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (yanlisA == true) { Console.ForegroundColor = ConsoleColor.DarkGray; }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("A-) " + c[s + 1]); if (mtn == false && sss == false) System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;

                    
                    if (bb == true) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (dogruB == true) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (yanlisB == true) { Console.ForegroundColor = ConsoleColor.DarkGray; }

                    Console.WriteLine("B-) " + c[s + 2]); if (mtn == false && sss == false) System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;


                    if (cc == true) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (dogruC == true) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (yanlisC == true) { Console.ForegroundColor = ConsoleColor.DarkGray; }

                    Console.WriteLine("C-) " + c[s + 3]); if (mtn == false && sss == false) System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;


                    if (dd == true) { Console.ForegroundColor = ConsoleColor.Red; }
                    if (dogruD == true) { Console.ForegroundColor = ConsoleColor.Green; }
                    if (yanlisD == true) { Console.ForegroundColor = ConsoleColor.DarkGray; }

                    Console.WriteLine("D-) " + c[s + 4]); if (mtn == false && sss == false) System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;


                    if (dogruA == true) goto bitis;
                    if (dogruB == true) goto bitis;
                    if (dogruC == true) goto bitis;
                    if (dogruD == true) goto bitis;




                    try
                    {
                        if (mtn == false)
                        {
                            Console.Write("\nSon Kararınız Nedir: ");
                            cevap = Convert.ToChar(Console.ReadLine());

                            if (cevap == '+' || cevap == 'J' || cevap == 'j')
                            {
                                Console.WriteLine("\n                 - JOKERLER -\n");

                                if (jr1 == true) Console.ForegroundColor = ConsoleColor.Red;

                                Console.Write("\n 1) Soruyu Değiştir");
                                Console.ForegroundColor = ConsoleColor.White;

                                if (jr2 == true) Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("              0) İPTAL ET        -1)Yarışmadan Çekil");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.Write("\nBir Joker Seçiniz(1-0): ");
                                jrcevap = Console.ReadLine();

                                if (jrcevap == "1")
                                {
                                    if (jr1 == true)
                                    {
                                        Console.WriteLine("\nBu Joker Hakkınızı Kullandınız !");
                                        System.Threading.Thread.Sleep(1500);
                                        Console.Clear();
                                        sss = true;
                                        goto renk;
                                    }
                                    if (m < 7 && m != 2)
                                    {
                                        Console.WriteLine("\nSoru Değiştiriliyor. . .");
                                        System.Threading.Thread.Sleep(1000);
                                        jr1 = true;
                                        sss = false;
                                        durum2 = true;
                                        goto sorudegistir;
                                    }
                                }

                                else if (jrcevap == "0")
                                {
                                    Console.WriteLine("\nİptal Ediliyor. . .");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    sss = true;
                                    goto renk;
                                }
                                else if (jrcevap == "-1")
                                {
                                    System.Threading.Thread.Sleep(1000);
                                    geri = true;
                                    goto bitti;
                                }
                                else
                                {
                                    Console.WriteLine("\nLütfen Geçerli Bir Seçenek Giriniz !");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    sss = true;
                                    goto renk;
                                }
                            }
                        }
                    }
                    catch
                    {
                        while (x > 0)
                        {
                            x--;
                            hata++;
                            Console.Write("\nBir Hata Oluştu ! ");
                            Console.WriteLine("Kalan Hak: " + x);
                            System.Threading.Thread.Sleep(2000);

                            if (hata == 5)
                            {
                                Console.WriteLine("\nHata Hakkınızı Doldurdunuz.");
                                System.Threading.Thread.Sleep(1250);
                                Console.WriteLine("\nUygulama Kapatılıyor...");
                                System.Threading.Thread.Sleep(2000);
                                Environment.Exit(0);
                            }
                            Console.Clear();
                            sss = true;
                            goto renk;
                        }

                    }

                yanliss:
                    if (i < 1 || sorgu == true)
                    {
                        if (cevap == 'A' || cevap == 'a')
                        {
                            i++;
                            aa = true;
                            Console.Clear();
                            mtn = true;
                            sorgu = false; if (durum == true) { yanlisA = true; aa = false; }
                            goto renk;
                        }
                        else if (cevap == 'B' || cevap == 'b')
                        {
                            i++;
                            bb = true;
                            mtn = true;
                            Console.Clear();
                            sorgu = false; if (durum == true) { yanlisB = true; bb = false; }
                            goto renk;
                        }
                        else if (cevap == 'C' || cevap == 'c')
                        {
                            i++;
                            cc = true;
                            mtn = true;
                            Console.Clear();
                            sorgu = false; if (durum == true) { yanlisC = true; cc = false; }
                            goto renk;
                        }
                        else if (cevap == 'D' || cevap == 'd')
                        {
                            i++;
                            mtn = true;
                            dd = true;
                            Console.Clear();
                            sorgu = false; if (durum == true) { yanlisD = true; dd = false; }
                            goto renk;
                        }
                        else
                        {
                            i++;
                            mtn = false;
                            sorgu = true;
                            sss = true;
                            Console.WriteLine("\nLütfen Geçerli Bir Seçenek Giriniz !");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            goto renk;
                        }
                    }



                    System.Threading.Thread.Sleep(zaman);

                    while (v < 1)
                    {
                        if (dsecenek[h] == cevap || dsecenek[h + 1] == cevap)
                        {
                            if (aa == true)
                            {
                                v++;
                                aa = false;
                                dogruA = true;
                                Console.Clear();
                                goto renk;
                            }
                            if (bb == true)
                            {
                                v++;
                                bb = false;
                                dogruB = true;
                                Console.Clear();
                                goto renk;
                            }
                            if (cc == true)
                            {
                                v++;
                                cc = false;
                                dogruC = true;
                                Console.Clear();
                                goto renk;
                            }
                            if (dd == true)
                            {
                                v++;
                                dd = false;
                                dogruD = true;
                                Console.Clear();
                                goto renk;
                            }
                        }
                        else
                        {

                            Console.Clear();
                            durum = true;
                            sorgu = true;
                            if (dsecenek[h] == 'A' || dsecenek[h] == 'a') { dogruA = true; goto yanliss; }
                            if (dsecenek[h] == 'B' || dsecenek[h] == 'b') { dogruB = true; goto yanliss; }
                            if (dsecenek[h] == 'C' || dsecenek[h] == 'c') { dogruC = true; goto yanliss; }
                            if (dsecenek[h] == 'D' || dsecenek[h] == 'd') { dogruD = true; goto yanliss; }
                        }
                    }




                bitis:
                    if (m == j)
                    {
                        Console.Write("\n. "); System.Threading.Thread.Sleep(500);
                        Console.Write(". "); System.Threading.Thread.Sleep(500);
                        Console.Write(". ");

                        if (cevap == dsecenek[h] || cevap == dsecenek[h + 1])
                        {
                            if (m == 1) { toplamp = 500; }
                            if (m == 2) { toplamp = 1000; barajp = 1000; }
                            if (m == 3) { toplamp = 2000; }
                            if (m == 4) { toplamp = 3000; }
                            if (m == 5) { toplamp = 5000; }
                            if (m == 6) { toplamp = 7500; }
                            if (m == 7) { toplamp = 15000; barajp = 15000; }
                            if (m == 8) { toplamp = 30000; }
                            if (m == 9) { toplamp = 60000; }
                            if (m == 10) { toplamp = 125000; }
                            if (m == 11) { toplamp = 250000; }
                            if (m == 12) { toplamp = 1000000; barajp = 1000000; }

                            Console.WriteLine("\nTebrikler. Doğru Cevabı Bildiniz.", dogruc++);
                            if (m != 12) { Console.Write("\nTOPLAM ÖDÜL: "); Console.ForegroundColor = ConsoleColor.Green; }
                            Console.WriteLine(toplamp); Console.ForegroundColor = ConsoleColor.White;
                            System.Threading.Thread.Sleep(2000);
                            if (m != 12) { Console.WriteLine("\nSonraki Soru İçin Bir Tuşa Basınız. . ."); }

                        }
                        else
                        {
                            yanlisc++;
                            Console.Write("\nCevabınız Yanlış. Doğru Cevap - "); Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0}", dcvp[f]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" - Olacaktı.", dcvp[f]);

                            System.Threading.Thread.Sleep(2000);
                            goto bitti;
                        }
                    }
                    sss = false;


                sorudegistir:

                    if (durum2 == true) goto sorugec;


                    System.Threading.Thread.Sleep(500);
                    Console.ReadKey();

                sorugec:

                    j++;
                    s = s + 5;
                    h = h + 2;
                    f++;
                    zaman = zaman + 1050;


                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\nLütfen Geçerli Bir Seçenek Giriniz !");
                System.Threading.Thread.Sleep(700);
                goto baslangic;
            }
        bitti:
            Console.Clear();
            Console.WriteLine();
            Console.Write("\n               Yarışmamız Bitmiştir."); System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\n  Toplamda; \n");
            System.Threading.Thread.Sleep(2000);
            Console.Write(" Doğru Sayınız: "); System.Threading.Thread.Sleep(1500);
            Console.Write(dogruc + "\n"); System.Threading.Thread.Sleep(1500);
            Console.Write("\n Yanlış Sayınız: "); System.Threading.Thread.Sleep(1500);
            Console.Write(yanlisc + "\n"); System.Threading.Thread.Sleep(1500);

            Console.WriteLine();
            Console.Write("\nTOPLAM ÖDÜL: "); Console.ForegroundColor = ConsoleColor.Green;

            if (geri == true) { Console.WriteLine(toplamp); Console.ForegroundColor = ConsoleColor.White; }
            else { Console.WriteLine(barajp); Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine("\n       Çıkmak Için Bir Tuşa Basınız. . .");

            Console.ReadKey();
        }
    }
}