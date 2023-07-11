using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack
{
    internal class CSharpStack
    {
        int top;
        int[] stack = new int[10];
        bool IsEmpty()
        {
            return (top < 0);
        }
        public CSharpStack()
        {
            top = -1;
        }
        public  bool Push(int data)
        {
            if (top >= 10)
            {
                Console.WriteLine("Stack is full");
                return false;
            }
            else
            {
                top++;
                stack[top] = data;
                return true;
            }
        }
       public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                top--;
                int value = stack[top];
                return value;
            }
        }
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
                Console.WriteLine($"The top element of Stack is :{stack[top]}");
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack empty");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
