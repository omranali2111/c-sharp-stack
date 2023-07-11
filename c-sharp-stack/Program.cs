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




    }
}