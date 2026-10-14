using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio15 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;                              //variabile booleana per uscire dal ciclo while
            double primo, secondo;                              //le variabili si potevano anche dichiareare dentro gli argomenti della funzione InputNumeri ma diventava un casino al momento di capire il codice. cosi invece è piu leggibile 

            InputNumeri(out primo, out secondo);                //out nei argomenti della funzione serve per assegnare valori alle variabili in base al risultato della funzione stessa

            void InputNumeri(out double primo, out double secondo) //funzione per l'input dei numeri
            {
                Console.Write("Inserisci il primo numero: ");
                primo = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nInserisci il secondo numero: ");
                secondo = Convert.ToDouble(Console.ReadLine());
            }

            while (continua)
            {
                Console.ResetColor();
                Console.WriteLine("\n1. Somma\n2. Moltiplicazione\n3. Differenza\n4. Quoziente\n5. Esci\n6. Cambia numeri\n");
                Console.Write("Scegli un'operazione: ");
                int scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta) 
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Somma: {primo + secondo}");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Prodotto: {primo * secondo}");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Differenza: {primo - secondo}");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (secondo == 0)                                                               //controllo per evitare la divisione per zero
                            Console.WriteLine("Operazione impossibile: non si può dividere per zero.");
                        else                                                                            //se il secondo numero è diverso da zero allora esegue la divisione
                            Console.WriteLine($"Quoziente: {primo / secondo}");
                        break;
                    case 5:
                        continua = false;                                                               //se l'utente sceglie 5 allora la variabile booleana diventa false e il ciclo while si interrompe
                        break;
                    case 6:
                        InputNumeri(out primo, out secondo);
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
            Console.WriteLine("\nProgramma terminato.");

            Console.ReadKey();

            //si, si poteva fare anche con un ciclo do while, ma sto cercando di fare una progressione più lineare cosi per la gente che non ha anchora capito bene puo imparare poco a poco
        }
    }
}
