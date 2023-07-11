using c_sharp_stack;

internal class Program
{
    private static void Main(string[] args)
    {
        CSharpStack stack1 = new CSharpStack();
        
        stack1.Push(10);
        stack1.Push(20);
        stack1.Push(30);
       
        stack1.PrintStack();
        stack1.Peek();
        stack1.Pop();
        Console.WriteLine("this is after pop:");
        stack1.PrintStack();

        Console.WriteLine("*************************************");
        CSharpQueue q1=new CSharpQueue(4);
        q1.Enqueue(10);
        q1.Enqueue(20);
        q1.Enqueue(30);
        q1.Enqueue(40);
        q1.Enqueue(50);
        q1.queueDisplay();
        q1.Peek();
        q1.Dequeue();
        q1.Dequeue();
        Console.WriteLine("after Dequeue:");
        q1.queueDisplay();












    }
}