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

            /*ciclo while al momento di inserire dati
             usando il do while possiamo fare in modo che un input venga chiesto ripetutamente finche si compiano certe condizioni
             La struttura si produce in questo modo:
             do 
             {
                 messaggio per l' input
             }
             while (!                                       //*Dato che il while ripete finche la condizione sia vera, mettendo il ! davanti alla condizione, il ciclo si ripete finche la condizione non sia vera (molto utile perche fa il codice più facile da capire)
                Convert.ToInt32(                            //*Convert.ToInt32() per convertere linput in un numero intero
                    Console.ReadLine(), out giorno)         //*out significa che il valore dell'input viene inserito nella variabile seguite 
                     || giorno < 1 || giorno > 31           //* "||" significa "oppure", quindi la condizione diventa vera (dato che viene invertita dal !) se l'input non è un numero intero oppure se il numero inserito è minore di 1 oppure maggiore di 31
                );                                          //! Fine condizione, quindi il ciclo si ripete finche l'input non è un numero intero compreso tra 1 e 31

            normalmente viene scritto tutto in una riga, ma per comodità di lettura l'ho dissezionato in più righe
            */
            do
            {
                Console.Write("Inserisci il giorno: ");
            }
            while (!Convert.ToInt32(Console.ReadLine(), out giorno) || giorno < 1 || giorno > 31); 

            do 
            {
                Console.Write("Inserisci il mese: ");
            }
            while (!Convert.ToInt32(Console.ReadLine(), out int mese) || mese < 1 || mese > 12);

            do 
            {
                Console.Write("Inserisci l'anno: ");
            }
            while (!Convert.ToInt32(Console.ReadLine(), out int anno) || anno < 1);

            bool dataValida = false; //indicatore che ci dirà se la data è valida o meno
            //? Fun Fact: in programmazione usare i bool in questa maniera di dice "flag" (bandiera) Come nelle gare type shi
            
            if (mese == 2) //Febbraio
            {
                if (anno % 4 == 0 && (anno % 100 != 0 || anno % 400 == 0)) //Anno bisestile
                {
                    dataValida = giorno <= 29;
                }
                else
                {
                    dataValida = giorno <= 28;
                }
            }
            else if (mese == 4 || mese == 6 || mese == 9 || mese == 11) //Mesi con 30 giorni
            {
                dataValida = giorno <= 30;
            }
            else //Mesi con 31 giorni
            {
                dataValida = giorno <= 31;
            }

            Console.WriteLine(dataValida ? "La data è corretta." : "La data è errata."); //Operatore ternario "?", se dataValida è vero(True) stampa "La data è corretta.", altrimenti stampa "La data è errata."
            
            /*  
                Spiegazione di come funziona l'operatore ternario in specifico
                loperatore ternario è un operatore che prende tre operandi (dati/iniformazioni/variabili), il primo è un booleano (puo essere sia una variabile che una condizione), il secondo è il valore da restituire se la condizione è vera, il terzo è il valore da restituire se la condizione è falsa. In questo caso, se dataValida è vero, stampa "La data è corretta.", altrimenti stampa "La data è errata."
                la sturttura viene tipo
                (condizione o variabile con valori possibili vero o falso) ? valore_se_vero : valore_se_falso;
            */
        }
    }
}