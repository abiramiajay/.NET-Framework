using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 10, 20, 30,97 };
            int aa = a.Length;
            int[] b = new int[] { 40, 50, 60,80,34,90 };
            int bb = b.Length;
            int cc=(aa)+(bb);
            int[] c = new int[cc];
            int k=0; int j=0;int i=0;
            for (i = 0;i < aa; i++)
            {
                c[k++] = a[i];

            }
            for (j = 0; j < bb; j++)
            {
                c[k++] = b[j];

            }
            for (k = 0; k< cc; k++)
            {
                Console.Write(c[k]+" ");
            }
            Console.ReadLine();
        }
    }
}
