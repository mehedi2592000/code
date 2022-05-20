using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    internal class Program
    {
        public static void Selection(int[] arr,int n)
        {
            //int p = arr[0];

            for(int i = 0; i < n-1; i++)
            {
                int p = -1;
                for(int j=i+1;j<n;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        p = j;

                        int a = arr[i];
                        arr[i] = arr[p];
                        arr[p] = a;
                    }
                }

                
            }
        }

        public static void print(int[] arr,int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int[] arr = { 65, 25, 12, 22, 11 };
            int n=arr.Length;

            Selection(arr,n);
            print(arr, n);
        }
    }
}
