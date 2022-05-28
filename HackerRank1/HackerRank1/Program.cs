using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    internal class Program
    {
        public static void Sore(int[] arr,int n, int m)
        {
            int largest = m;
            int Left = m * 2 + 1;
            int Right = m * 2 + 2;

            if(Left<n && arr[Left]>arr[largest])
            {
                largest = Left;
            }

            if(Right<n && arr[Right]>arr[largest])
                largest = Right;

            if(largest!=m)
            {
                int z=arr[largest];
                arr[largest]=arr[m];
                arr[m] = z;

                Sore(arr,n,largest);
            }
        }

        public static void Heap(int[] arr, int n)
        {
            int q = n / 2 - 1;

            for(int i = q;i>=0; i--)
            {
                Sore(arr, n, i);
            }

            for(int i=n-1;i>0;i--)
            {
                int t = arr[0];
                arr[0]=arr[i];
                arr[i] = t;

                Sore(arr, i, 0);
            }
        }
        
        public static int Binary(int[] arr,int i,int t,int x)
        {
            int r = i + (t - i) / 2;

            if (arr[r] == x)
                return r;

            if (arr[r] > x)
                return Binary(arr, 0, r - 1, x);

            return Binary(arr, r + 1, t, x);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());

               int m = Convert.ToInt32(Console.ReadLine());
                //int[] arr = { 4, 2, 3, 1, 5, 6 };
                
                int[] arr = new int[m];
                
                for(int j = 0; j < arr.Length; j++)
                {
                    arr[j] = Convert.ToInt32(Console.ReadLine());
                }
                
                Heap(arr, arr.Length);
                
                for(int d=0;d<arr.Length; d++)
                {
                    int t=arr[d];
                    int p = k - t;
                    int h=Binary(arr, 0, arr.Length - 1, p);

                    if(arr[h]+t==k)
                    {
                        Console.WriteLine(arr[h] + " " + t);
                        break;
                    }
                }
                
                


                

                Console.ReadKey();
            }
        }
    }
}
