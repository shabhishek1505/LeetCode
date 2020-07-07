using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace JobSequencing
{
    class Program
    {
        static void Main(string[] args)
        {
            var job1 = new Input()
            {
                Id = 'a',
                Dead = 2,
                Profit = 100
            };
            var job2 = new Input()
            {
                Id = 'b',
                Dead = 1,
                Profit = 19
            };
            var job3 = new Input()
            {
                Id = 'c',
                Dead = 2,
                Profit = 27
            };
            var job4 = new Input()
            {
                Id = 'd',
                Dead = 1,
                Profit = 25
            };
            var job5 = new Input()
            {
                Id = 'e',
                Dead = 3,
                Profit = 15
            };

            var jobList = new List<Input>();

            jobList.Add(job1);
            jobList.Add(job2);
            jobList.Add(job3);
            jobList.Add(job4);
            jobList.Add(job5);

            PrintJobSceduling(jobList);

            Console.ReadLine();

        }

        static void PrintJobSceduling(List<Input> jobList)
        {

            var newList = jobList.OrderByDescending(x => x.Profit);

            int maxDeadline = jobList.OrderByDescending(x => x.Dead).First().Dead;

            var dsu = new DisjointSet(maxDeadline);

            foreach (var jb in newList)
            {
                int availableSlot = dsu.find(jb.Dead);
                if (availableSlot > 0)
                {
                    dsu.merge((availableSlot - 1), availableSlot);
                    Console.WriteLine(jb.Id);
                }
            }
        }
    }

    public class DisjointSet
    {

        int[] parent;

        // Constructor 
        public DisjointSet(int n)
        {
            parent = new int[n + 1];

            // Every node is a parent of itself 
            for (int i = 0; i <= n; i++)
                parent[i] = i;
        }

        // Path Compression 
        public int find(int s)
        {
            /* Make the parent of the nodes in the path 
               from u--> parent[u] point to parent[u] */
            if (s == parent[s])
                return s;
            return parent[s] = find(s-1);
        }

        // Makes u as parent of v. 
        public void merge(int u, int v)
        {
            //update the greatest available 
            //free slot to u 
            parent[v] = u;
        }
    };

    class Input
    {
        public char Id { get; set; }
        public int Dead { get; set; }
        public int Profit { get; set; }
    }
}
