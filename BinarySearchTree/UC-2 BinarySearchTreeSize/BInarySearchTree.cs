using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public Node root = null;
        public int size = 0;
        public void insert(int value)
        {
            size++;
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
        public void Display(Node root)
        {
            if (root == null)
                return;
            Display(root.left);
            Console.WriteLine(root.data);
            Display(root.right);
        }
        public void display()
        {
            Display(root);
        }
    }
}