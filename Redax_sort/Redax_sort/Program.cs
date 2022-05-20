using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redax_sort
{
    internal class Program
    {
        public static int getMax(int[] arr,int n)
        {
            int max=arr.Max();
            return max;
        }
        public static void countingSort(int[] arr, int n, int pos)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / pos) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / pos) % 10] - 1] = arr[i];
                count[(arr[i] / pos) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i]=output[i];
            }
        }

        public static void radixsort(int[] arr,int n)
        {
            int m = getMax(arr, n);
                
            for(int pos=1;m/pos>0;pos*=10)
            {
                countingSort(arr, n, pos);
            }
            
        }

        public static void print(int[] arr,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);

            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int[] arr = { 329, 657, 457, 355 };
            int n=arr.Length;

            radixsort(arr, n);

            print(arr, n);


        }
    }
}
