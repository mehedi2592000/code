using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    internal class Program
    {
        static void countsort(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();
            int range = max - min + 1;

            int[] count = new int[range];
            int[] output = new int[arr.Length];

            for(int i=0;i<arr.Length;i++)
            {
                count[arr[i]]++;
            }

            for(int j=1;j<range;j++)
            {
                count[j]+=count[j-1];
            }


            

            for(int j=arr.Length-1;j>=0;j--)
            {
                output[count[arr[j]]-1]=arr[j];
                count[arr[j]]--;
            }

            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=output[i];

            }

             

        }
        
        static void printarr(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.ReadKey();
        }
        
       public  static void Main(string[] args)
       {
            int[] arr = { 2, 5, 3, 0, 2, 3, 0, 3 };
            countsort(arr);
            printarr(arr);
       }
    }
}
