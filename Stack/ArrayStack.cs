using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class ArrayStack
    {
        private object[] stack;
        private int top;

        public ArrayStack(int stackSize = 16)
        {
            stack = new object[stackSize];
            top = -1;
        }

        public void Push(object data)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }

            top++;
            stack[top] = data;
        }

        public object Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is empty");

                return null;
            }

            var result = stack[top];
            stack[top] = null;
            top--;

            return result;
        }

        public object Peek()
        {
            if(top <= -1)
            {
                Console.WriteLine("Stack is empty");

                return null;
            }

            return stack[top];
        }

    }
}
