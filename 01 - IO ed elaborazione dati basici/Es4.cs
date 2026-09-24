using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio4 //Nome del progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base, Altezza;

            Console.Write("Inserire Base: "); 
            Base = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("\nInserire Altezzza: ");
            Altezza = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIl perimetro è uguale a: " + ((Base*2)+(Altezza*2))); //possiamo anche fare operazioni matematiche direttamente dentro il Console.Write() senza dover creare una variabile apposita
            Console.Write("\nL' area è uguale a: " + (Base*Altezza)); //IMPORTANTE: ricordarsi di mettere le parentesi tonde intorno alle operazioni matematiche, altrimenti il programma non saprà come calcolare l'operazione e darà errore o la calcolera sbagliata
            
            Console.ReadKey();
            //basta nn ho più sbatti di scrivere i commenti mi sto gia rompendo
        }
    }
}
