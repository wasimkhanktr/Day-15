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
        public void Display(Node root1)
        {
            if (root1 == null)
                return;
            Display(root1.left);
            Console.WriteLine(root1.data);
            Display(root1.right);
        }
        public void display()
        {
            Node root1 = root;
            Display(root1);
        }
        public int Search(Node temp, int value)
        {
            if (temp == null)
                return 0;
            else if (temp.data == value)
                return 1;
            else if (temp.data < value)
                return Search(temp.right, value);
            else
                return Search(temp.left, value);
        }
        public int search(int value)
        {
            Node temp = root;
            return Search(temp, value);
        }
    }
}