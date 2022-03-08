using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(56);
            tree.insert(30);
            tree.insert(76);
            tree.insert(45);
            tree.insert(96);
            tree.display();
            Console.WriteLine("Size of tree is " + tree.size);
        }
    }
}