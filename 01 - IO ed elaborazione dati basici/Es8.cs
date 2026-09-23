using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci i litri di olio da acquistare: ");
        double litriPartitaOlio = Convert.ToDouble(Console.ReadLine());
        const int prezzoOlioNormale = 15, prezzoOlioPremium = 20;
        double prezzoSpesa =(double) ((litriPartitaOlio*prezzoOlioNormale)+(litriPartitaOlio * prezzoOlioPremium));
        Console.WriteLine("Prezzo della spesa:" + prezzoSpesa);

        Console.ReadKey();
    }
}

//il programma credo non usi certe librerie come su visual studio dato che io uso gia da anni VS Code e ho usato direttamente quello
