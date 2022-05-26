using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class Program
    {
        public static int Binay(int[] arr,int l,int r,int x)
        {
            if(l<=r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == x)
                    return m;

                if(arr[m] > x)
                {
                    return Binay(arr,l,m-1,x);
                }

                return Binay(arr, m + 1, r, x);
            }

            return -1;
        }

        static void Main(string[] args)
        {

            int[] arr = { 2, 4, 5, 9, 8, 10, 15 };
            int n=arr.Length;

          int m=  Binay(arr, 0, n - 1, 2);

            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
