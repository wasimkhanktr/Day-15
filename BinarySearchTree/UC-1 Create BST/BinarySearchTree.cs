using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        Node root = null, temp = null;
        public void insert(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.left = null;
            newNode.right = null;
            Node current = root, prev = null;
            while (current != null)
            {
                prev = current;
                if (value < current.data)
                    current = current.left;
                else
                    current = current.right;
            }
            if (prev == null)
                root = newNode;
            else if (value < prev.data)
                prev.left = newNode;
            else
                prev.right = newNode;
        }
        public void display()
        {
            Console.WriteLine(root.data);
            Console.WriteLine(root.left.data);
            Console.WriteLine(root.right.data);
        }
    }
}