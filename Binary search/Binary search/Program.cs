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

        public static void swap(int[] arr,int m,int l)
        {
            int t=arr[m];
            arr[m]=arr[l];
            arr[l]=t;
        }

        public static void sorf(int[] arr,int n,int m)
        {
            int largest = m;
            int Left = 2 * m + 1;
            int Right = 2 * m + 2;

            if(Left<n && arr[Left]>arr[largest])
                largest = Left;

            if(Right<n && arr[Right]>arr[largest])
                largest=Right;

            if(largest!=m)

            {
                int sp = arr[m];
                arr[m] = arr[largest];
                arr[largest] = sp;

                sorf(arr, n, largest);
            }

            
            
        }
        public static void heap(int[] arr,int n)
        {
                int m = n / 2 - 1;
                for(int i=m;i>=0 ;i--)
                {
                sorf(arr, n, i);
                }
                
            for(int i=n-1;i>0 ;i--)
            {
                int gg = arr[0];
                arr[0] = arr[i];
                arr[i] = gg;

               sorf(arr, i, 0);
            }
        }

        public static void print(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int[] arr = { 2, 5, 4, 9, 8, 15, 10 };
            int n=arr.Length;

            heap(arr,n);

            //print(arr);

          int m=  Binay(arr, 0, n - 1, 15);

            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
