using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOSGELDİNİZ!\n");
            Console.WriteLine("Sifrenizi Giriniz\t:");
            string sifre;
            sifre = Console.ReadLine();

            Console.WriteLine("Hangi İslemi Yapmak Istiyorsunuz!\n");
            Console.WriteLine("1-Para Çekmek\n2-Karta Para Yuklemek\n3-Havale\n4-Fatura Ödeme\n");
            int islem;
            islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("Para Cekiliyor!"); 
                    break;
               
                case 2:
                    Console.WriteLine("Para Yükleniyor!");
                    break;
                case 3:
                    Console.WriteLine("Para Havale ediliyor!");
                    break;
                case 4:
                    Console.WriteLine("Fatura Ödeniyor!");
                    break;

                default:
                    Console.WriteLine("Yanlış işlem seçtiniz!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
