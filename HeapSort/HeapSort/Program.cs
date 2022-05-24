using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    internal class Program
    {
        public static void sorte(int[] arr,int n)
        {
            for(int i=n/2-1;i>=0;i--)
            {
                heapyfy(arr,n,i);
            }

            for(int i=n-1;i>0;i--)
            {
                int temp=arr[0];
                arr[0]=arr[i];
                arr[i]=temp;

                heapyfy(arr,i,0);
            }
        }

        public static void heapyfy(int[] arr,int n,int i)
        {
            int largest=i;
           int  l=2*i+1;
            int r=2*i+2;

            if(l<n && arr[l]>arr[largest])
                largest=l;
            if(r<n && arr[r]>arr[largest])
                largest=r;

            if(largest!=i)
            {
                int swape=arr[i];
                arr[i]=arr[largest];
                arr[largest]=swape;

                heapyfy(arr,n,largest);
            }

              
        }

        public static void printe(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);  
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 12, 11, 13, 4, 6, 7 };
            int n = arr.Length;

            sorte(arr, n);

            printe(arr);
        }
    }
}
