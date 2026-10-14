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

            /*ciclo while al momento di inserire dati
             usando il do while possiamo fare in modo che un input venga chiesto ripetutamente finche si compiano certe condizioni
             La struttura si produce in questo modo:
             do 
             {
                 messaggio per l' input
             }
             while (!                                       //*Dato che il while ripete finche la condizione sia vera, mettendo il ! davanti alla condizione, il ciclo si ripete finche la condizione non sia vera (molto utile perche fa il codice più facile da capire)
                int.TryParse(                               //*int.TryParse() prova a convertire l'input in un numero intero
                    Console.ReadLine(), out giorno)         //*out significa che il valore convertito viene inserito nella variabile seguente
                     || giorno < 1 || giorno > 31           //* "||" significa "oppure", quindi la condizione diventa vera (dato che viene invertita dal !) se l'input non è un numero intero oppure se il numero inserito è minore di 1 oppure maggiore di 31
                );                                          //! Fine condizione, quindi il ciclo si ripete finche l'input non è un numero intero compreso tra 1 e 31

            normalmente viene scritto tutto in una riga, ma per comodità di lettura l'ho dissezionato in più righe
            */
            do
            {
                Console.Write("Inserisci il giorno: ");
            }
             while (!int.TryParse(Console.ReadLine(), out giorno) || giorno < 1 || giorno > 31); 

            do 
            {
                Console.Write("Inserisci il mese: ");
            }
            while (!int.TryParse(Console.ReadLine(), out mese) || mese < 1 || mese > 12);

            do 
            {
                Console.Write("Inserisci l'anno: ");
            }
            while (!int.TryParse(Console.ReadLine(), out anno) || anno < 1900 || anno > 2999);

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