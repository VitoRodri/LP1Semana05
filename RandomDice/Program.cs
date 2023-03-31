using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de dados a lançar:");
            string r=Console.ReadLine();
            int n=Int32.Parse(r);
            Random rand= new Random();
            Console.WriteLine($"Os Dados:");

            for (int i=0; i<n; i++)
            {
               Console.WriteLine($"{rand.Next(1,6)}"); 
            }
        }
    }
}
