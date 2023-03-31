using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            Console.WriteLine("Numero de dados a lançar:");
            string r=Console.ReadLine();
            int n=Int32.Parse(r);
            Random rand= new Random();
            Console.WriteLine($"Os Dados:");

            for (int i=0; i<n; i++)
            {
                int dado=rand.Next(1,6);
                soma=soma+dado;
                Console.WriteLine($"{dado}");
            }
            Console.WriteLine($"A soma dos dados é igual a: {soma}");

        }
    }
}
