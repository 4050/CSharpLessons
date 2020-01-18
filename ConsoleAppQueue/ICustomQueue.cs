using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppQueue
{
    public interface ICustomQueue<T>
    {
        void Enqueue(T value);
        T Dequeue();
        bool Contains(T value);
        void Display();
        T Peek();
    }
}
