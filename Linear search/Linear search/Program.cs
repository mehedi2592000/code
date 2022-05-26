using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_search
{
    internal class Program
    {
        public static void Line(int[] arr,int n,int s)
        {
            int left = 0;
            int right = n-1;
            int position = -1;
            for(left=0; left <= right;)
            {
                if(arr[left] == s)
                {
                    position= left;
                    Console.WriteLine(left + " " + arr[left]);
                    break;
                }

                if(arr[right] == s)
                {
                    position = right;
                    Console.WriteLine(right + " " + arr[right]);
                    break;
                }
                left++;
                right--;

            }
            if (position == -1)
                Console.WriteLine(-1);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 8, 9, 15, 4, 3 };
            int n=arr.Length;
            int s = 9;

            Line(arr, n, s);

        }
    }
}
