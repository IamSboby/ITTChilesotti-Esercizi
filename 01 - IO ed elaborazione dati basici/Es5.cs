using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio5 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            double spigolo, volume, faccia, facceTot;

            Console.Write("Inserire primo numero: ");
            spigolo = Convert.ToDouble(Console.ReadLine());

            volume = Math.Pow(spigolo,3); //usando la "classe"(una funzione con più funzioni dentro) Math possiamo fare operazioni matematiche più complesse come la potenza, la radice quadrata ecc. senza dover scrivere il codice per calcolare queste operazioni da zero
            faccia = Math.Pow(spigolo, 2); //usando la "sottofunzione" (pow) possiamo calcolare la potenza di un numero, usando questo formato: math.Pow(numero, potenza)
            facceTot = faccia * 6;

            //nel caso tutta questa storia delle classi o luso della classe math nn vi sia chiara potete usare questa soluzione altrenativa://
            /* -> inizio commento lungo
            volume = spigolo * spigolo * spigolo;
            faccia = spigolo * spigolo;
            facceTot = faccia * 6;
            fine commento lungo <- */
            

            Console.Write("\nIl volume equivale a: " + volume); //dopo tutti i calcoli stampiamo i risultati
            Console.Write("\nIl volume equivale a: " + faccia);
            Console.Write("\nIl volume equivale a: " + facceTot);
            Console.ReadKey();
        }
    }
}
