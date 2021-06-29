using System;
using System.Collections;
using DataStructure.Array;
using DataStructure.BinaryTree;
using DataStructure.LinkedList;
using DataStructure.Queue;
using DataStructure.Stack;
using DataStructure.Tree;
using DataStructure.Heap;
using DataStructure.Trie;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var sTrie = new HashTrie();

            sTrie.Insert("프로");
            sTrie.Insert("프로그래밍");
            sTrie.Insert("프로그램");
            sTrie.Insert("안녕하신가요");
            sTrie.Insert("안녕하신가");

            bool find = sTrie.Find("프로그래밍");
            Console.WriteLine($"프로그래밍 : {find}");
            find = sTrie.Find("프로그램램");
            Console.WriteLine($"프로그램램 : {find}");

            find = sTrie.Find("안녕하");
            Console.WriteLine($"안녕하 : {find}");


            var autoCompletes = sTrie.AutoComplete("프");

            foreach (var text in autoCompletes)
            {
                Console.WriteLine($"{text}");
            }
        }
    }
}
