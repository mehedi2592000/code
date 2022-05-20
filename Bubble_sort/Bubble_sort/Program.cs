using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    internal class Program
    {
        public static void Bubble(int[] arr,int n)
        {
            for(int i = 0; i < n-1; i++)
            {
                for(var j = 0; j < n-i-1; j++)
                {
                    if(arr[j]> arr[j+1])
                    {
                        int q = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = q;

                        Console.WriteLine(arr[j]+" ok "+arr[j+1]);
                    }
                }
            }
        }

        public static void print(int[] arr,int n)
        {
            for(int i=0;i<n; i++)
            {
                Console.WriteLine(arr[i]);

            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int[] arr = { 64, 25, 12, 22, 11 };
            int n=arr.Length;

            Bubble(arr, n);
            print(arr, n);
        }
    }
}
