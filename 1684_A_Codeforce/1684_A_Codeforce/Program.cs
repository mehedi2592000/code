using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1684_A_Codeforce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<q;i++)
            {
                string w=Console.ReadLine();
                
                
                    Console.WriteLine(w.Min(x=>x));
                
            }
            Console.ReadKey();
        }
    }
}
