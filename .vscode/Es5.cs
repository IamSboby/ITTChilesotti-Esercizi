using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziVari
{
    class Program
    {
        static void Main(string[] args)
        {
            double spigolo, volume, faccia, facceTot;

            Console.Write("Inserire primo numero: ");
            spigolo = Convert.ToDouble(Console.ReadLine());

            volume = Math.Pow(spigolo,3);
            faccia = Math.Pow(spigolo, 2);
            facceTot = faccia * 6;

            Console.Write("\nIl volume equivale a: " + volume);
            Console.Write("\nIl volume equivale a: " + faccia);
            Console.Write("\nIl volume equivale a: " + facceTot);
            Console.ReadKey();
        }
    }
}
