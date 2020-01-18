using System;

namespace ConsoleAppQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
        }
    }
}
