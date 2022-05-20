using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforce_1669_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int  a = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                String[] s = Console.ReadLine().Split(' ');
                int[] z=new int[s.Length];
                for(int j = 0; j < b; j++)
                {
                    z[j] = int.Parse(s[j]);
                }
                
                int[] vs = new int[b];

                

                for (int j = 0; j < b; j++)
                {
                    vs[z[j]-1]++;
                    
                }
                int result = -1;
                for (int j = 0; j <b; j++)
                {
                    
                    if(vs[j]>=3)
                    {
                        result = j+1;
                        
                        break;
                    }
                    

                    //Console.WriteLine(vs[j]);
                }
                Console.WriteLine(result);

                Console.ReadKey();


            }
        }
    }
}
