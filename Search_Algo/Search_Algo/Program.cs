using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algo
{
    internal class Program
    {
        public static void addEdge(LinkedList<int>[] adj,int u,int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }

        public static void printgraph(LinkedList<int>[] adj)
        {
            for(int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("root"+adj[i]);

                foreach(int v in adj[i])
                {
                    Console.WriteLine(v);
                }
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int v = 5;
            LinkedList<int>[] adj=new LinkedList<int>[v];

            for(int i = 0; i < v; i++)
            {
                adj[i]=new LinkedList<int>();
            }

            addEdge(adj, 0, 1);
            addEdge(adj, 0, 4);
            addEdge(adj, 1, 2);
            addEdge(adj, 1, 3);
            addEdge(adj, 1, 4);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 4);

            printgraph(adj);
        }
    }
}
