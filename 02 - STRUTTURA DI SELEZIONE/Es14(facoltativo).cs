using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio14 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            int giorno;
            int mese;
            int anno;

            Console.Write("Inserisci il giorno: ");
            giorno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il mese: ");
            mese = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci l'anno: ");
            anno = Convert.ToInt32(Console.ReadLine());

            // DaysInMonth gestisce automaticamente i mesi con 30/31 giorni
            // e il 29 febbraio negli anni bisestili.
            bool dataValida = giorno <= DateTime.DaysInMonth(anno, mese);

            Console.WriteLine(dataValida ? "La data è corretta." : "La data è errata."); //Operatore ternario "?", se dataValida è vero(True) stampa "La data è corretta.", altrimenti stampa "La data è errata."
            
            Console.ReadKey();
            /*  
                Spiegazione di come funziona l'operatore ternario in specifico
                loperatore ternario è un operatore che prende tre operandi (dati/iniformazioni/variabili), il primo è un booleano (puo essere sia una variabile che una condizione), il secondo è il valore da restituire se la condizione è vera, il terzo è il valore da restituire se la condizione è falsa. In questo caso, se dataValida è vero, stampa "La data è corretta.", altrimenti stampa "La data è errata."
                la sturttura viene tipo
                (condizione o variabile con valori possibili vero o falso) ? valore_se_vero : valore_se_falso;
            */
        }
    }
}