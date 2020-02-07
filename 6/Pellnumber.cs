using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {   int a=0,b=1,c=0;
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(a);
        Console.WriteLine(b); 
       for (int i = 0; i < n; i++)
       {
           int c = a+2 * b;
           
           a = b;
           b = c;
           Console.WriteLine(c);
       }
       Console.ReadLine();
        }
       
    }
}
