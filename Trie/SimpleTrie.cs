using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Trie
{
    public class SimpleTrie
    {
        public class Node
        {
            public Node[] Children { get; private set; }
            public bool EndOfWord { get; set; }

            public Node()
            {
                // 알파벳 숫자만큼 노드 배열 생성
                Children = new Node[26];
            }
        }

        private Node root = new Node();

        /// <summary>
        /// 새로운 문자열 추가
        /// </summary>
        public void Insert(string str)
        {
            string s = str.ToLower();
            Node node = root;

            foreach (char ch in s)
            {
                int index = ch - 'a'; // 소문자 알파벳은 a~z == 1~26의 값과같음

                if(node.Children[index] == null)
                {
                    node.Children[index] = new Node();
                }

                node = node.Children[index];
            }

            node.EndOfWord = true;
        }

        /// <summary>
        /// 트리에 존재하는지 검색
        /// </summary>
        /// <returns></returns>
        public bool Find(string str)
        {
            string s = str.ToLower();
            Node node = root;

            foreach (char ch in s)
            {
                int index = ch - 'a';

                if(node.Children[index] == null)
                {
                    return false;
                }

                node = node.Children[index];
            }

            return node != null && node.EndOfWord;
        }

    }
}
