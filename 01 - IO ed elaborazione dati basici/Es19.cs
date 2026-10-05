using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio19 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            int prezzoFinale, ore, oraInizio, oraFine;
            const int prezzoPrimaOra = 4, prezzoSecondaOra = 3, prezzoOreGen = 2; //usiamo delle contanti cosi al momento di modificare il programma non dobbiamo andare a modificare tt il codice ma solo ste constanti

            Console.WriteLine("si ricorda di inserire l'ora in formato 24h, quindi da 0 a 23");

            Console.Write("Inserisci ora entrata al parcheggio: ");
            oraInizio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci ora uscita dal parcheggio: ");
            oraFine = Convert.ToInt32(Console.ReadLine());

            ore = oraFine - oraInizio;

            if (ore == 1)
            {
                prezzoFinale = prezzoPrimaOra;
            }
            else if (ore == 2)
            {
                prezzoFinale = prezzoPrimaOra + prezzoSecondaOra;
            }
            else
            {
                prezzoFinale = prezzoPrimaOra + prezzoSecondaOra + (prezzoOreGen * (ore - 2));
            }

            Console.WriteLine($"\nIl prezzo finale è: {prezzoFinale}€");
            Console.WriteLine($"ore di sosta: {ore}");
            
            Console.ReadKey();
        }
    }
}
