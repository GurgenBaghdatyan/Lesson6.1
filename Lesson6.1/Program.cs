using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int n=Convert.ToInt32(Console.ReadLine());
            Random random= new Random();
            for (int i=0;i<n;i++)
            {
                a[i]=250- random.Next(500);
                Console.Write(a[i]+" ");
            }
            int max = a[0];
            int min = a[0];
            int maxIndex = 0;
            int minIndex = 0;
            for (int i=1;i<n;i++)
            {
                if (a[i]>max)
                {
                    max = a[i];
                    maxIndex= i;
                }
                else if (a[i]<min)
                {
                    min = a[i];
                    minIndex = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(max+min);
            Console.WriteLine(max*min);
            Console.WriteLine(max+maxIndex+1);
            Console.WriteLine(min+minIndex+1);
            Console.WriteLine(maxIndex+1);
            Console.WriteLine(minIndex+1);
            for (int i=0;i<n;i++)
            {
                if (a[i] == max) maxIndex = i;
                else if (a[i] == min) minIndex = i;
            }
            Console.WriteLine(maxIndex + 1);
            Console.WriteLine(minIndex + 1);
            Console.ReadKey();

        }
    }
}
