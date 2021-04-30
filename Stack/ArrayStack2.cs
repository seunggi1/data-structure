using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class ArrayStack2
    {
        private object[] stack;
        private int top;

        private bool IsEmpty { get { return top == -1; } }

        public ArrayStack2(int capecity = 16)
        {
            stack = new object[capecity];
            top = -1;
        }

        public void Push(object data)
        {
            if(top == stack.Length - 1)
            {
                ResizeStack();
            }

            stack[top++] = data;
        }

        public object Pop()
        {
            if(this.IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            return stack[top--];
        }
        public object Peek()
        {
            if(this.IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            return stack[top];
        }

        private void ResizeStack()
        {
            int capecity = 2 * stack.Length;
            object[] newStack = new object[capecity];
            System.Array.Copy(stack, newStack, stack.Length);
            stack = newStack;
        }
    }
}
