using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchSuggestions
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new List<string>() { "mobile", "mouse", "moneypot", "monitor", "mousepad" };

            var data = CreateData(input);

            var inp = "mon";


            IList<IList<string>> outList = new List<IList<string>>();
            int count = 1;
            while (inp.Length >= count)
            {
                var ss = SearchNode(data, inp.Substring(0, count));

                outList.Add(GetAllWOrds(ss, new List<string>()).OrderBy(x=>x).Take(3).ToList());
                count++;
            }

        
        }


        public static List<string> GetAllWOrds(Trie searchNode, List<string> outData)
        {
            if (searchNode.IsWord)
                outData.Add(searchNode.word);
            foreach (var node in searchNode.nodes)
            {
                GetAllWOrds(node, outData);
            }

            return outData;
        }



        public static Trie CreateData(List<string> list)
        {
            Trie data = new Trie() { nodes = new List<Trie>() };
            foreach (string word in list)
            {
                data = Iterator(data, word, word);
            }

            return data;
        }

        public static Trie SearchNode(Trie node, string word)
        {
            if (node.value == word.ToCharArray().FirstOrDefault() && word.Length == 1)
                return node;

            if (node.value == word.ToCharArray().FirstOrDefault())
            {
                foreach (var child in node.nodes)
                {
                    var ss = SearchNode(child, word.Substring(1));
                    if (ss != null)
                        return ss;
                }
            }

            return null;
        }


        public static Trie Iterator(Trie root, string word, string iteratingWord)
        {
            var gr = InsertData(root, iteratingWord.ToCharArray().FirstOrDefault());
            if (iteratingWord.Length == 1)
            {
                gr.word = word;
                gr.IsWord = true;
                return gr;
            }
            Iterator(gr, word, iteratingWord.Substring(1));
            return gr;

        }





        public static Trie InsertData(Trie data, char ch)
        {
            if (data.value == null || data.value == ch)
            {
                data.value = ch;
                return data;
            }

            if (data.nodes.Any())
            {
                foreach (var item in data.nodes)
                {
                    if (item.value == ch)
                    {
                        return item;
                    }
                }
            }

            var newNode = new Trie() { value = ch, nodes = new List<Trie>() };
            data.nodes.Add(newNode);
            return newNode;
        }
    }




    public class Trie
    {
        public char? value { get; set; }
        public bool IsWord { get; set; }
        public string word { get; set; }
        public List<Trie> nodes { get; set; }
    }
}
