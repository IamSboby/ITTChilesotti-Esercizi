using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] NumArr;
            do
            {
                Console.Write("Inserisca di quanti numeri eseguire la media:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(n >= 2));

            NumArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserire numero {i}:");
                NumArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La media dei numeri è uguale a: {NumArr.Average()}");
        }
    }
}