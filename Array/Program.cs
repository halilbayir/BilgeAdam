using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  array ile ogrenci sayisina göre öğrencileri girme
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();

            Console.Write("Sınıf Mevcudu :");
            int mevcut = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[mevcut];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine("{0}. Ogrencinin ismi :", i);
                ogrenciler[i] = Console.ReadLine();
            }
            Console.WriteLine("Ogrenciler :\t\n");
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            #endregion

            #region -100 100 arasında random sayılardan negatif pozitif ve sıfırları bulma
            //Random random = new Random();
            //int pozitif = 0, negatif = 0, sifir = 0;

            //Console.WriteLine("Kac tane?");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];

            //Console.Clear();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-100, 101);
            //}

            //foreach (var sayi in numbers)
            //{
            //    Console.WriteLine(sayi);

            //    if (sayi > 0)
            //    {
            //        pozitif++;
            //    }
            //    else if (sayi < 0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} tane pozitif var", pozitif);
            //Console.WriteLine("{0} tane negetaif var", negatif);
            //Console.WriteLine("{0} tane sıfır var", sifir);
            //Console.Read();


            #endregion

            #region sayı seçicek o sayıya karşılık gelen günü vercek ve sürekli sorabilcek

            //string[] gunler = new string[] { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //foreach (var item in gunler)
            //{
            //    Console.WriteLine(gunler);
            //}

            //Console.WriteLine("Hangi Günü seçiyorsunuz");
            //int n = Convert.ToInt32(Console.ReadLine());

            //string[] gunler = new string[] { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //bool devam = true;
            //while (devam)
            //{
            //    Console.WriteLine("Kaçıncı gün:");
            //    byte gun = Convert.ToByte(Console.ReadLine());

            //    if (gun <= 7 && gun >= 1)
            //    {
            //        Console.WriteLine(gunler[gun - 1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}. gün yok ama bir isim bul ekleyim :", gun);
            //    }
            //    Console.WriteLine("\n Devam etmek istiyorsan \"e\" tuşuna bas");
            //    char c = Convert.ToChar(Console.ReadLine());
            //    if (c == 'e')
            //    {
            //        devam = true;
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}

            #endregion

            #region 2boyutlu arrayler

            //int[,] sinavlar = new int[2, 3];
            //sinavlar[0, 0] = 1;
            //sinavlar[0, 1] = 2;
            //sinavlar[0, 2] = 3;
            //sinavlar[1, 0] = 10;
            //sinavlar[1, 1] = 20;
            //sinavlar[1, 2] = 30;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sinavlar[0, i] + "  -  " + sinavlar[1, i]);
            //}

            #endregion
        }
    }
}
