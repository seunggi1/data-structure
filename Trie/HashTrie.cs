using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Trie
{
    public class HashTrie
    {
        class Node
        {
            public Dictionary<char, Node> Children { get; private set; }
            public bool EndOfWord { get; set; }
            public string Word { get; set; }

            public Node()
            {
                Children = new Dictionary<char, Node>();
            }
        }

        private Node root = new Node();

        public void Insert(string str)
        {

            Node node = root;

            foreach (char ch in str)
            {

                if(!node.Children.ContainsKey(ch))
                {
                    node.Children.Add(ch, new Node());
                }

                node = node.Children[ch];
            }

            node.EndOfWord = true;
            node.Word = str;
        }

        public bool Find(string str)
        {
            Node node = root;

            foreach (char ch in str)
            {

                if (!node.Children.ContainsKey(ch))
                {
                    return false;
                }

                node = node.Children[ch];
            }


            return node != null && node.EndOfWord;
        }

        public List<string> AutoComplete(string str)
        {
            var result = new List<string>();            
            Node node = root;

            //1. Prefix 노드까지 이동
            foreach (char ch in str)
            {
                if(!node.Children.ContainsKey(ch))
                {
                    return result;
                }

                node = node.Children[ch];
            }

            //2. 그 노드 부터 Preorder()를 호출한다
            // result.AddRange(Preorder(node, str));
            Preorder(node, result);
            
            return result;
        }

        private List<string> Preorder(Node node, string prefix)
        {
            if (node == null)
            {
                return null;
            }

            var result = new List<string>();

            //3. Preorder 메서드는 노드가 단어 끝으로 표시된 노드인지 체크해서 리스트에 추가한 후 그 자식 노드들에 대해서 다시 순서대로 Preorder를 재귀 호출한다.            
            if (node.EndOfWord)
            {
                result.Add(prefix);
            }

            foreach (var item in node.Children)
            {
                result.AddRange(Preorder(item.Value, $"{prefix}{item.Key}"));
            }

            return result;
        }

        private void Preorder(Node node, List<string> results)
        {
            if(node == null)
            {
                return;
            }

            if(!string.IsNullOrEmpty(node.Word))
            {
                results.Add(node.Word);
            }

            foreach (char key in node.Children.Keys)
            {
                Preorder(node.Children[key], results);
            }
        }

    }
}
