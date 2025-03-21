using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Ange din golfspelares styrkevärde (1-10): ");
        if (int.TryParse(Console.ReadLine(), out int styrka) && styrka >= 1 && styrka <= 10)
        {
            Console.WriteLine("Kraftmätare startar...\n");

            // Räkna upp
            for (int i = 0; i <= styrka; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200); // Fördröjning på 300ms för att simulera spelmekanik
            }

            // Räkna ner
            for (int i = styrka - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }

            Console.WriteLine("\nFörsök att slå när styrkan är som högst!");
        }
        else
        {
            Console.WriteLine("Felaktig inmatning. Vänligen ange ett tal mellan 1 och 10.");
        }
    }
}


