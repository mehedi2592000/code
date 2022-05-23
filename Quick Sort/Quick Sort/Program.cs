using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    internal class Program
    {
        public static void swape(int[] arr,int i,int j)
        {
            int p=arr[i];
            arr[i]=arr[j];
            arr[j]=p;
        }
        public static int Quik(int[] arr,int l,int h)
        {
            int i = l-1;
            int pivot = arr[h];
            for(int j=l;j<=h-1;j++)
            {
                if(arr[j]<pivot)
                {
                    i++;
                    swape(arr, i, j);
                }
            }
            swape(arr, i+1, h);
            return (i+1);

        }

        public static void Recur(int[] arr,int l,int h)
        {
            if(l<h)
            {
                int pi=Quik(arr,l,h);

                Recur(arr, l, pi-1);
                Recur(arr, pi+1, h);
            }
        }

        public static void print(int[] arr,int l,int q)
        {
            for(int i=0;i<q;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n=arr.Length;

            Recur(arr, 0, n-1 );
            print(arr, 0, n);
        }
    }
}
