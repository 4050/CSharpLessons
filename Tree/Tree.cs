using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node root
        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            Node parent = null;
            Node child = root;

            while (child != null)
            {
                parent = child;
                if (value < child.Value)
                {
                    child = child.Left;
                }
                else if (value > child.Value)
                {
                    child = child.Right;
                }
            }

            if (root == null)
            {
                root = newNode;
            }
            else if (value < parent.Value )
            {
                parent.Left = newNode;
            }
            else if (value > parent.Value)
            {
                parent.Right = newNode;
            }
        }

        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }
    }
}
