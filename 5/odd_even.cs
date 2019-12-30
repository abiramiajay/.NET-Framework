using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {   int n=int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {    
                Console.WriteLine("the Even numbers are"+i);
                
            }
            else {
                Console.WriteLine("the odd numbers are {0}",i);
            }
     
        } 
        Console.ReadLine();
        }
    }
}
