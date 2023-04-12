using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._04._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task:1
            //Console.WriteLine("Birinci reqemi daxil edin: ");
            //int.TryParse(Console.ReadLine(),out int number1);

            //Console.WriteLine("Ikinci reqemi daxil edin: ");
            //int.TryParse(Console.ReadLine(), out int number2);

            //try
            //{
            //    int result = number1 / number2;
            //    Console.WriteLine($"Cavab: {result}");
            //}
            //catch
            //{
            //    Console.WriteLine("Bele bir emeliyyat mumkun deyil!!!");
            //}


            //////Task:2
            //int[] number = { 1, 2, 4, 3, 9, 15, 6, 94, 7, 1970, 13 };
            //Console.WriteLine(number.Max(element => Math.Abs(element)));


       

            //task:5
            List<int> number = new List<int>()
            {
                29,97,14,18,22,96,148
            };
            var newList = number.Where(n => n % 2 == 0);

            Console.WriteLine(newList);

        }

    }

   
}
