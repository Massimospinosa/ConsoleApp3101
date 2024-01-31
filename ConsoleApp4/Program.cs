using System;

public class ContoCorrente
{
    private bool contoAperto;
    private decimal saldo;

    public ContoCorrente()
    {
        contoAperto = false;
        saldo = 0;
    }

    public void ApriConto(decimal importoIniziale)
    {
        if (!contoAperto && importoIniziale >= 1000)
        {
            contoAperto = true;
            saldo += importoIniziale;
            Console.WriteLine("Conto aperto con un versamento iniziale di {0} euro.", importoIniziale);
        }
        else
        {
            Console.WriteLine("Impossibile aprire il conto. Assicurarsi che il conto non sia già aperto e che l'importo iniziale sia almeno 1000 euro.");
        }
    }

    public void Versamento(decimal importo)
    {
        if (contoAperto)
        {
            saldo += importo;
            Console.WriteLine("Versamento di {0} euro effettuato. Saldo attuale: {1} euro.", importo, saldo);
        }
        else
        {
            Console.WriteLine("Impossibile effettuare il versamento. Il conto non è ancora aperto.");
        }
    }

    public void Prelevamento(decimal importo)
    {
        if (contoAperto && saldo >= importo)
        {
            saldo -= importo;
            Console.WriteLine("Prelevamento di {0} euro effettuato. Saldo attuale: {1} euro.", importo, saldo);
        }
        else
        {
            Console.WriteLine("Impossibile effettuare il prelevamento. Il conto non è aperto o il saldo non è sufficiente.");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci il numero di nomi da caricare:");
        int numeroNomi = int.Parse(Console.ReadLine());

        string[] arrayNomi = new string[numeroNomi];

        for (int i = 0; i < numeroNomi; i++)
        {
            Console.WriteLine("Inserisci il nome {0}:", i + 1);
            arrayNomi[i] = Console.ReadLine();
        }

        Console.WriteLine("Inserisci il nome da cercare:");
        string nomeDaCercare = Console.ReadLine();

        bool presente = Array.Exists(arrayNomi, nome => nome == nomeDaCercare);

        if (presente)
        {
            Console.WriteLine("Il nome {0} è presente nell'array.", nomeDaCercare);
        }
        else
        {
            Console.WriteLine("Il nome {0} non è presente nell'array.", nomeDaCercare);
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inserisci la dimensione dell'array:");
        int dimensioneArray = int.Parse(Console.ReadLine());

        int[] numeri = new int[dimensioneArray];

        for (int i = 0; i < dimensioneArray; i++)
        {
            Console.WriteLine("Inserisci il numero {0}:", i + 1);
            numeri[i] = int.Parse(Console.ReadLine());
        }

        int somma = 0;

        foreach (int numero in numeri)
        {
            somma += numero;
        }

        double media = (double)somma / dimensioneArray;

        Console.WriteLine("Somma: {0}", somma);
        Console.WriteLine("Media: {0}", media);
    }
}
