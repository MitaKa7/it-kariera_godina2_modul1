using Stack2024;
using System.Globalization;

MyStack<int> stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

foreach (int item in stack)
{
    Console.WriteLine(item);
}

stack.Pop();

foreach (int item in stack)
{
    Console.WriteLine(item);
}
