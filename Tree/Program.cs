using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node newNode = new Node(15);
            Node newNode1 = new Node(5);
            Node newNode2 = new Node(19);
            Node newNode3 = new Node(1);
            Tree tree = new Tree();
            tree.Add(newNode);
            tree.Add(newNode1);
            tree.Add(newNode2);
            tree.Add(newNode3);
            tree.PreOrder(tree.root);
            tree.BfsTraversal(tree.root);

        }
    }
}
