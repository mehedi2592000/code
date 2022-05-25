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
        /*
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
        */
        /*
        public static void insertionSort(int[] arr,int n)
        {
            for(int i=1;i<n;i++)
            {
                int q=arr[i];
                int w = i - 1;
                for(int j=w;j>=0;j--)
                {
                    if(arr[j]>q)
                    {
                        int a=arr[j];
                        arr[j]=arr[j+1];
                        arr[j + 1] = a;
                    }
                }
            }

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
        */
        /*
        public static void Sor(int[] arr,int l,int m,int r)
        {
            int q = m - l+1;
            int w = r - m;

            int[] L=new int[q];
            int[] R=new int[w];


            int i ;
            int j ;

            for ( i=0;i<q;i++)
            {
                L[i]=arr[l+i];
            }

            for( i=0;i<w;i++)
            {
                R[i]=arr[m+1+i];
            }
            i = 0;
            j = 0;
            int k = l;
            while(i<q && j<w)
            {
                if(L[i]<=R[j])
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }

            while(i<q)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while(j<w)
            {
                arr[k] = R[j];
                j++;
                k++;
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

        public static void mergeSort(int[] arr,int l,int r)
        {

            if (l < r)
            {
                int m = l + (r - l) / 2;

                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                Sor(arr, l, m, r);
            }

        }
        */
        public static void swap(int[] arr,int i,int j)
        {
            int t=arr[i];
            arr[i]=arr[j];
            arr[j]=t;
        }

        public static int Sot(int[] arr,int l,int r)
        {
            int pivot=arr[r];

            int j = l - 1;

            for(int i=l;i<r;i++)
            {
                if(arr[i] < pivot)
                {
                    j++;
                    swap(arr, i, j);
                }
            }
            swap(arr, j + 1, r);
            return j + 1;
        }

        public static void Quicksort(int[] arr,int l,int r)
        {
            if(l<r)
            {
              int pi=  Sot(arr, l, r);

                Quicksort(arr, l, pi-1);
                Quicksort(arr, pi+1, r);
            }
        }

        public static void print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 1, 16, 4, 20, 25 };
            int n=arr.Length;
            // HeapSort(arr, n);


            //countsort(arr, n);

            //ReadoxSort(arr, n);

            //print(arr, n);

            // insertionSort(arr, n);

            // mergeSort(arr, 0,n-1);

            // print(arr, n);

            Quicksort(arr, 0, n - 1);

             print(arr, n);
        }
    }
}
