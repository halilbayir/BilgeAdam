using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basit liste ve elemanlarını yazdırma  
            //list<int> numbers = new list<int>();
            //numbers.add(1);
            //numbers.addrange(new int[] { 2, 3, 4 });

            //console.writeline(numbers.count);

            //foreach (var item in numbers)
            //{
            //    console.writeline(item);
            //}

            //console.writeline();

            //for (int i = 0; i < numbers.count; i++)
            //{
            //    console.writeline("{0} = {1}" ,i,numbers[i]);
            //}

            //int[] array = new int[2] { 3, 5 };
            //list<int> list = new list<int>(array);

            //console.writeline(list.count+" sayi yazdıracağım\n");

            //foreach (var item in list)
            //{
            //    console.writeline(item+"  ");
            //}


            //list<int> numbers = new list<int>(new int[] {1903,1904,1905 });
            //int index = numbers.ındexof(1904);
            ////indexof arrayin içindeki kaçıncı index elemanı olduğunu gösterir

            //list<string> isimler = new list<string>();
            //isimler.addrange(new string[] { "hb", "dt"," mct "});

            //foreach (var item in isimler)
            //{
            //    console.writeline(item);
            //}
            #endregion


            #region Liste içinde ekleme kaldırma komutları
            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            //numbers.RemoveAt(0); //0. indexi siler burda sadece index verirsin ve silmek istedigin indexi siler
            //numbers.Remove(5);//burda içine yazdığı ilk değeri bulur ve siler
            //numbers.RemoveRange(3, 2); //index aralığı siler

            //bool varmi = numbers.Contains(13); //numbers listinde 13 varmı yok mu kontrol ediyor

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  liste icinden deger silme
            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });
            //bool varmi = true;
            //while (varmi)
            //{
            //    if (numbers.Contains(8))
            //    {
            //        numbers.Remove(8);
            //    }
            //    else
            //    {
            //        varmi = false;
            //    }
            //}
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            List <int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 11 });

            //var result = numbers.Find(i => i > 5); //5 ten büyük ilk değer döner

            //var result = numbers.FindAll(i => i > 5); //5 ten büyük bütün değerleri döner

            var result = numbers.FindAll(i => i > 5).Count(); //5ten büyük bütün sayıların kaçtane olduğunu döner --LİNQ SORGUSU

            Console.WriteLine(result);
            numbers.Sort(); //küçükten büyüğe sıralar
            numbers.Reverse();//büyükten küçüğe sıralar
        }

    }
}
