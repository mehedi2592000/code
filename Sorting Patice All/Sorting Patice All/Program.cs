using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Patice_All
{
    internal class Program
    {
        /*
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
        */
        /*
        public static void countsort(int[] arr,int n)
        {
            int max =arr.Max();
            int min=arr.Min();
            int size = max - min + 2;

            int[] arr1=new int[size];
            int[] oute= new int[n];

            for(int i=0;i<size;i++)
            {
                arr1[i]=0;
            }

            for(int i=0;i<n;i++)
            {
                arr1[arr[i]]++;
            }

            for(int i=1;i<size;i++)
            {
                arr1[i] += arr1[i-1];
            }


            for(int i=n-1;i>=0;i--)
            {
                oute[arr1[arr[i]]-1]=arr[i];
                arr1[arr[i] - 1]--;
            }



            for(int i=0;i<n;i++)
            {
                Console.WriteLine(oute[i] + " ");
            }

            Console.ReadKey();
        }
        */

        public static void cs(int[] arr,int n,int p)
        {
            int[] coun = new int[10];
            int[] oute= new int[n];

            for(int i=0;i<10;i++)
            {
                coun[i] = 0;
            }

            for(int i=0;i<n;i++)
            {
                coun[(arr[i] / p) % 10]++;
            }

            for(int i=1;i<10;i++)
            {
                coun[i] += coun[i - 1];
            }

            for(int i=n-1;i>=0;i--)
            {
                oute[coun[(arr[i] / p) % 10]-1]=arr[i];
                coun[(arr[i] / p) % 10]--;
            }

            for(int i=0;i<n;i++)
            {
                arr[i] = oute[i];
            }

            
        }

        public static void print(int[] arr,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.ReadKey();
        }
        public static void ReadoxSort(int[] arr,int n)
        {
            int mx = arr.Max();

            for(int i=1;mx/i>0;i*=10)
            {
                cs(arr, n, i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 1, 16, 4, 20, 25 };
            int n=arr.Length;
            // HeapSort(arr, n);
            

            //countsort(arr, n);

            ReadoxSort(arr, n);

            print(arr, n);
        }
    }
}
