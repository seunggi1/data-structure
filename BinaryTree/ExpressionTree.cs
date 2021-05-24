using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    public class ExpressionTree
    {
        public BinaryNode<string> Root { get; set; }

        public void Build(string[] tokens)
        {
            int index = tokens.Length - 1;
            Root = Build(tokens, ref index);
        }

        private BinaryNode<string> Build(string[] tokens, ref int index)
        {
            var node = new BinaryNode<string>(tokens[index]);

            if(tokens[index] == "+" || tokens[index] == "-" || tokens[index] == "*" || tokens[index] == "/")
            {
                // 오른쪽 서브트리 Build
                --index;
                node.Right = Build(tokens, ref index);

                // 왼쪽 서브트리 Build
                --index;
                node.Left = Build(tokens, ref index);
            }

            // 연산자 혹은 피연산자 노드 리턴
            return node;
        }

        public decimal Evaludate(BinaryNode<string> root)
        {
            if (root == null)
            {
                return 0;
            }

            decimal left = Evaludate(root.Left);

            decimal right = Evaludate(root.Right);

            if(root.Data == "+")
            {
                return left + right;
            } else if(root.Data == "-")
            {
                return left - right;
            }else if(root.Data == "/")
            {
                return left / right;
            } else if(root.Data == "*")
            {
                return left / right;
            }

            return decimal.Parse(root.Data);
        }

        public void Inorder(BinaryNode<string> node)
        {
            if(node == null)
            {
                return;
            }

            if (IsOperator(node.Data))
            {
                Console.Write("(");
            }

            Inorder(node.Left);
            Console.Write($"{node.Data} ");
            Inorder(node.Right);

            if(IsOperator(node.Data))
            {
                Console.Write(")");
            }
        }

        public void Postorder(BinaryNode<string> node)
        {
            if(node == null)
            {
                return;
            }

            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write($"{node.Data} ");
        }

        private string[] op = { "+", "-", "/", "*" };
        private bool IsOperator(string token)
        {
            return op.Contains(token);
        }

    }
}
