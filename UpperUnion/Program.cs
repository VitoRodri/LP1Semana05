using System;
using System.Text;
using System.Collections.Generic;


namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                Console.WriteLine($"NO ARGUMENTS");

            }
            else
            {
                List<string> newargs=new List<string>();
                Array.Sort(args);
                foreach (string strings in args)
                {
                    newargs.Add(strings.ToUpper());
                    
                }
                Console.WriteLine($"{String.Join("-",newargs)}");
            }
            
            
            
        

        }
    }
}
