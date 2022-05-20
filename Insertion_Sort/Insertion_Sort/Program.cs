using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    internal class Program
    {

        public static void In_sort(int[] arr,int n)
        {
            for(int i = 1; i < n; i++)
            {
                int m=arr[i];
                for(int j=i-1;j>=0;j--)
                {
                    if(arr[j]>m)
                    {
                        arr[j+1]=arr[j];
                        arr[j]=m;

                       // Console.WriteLine(arr[j]+"  "+arr[j+1]);
                    }
                }
            }
            //Console.ReadLine(); 
        }
        
        public static void print(int[] arr,int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            int[] arr = { 12, 11, 13, 5, 6 };
            int n=arr.Length;

            In_sort(arr, n);
            print(arr, n);
        }
    }
}
