using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(1);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.PreOrder(tree.root);

        }
    }
}
