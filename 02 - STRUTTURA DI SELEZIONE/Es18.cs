using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeProgetto //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            Console.Write("Inserisci il 1° numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci il 2° numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci il 3° numero: ");
            numero3 = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("\nDesidera stampare i numeri in ordine crescente o decrescente?");
            Console.WriteLine("1. Crescente");
            Console.WriteLine("2. Decrescente");
            Console.Write("Scelta: ");
            int scelta;
            do{
                scelta = Convert.ToInt32(Console.ReadLine());
            } while (scelta != 1 && scelta != 2);

            double temporaneo;
            bool ordineCrescente = scelta == 1;

            if ((ordineCrescente && numero1 > numero2) || (!ordineCrescente && numero1 < numero2))
            {
                temporaneo = numero1;
                numero1 = numero2;
                numero2 = temporaneo;
            }

            if ((ordineCrescente && numero2 > numero3) || (!ordineCrescente && numero2 < numero3))
            {
                temporaneo = numero2;
                numero2 = numero3;
                numero3 = temporaneo;
            }

            if ((ordineCrescente && numero1 > numero2) || (!ordineCrescente && numero1 < numero2))
            {
                temporaneo = numero1;
                numero1 = numero2;
                numero2 = temporaneo;
            }

            Console.WriteLine("Numeri in ordine {0}:", scelta == 1 ? "crescente" : "decrescente"); //riutilizzo l'operatore ternario per stampare "crescente" o "decrescente" in base alla scelta dell'utente
            
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            
            Console.ReadKey();
        }
    }
}
