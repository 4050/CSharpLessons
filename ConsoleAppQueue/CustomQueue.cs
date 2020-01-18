using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppQueue
{
       public class CustomQueue<T> : ICustomQueue<T>
        {
            private Node<T> head;
            private Node<T> tail;
            private int count = 0;

            public bool Contains(T value)
            {
                Node<T> currentValue = head;
                while (currentValue != null)
                {
                    if (currentValue.Value.Equals(value))
                    {
                        return true;
                    }

                    currentValue = currentValue.Next;
                }
                return false;
            }

            public T Dequeue()
            {
                if (head == null)
                {
                    throw new Exception("Queue is Empty");
                }

                T result = head.Value;
                head = head.Next;
                count--;
                Console.WriteLine(result);
                return result;
            }

        public void Display()
        {
            Node<T> node = head;
            while (node != null)
            {
                Console.Write("{0}", node.Value);
                if (node.Next == null)
                {
                    return;
                }

                Console.Write("->");
                node = node.Next;
            }
        }

            public void Enqueue(T value)
            {
                Node<T> newNode = new Node<T>(value);
                if (head == null)
                {
                    head = newNode;
                    tail = head;
                }
                else
                {
                    tail.Next = newNode;
                    tail = tail.Next;
                }
                count++;
            }

            public T Peek()
            {
                if (head == null)
                {
                    throw new ArgumentNullException("Can't pop value.");
                }
                T result = head.Value;
                return result;
            }
        }

    }

