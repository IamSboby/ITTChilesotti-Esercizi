using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("inserire Numero diverso da 0:");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero == 0);

            Console.WriteLine($"La tabbelina del {numero}:\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1} X {numero} = {numero*(i+1)}");
            }
        }
    }
}