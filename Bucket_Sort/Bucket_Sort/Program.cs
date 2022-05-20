using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket_Sort
{
    internal class Program
    {
         static void backetsort(float[] arr,int n)
        {
            if(n<=0)
            {
                return;
            }

                List<float>[] buckets = new List<float>[n];
            for(int i=0;i<n;i++)
            {
                buckets[i]= new List<float>();
            }

            for(int i=0;i<n;i++)
            {
                float idx = arr[i] * n;
                    buckets[(int)idx].Add(arr[i]);  

            }

            for(int i=0;i<n;i++)
            {
                buckets[i].Sort();
            }
            int index = 0;

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<buckets[i].Count;j++)
                {
                    arr[index++]=buckets[i][j];
                }
            }
        }
        
        static void Main(string[] args)
        {
            float[] arr = { (float)0.78, (float)0.17, (float)0.39, (float)0.26, (float)0.72, (float)0.97, (float)0.21, (float)0.12 };
            
            int n=arr.Length;

            backetsort(arr, n);

            Console.WriteLine("ok output");

            foreach(float i in arr)
            {
                Console.WriteLine(i+" ");
            }

            Console.ReadKey();
        }
    }
}
