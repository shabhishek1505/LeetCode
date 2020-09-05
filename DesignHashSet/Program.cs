using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignHashSet
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class MyHashSet
    {
        ArrayList arrayList = new ArrayList();

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(null);
            }
        }

        public void Add(int key)
        {



        }

        public void Remove(int key)
        {

        }

        /** Returns true if this set contains the specified element */
        //public bool Contains(int key)
        //{

        //}

        //private 
    }

    public class HashNode
    {
        private int Value { get; set; }
        public HashNode Next { get; set; }

        public HashNode(int value)
        {
            Value = value;
        }
    }
}
