using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio9 //Nome del progetto
{
    class Program
    {
        static void Main()
        {
            int numeroIscritti, numeroVotanti, numeroSi; //i votanti sono esseri umani quindi usiamo numeri interi come variabile
            double percentualeVotanti, percentualeSi;
            
            Console.Write("Inserisci il numero di iscritti: ");
            numeroIscritti = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il numero di votanti effetivi: ");
            numeroVotanti = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci il numero di voti favorevoli: ");
            numeroSi = Convert.ToInt32(Console.ReadLine());

            percentualeVotanti =(double) numeroVotanti / numeroIscritti * 100; //semplici calcoli
            percentualeSi =(double) numeroSi / numeroVotanti * 100;

            Console.WriteLine("Percentuale di votanti: " + percentualeVotanti);
            Console.WriteLine("Percentuale di voti favorevoli: " + Math.Round(percentualeSi, 2) + "%");             //* (arrotondato a 2 cifre decimali)
            Console.WriteLine("Percentuale di voti non favorevoli: " + Math.Round(100 - percentualeSi, 2) + "%");   //* usando la classe Math (vedi Es5.cs)

            Console.ReadKey();
        }
    }
}

//il programma credo non usi certe librerie come su visual studio dato che io uso gia da anni VS Code e ho usato direttamente quello
