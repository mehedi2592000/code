using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1671B_Codeforce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                
                int[] arr = new int[b];
                for (int j = 0; j < b; j++)
                {
                    int w = Convert.ToInt32(Console.ReadLine());
                  
                    arr[j] = w;
                }
                int t = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int p = arr[j + 1] - arr[j];

                    if (p > 3)
                    {
                        Console.WriteLine("NO");
                        t = 1;
                        
                    }

                }
                if(t==0)
                Console.WriteLine("YES");



            }



            Console.ReadKey();
        }
    }
}
