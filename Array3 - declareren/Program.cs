using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3___declareren
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getal = new int[5];
            int[] num = new int[5];
            int[] som = new int[5];


            for (int i = 0; i < getal.Length; i++)
            {
                getal[i] = i+2;
                Console.WriteLine($"Uw getal nummer {i+1} is gelijk aan: {getal[i]}");
            }
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i+3;
                Console.WriteLine($"Uw num nummer {i + 1} is gelijk aan: {num[i]}");
            }
            for (int i = 0; i < som.Length; i++)
            {
                som[i] = getal[i]+num[i];
                Console.WriteLine($"Uw som nummer {i + 1} is gelijk aan: {som[i]}");
            }
        }
    }
}
