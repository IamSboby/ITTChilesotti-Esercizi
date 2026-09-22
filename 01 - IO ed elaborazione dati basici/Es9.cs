using System;

class Program
{
    static void Main()
    {
        int numeroIscritti, numeroVotanti, NumeroSi;
        double percentualeVotanti, percentualeSi;
        
        Console.Write("Inserisci il numero di iscritti: ");
        numeroIscritti = Convert.ToInt32(Console.ReadLine());

        Console.Write("Inserisci il numero di votanti effetivi: ");
        numeroVotanti = Convert.ToInt32(Console.ReadLine());

        Console.Write("Inserisci il numero di voti favorevoli: ");
        NumeroSi = Convert.ToInt32(Console.ReadLine());

        percentualeVotanti = (double)numeroVotanti / numeroIscritti * 100;
        percentualeSi = (double)NumeroSi / numeroVotanti * 100;

        Console.WriteLine("Percentuale di votanti: " + percentualeVotanti);
        Console.WriteLine("Percentuale di voti favorevoli: " + Math.Round(percentualeSi, 2) + "%"); //* (arrotondato a 2 cifre decimali)
        Console.WriteLine("Percentuale di voti non favorevoli: " + Math.Round(100 - percentualeSi, 2) + "%"); //* (anche qua arrotondato a 2 cifre decimali)
    }
}

//il programma credo non usi certe librerie come su visual studio dato che io uso gia da anni VS Code e ho usato direttamente quello