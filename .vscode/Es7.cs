using System;

class Program
{
    static void Main()
    {
        double oreLavorate, pagaOraria, pagaNetto, PagaLordo;
        const double tasse =(double) 27/100; // 27% di tasse
        
        Console.Write("Inserisci le ore lavorate: ");
        oreLavorate = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Inserisci la paga oraria: ");
        pagaOraria = Convert.ToDouble(Console.ReadLine());

        PagaLordo =(double) oreLavorate * pagaOraria;
        pagaNetto =(double) PagaLordo - (PagaLordo * tasse);

        Console.WriteLine("Paga Lordo: " + PagaLordo);
        Console.WriteLine("Paga Netto: " + pagaNetto);
    }
}

//il programma credo non usi certe librerie come su visual studio dato che io uso gia da anni VS Code e ho usato direttamente quello