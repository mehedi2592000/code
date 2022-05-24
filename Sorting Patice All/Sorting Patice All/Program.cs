using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Patice_All
{
    internal class Program
    {
        public static void Sore(int[] arr,int n,int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            
            if(l<n && arr[l]>arr[largest])
                largest = l;
            if(r<n && arr[r]>arr[largest])
                largest=r;

            if(largest!=i)
            {
                int tem=arr[i];
                arr[i]=arr[largest];
                arr[largest]=tem;

                Sore(arr, n, largest);
            }
        }

        public static void HeapSort(int[] arr,int n)
        {
            for(int i=n/2-1;i>=0;i--)
            {
                Sore(arr, n, i);
            }

            for(int i=n-1;i>0;i--)
            {
                int tem = arr[0];
                arr[0]=arr[i];
                arr[i] = tem;

                Sore(arr, i,0);
            }
        }
        public static void Print(int[] arr,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 1, 16, 4, 20, 25 };
            int n=arr.Length;
            HeapSort(arr, n);
            Print(arr, n);
        }
    }
}
