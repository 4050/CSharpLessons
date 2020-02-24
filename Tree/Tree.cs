using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node root;
        public void Add(Node node)
        {
            Node newNode = new Node(node.Value);
            newNode.Value = node.Value;

            Node parent = null;
            Node child = root;

            while (child != null)
            {
                parent = child;
                if (node.Value < child.Value)
                {
                    child = child.Left;
                }
                else if (node.Value > child.Value)
                {
                    child = child.Right;
                }
            }

            if (root == null)
            {
                root = newNode;
            }
            else if (node.Value < parent.Value )
            {
                parent.Left = newNode;
            }
            else if (node.Value > parent.Value)
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

        public void BfsTraversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.Value + " ");

                if (node.Left != null) 
                {
                    q.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }

        }
    }
}
