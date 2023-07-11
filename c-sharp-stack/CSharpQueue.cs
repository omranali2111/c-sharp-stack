using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack
{
    internal class CSharpQueue
    {
        int front, rear;
        private int[] queue;
        int qu;

        public CSharpQueue(int qu)
        {
            this.qu = qu;
            this.queue = new int[qu];
            front = 0;
            rear = 0;
        }
        public void Enqueue(int data)
        {

            if (rear>=qu)
            {
                Console.WriteLine("Queue is full");
                return;
            }
           
             else
            {
               
                queue[rear] = data;
                rear++;
               
            }
            return;


        }
        public void Dequeue()
        {
           
            if (front==rear)
            {
                Console.Write("Queue is empty");
                return;
            }

            
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

               
                if (rear < qu)
                    queue[rear--] = 0;
            }
            return;
        }
        public void Peek()
        {
            if (front==rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
                Console.WriteLine($"The top element of Stack is :{queue[front]}");

        }
        

            public void queueDisplay()
        {
            int i;
            if (front==rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            Console.WriteLine("Items in the Queue are :");
            for (i = front; i < rear; i++)
            {
                Console.WriteLine( queue[i]);
            }
            return;
        }
    }
}
