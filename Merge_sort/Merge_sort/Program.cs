using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    internal class Program
    {
        void Sorte(int[] arr,int l,int m,int r)
        {
            int n1 = m-l+1;
            int n2 = r - m;
            int i, j;

            int[] L=new int[n1];
            int[] R=new int[n2];

            for(i=0;i<n1;i++)
            {
                L[i]=arr[i+l];
            }

            for( j=0;j<n2;j++)
            {
                R[j]=arr[j+m+1];
            }

            i=0;
            j = 0;

            int k = l;

            while(i<n1 && j<n2)
            {
                if(L[i]<=R[j])
                {
                    arr[k]=L[i];
                    i++;
                }
                else
                {
                    arr[k]=R[j];
                    j++;
                }
                k++;
            }

            while(i<n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while(j<n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }



        }
        
         void Merge(int[] arr,int l,int r)
        {
            if(l<r)
            {
                int m=l+(r-l)/2;

                Merge(arr,l,m);
                Merge(arr,m+1,r);

                Sorte(arr, l, m, r);

            }
        }

        void print(int[] arr,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);  
            }
            Console.ReadLine(); 
        }

        static void Main(string[] args)
        {

            int[] arr = { 12, 11, 13, 5, 6, 5, 17, 200 };
            int n=arr.Length;
            Program p = new Program();


           p. Merge(arr,0, arr.Length - 1);
            p.print(arr, n);

            
        }
        


    }
        
}
