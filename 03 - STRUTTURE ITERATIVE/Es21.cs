using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fattore=1;
            do
            {
                Console.Write("Inserisca il numero da fatorializzare: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(n <= 10 || n >= 1));

            for (int i = 0; i < n; i++)
            {
                fattore *= i + 1;
            }
            Console.WriteLine($"{n}! = {fattore}");
        }
    }
}