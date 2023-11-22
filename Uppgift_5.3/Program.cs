using System;
namespace Uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArray = new int[3];

            Console.WriteLine("Skriv in tre heltal på var sin rad");

            for (int i = 0; i < talArray.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        talArray[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Det är inte ett giltigt svar. Försök igen");
                    }
                }
            }
            
            int summa = 0;

            foreach (int tal in talArray)
            {
                summa += tal;
            }

            Console.WriteLine($"\nSumman av de talen är {summa}.\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}