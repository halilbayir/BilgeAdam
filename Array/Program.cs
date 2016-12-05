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
            //int[] array = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;

            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.Read();

            //Console.Write("Sınıf Mevcudu :");
            //int mevcut = Convert.ToInt32(Console.ReadLine());

            //string[] ogrenciler = new string[mevcut];

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine("{0}. Ogrencinin ismi :",i);
            //    ogrenciler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Ogrenciler :\t\n");
            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
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

            //    if (sayi>0)
            //    {
            //        pozitif++;
            //    }
            //    else if (sayi<0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} tane pozitif var",pozitif);
            //Console.WriteLine("{0} tane negetaif var",negatif);
            //Console.WriteLine("{0} tane sıfır var", sifir);
            //Console.Read();


            #endregion

            #region birdiziye nasıl veri ekleriz

            //string[] gunler = new string[] { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //foreach (var item in gunler)
            //{
            //    Console.WriteLine(gunler);
            //}
            #endregion


            //ödevb

            #region sayı seçicek o sayıya karşılık gelen günü vercek ve sürekli sorabilcek
            Console.WriteLine("Hangi Günü seçiyorsunuz");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] gunler = new string[7];
            #endregion


        }
    }
}
