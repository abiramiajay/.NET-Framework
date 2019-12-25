using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            int[] ary = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter element " + i);
                ary[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in ary)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
