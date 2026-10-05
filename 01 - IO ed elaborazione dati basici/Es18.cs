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
            //un array: prendiamo pre esempio che le variabili sono delle scatole, un'array è come un cassonetto con tante scatole dentro
            double[] numeri = new double[3];                //array di 3 numeri double, quindi con la virgola, che possono essere anche negativi
            
            for (int i = 0; i < numeri.Length; i++)         //ciclo for che si ripete per la lughezza dell'array (3 volte in sto caso)
            {                                               //usando codice che fa riferimenti direttimenti a variabili e array il codice diventa molto più facile da modificare in futuro
                
                Console.Write($"Inserisci il {i + 1}° numero: ");       //gli array partono SEMPRE da 0, quindi per far vedere all'utente che sta inserendo il primo numero bisogna fare i + 1
                numeri[i] = Convert.ToDouble(Console.ReadLine());       //assegno il numero inserito dall'utente all'array nella posizione i
            }




            Console.WriteLine("\nDesidera stampare i numeri in ordine crescente o decrescente?");
            Console.WriteLine("1. Crescente");
            Console.WriteLine("2. Decrescente");
            Console.Write("Scelta: ");
            int scelta;
            do{
                scelta = Convert.ToInt32(Console.ReadLine());
            } while (scelta != 1 && scelta != 2);

            if (scelta == 1)
            {
                Array.Sort(numeri);
            }
            else if (scelta == 2)
            {
                Array.Sort(numeri);
                Array.Reverse(numeri);
            }

            Console.WriteLine("Numeri in ordine {0}:", scelta == 1 ? "crescente" : "decrescente"); //riutilizzo l'operatore ternario per stampare "crescente" o "decrescente" in base alla scelta dell'utente
            
            foreach (double numero in numeri)       //attenzione qui, uso un foreach invece di un for, quindi non ho bisogno di usare l'indice i per accedere agli elementi dell'array
            {                                       //il foreach cicla automaticamente su tutti gli elementi dell'array, quindi non devo preoccuparmi di usare un indice per accedere agli elementi
                Console.WriteLine(numero);          //stampo il numero corrente dell'array, che viene preso automaticamente dal foreach
            }

            
            /* //?Spiegazione estesa del foreach:
              Il foreach è un costrutto di iterazione che permette di scorrere gli elementi di una collezione (come un array o una lista) senza dover gestire manualmente gli indici.
              La sintassi è la seguente:
              foreach (tipoVaribile NomeDelElemento in NomeArray)
              {
                  codice da eseguire per ogni elemento
              }
              In questo caso, "double numero" rappresenta l'elemento corrente dell'array "numeri" durante ogni iterazione del ciclo.
              Il ciclo continuerà fino a quando tutti gli elementi dell'array saranno stati elaborati.
             */
            
            Console.ReadKey();
        }
    }
}
