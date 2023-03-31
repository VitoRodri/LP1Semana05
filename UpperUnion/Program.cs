using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string strings in args)
            {
                Console.WriteLine($"{strings.ToUpper()}");
            }
            

        }
    }
}
