using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaki_search
{
    internal class Program
    {

        public static int fibonakiie(int[] arr,int x,int n)
        {
            int fib2 = 0;
            int fib1 = 1;
            int fib=1;

            while(fib<n)
            {
                fib2 = fib1;
                fib1 = fib;
                fib=fib2+ fib1;
            }

            int ofset = -1;

            while(fib>1)
            {
                int i=Math.Min((ofset+fib2),(n-1));

                if (arr[i] < x)
                {
                    fib = fib1;
                    fib1 = fib2;
                    fib2 = fib - fib2;
                    ofset = i;
                }
                else if (arr[i] > x)
                {
                    fib = fib1;
                    fib1 = fib - 1;
                    fib2 = fib - fib1;
                    ofset = i;
                }
                else
                    return i;
            }
            if (fib1 == 1 && arr[n - 1] == x)
                return n - 1;

            return -1;

        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100, 230 };

            int n = arr.Length;

            int r = fibonakiie(arr,230, n);

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
