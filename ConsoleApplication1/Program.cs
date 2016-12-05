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
            bas:
            Console.WriteLine("Islem seçiniz bunlar kare  dikdortgen veya kare");

            string islem = Convert.ToString(Console.ReadLine());
            switch (islem)
            {
                case "kare":

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("*");
                        Console.Write(" ");

                        for (int j = 0; j < 3; j++)
                        {

                            if (i == 0 || i == 4)
                            {
                                Console.Write("* ");

                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }

                        Console.Write("*");

                        Console.WriteLine();

                    }

                    break;

                case "dikdortgen":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("*");
                        Console.Write(" ");

                        for (int j = 0; j < 7; j++)
                        {

                            if (i == 0 || i == 4)
                            {
                                Console.Write("*");
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write(" " + " ");
                            }
                        }

                        Console.Write("*");

                        Console.WriteLine();

                    }
                    break;

                case "paralel":
                    
                    for (int i = 4; i > 0; i--)
                    {

                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(" ");

                        }
                        Console.Write("* ");
                        for (int j = 0; j < 7; j += 3)
                        {

                            if (i == 1 || i == 4)
                            {
                                Console.Write("* ");

                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }

                        Console.Write("*");

                        Console.WriteLine();

                    }
           


            break;

            default:
                Console.WriteLine("Baska bir islem seciniz:");
                   
                    goto bas;
            
            }
            Console.Read();
        }


        

}
}

