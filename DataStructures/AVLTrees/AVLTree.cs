using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.AVLTrees
{
    public class AVLTree
    {
        private class Node
        {
            public int val;
            public Node left;
            public Node right;
            public int height;

            public Node(int val)
            {
                this.val = val;
            }

            public override string ToString()
            {
                return "Node=" + val;
            }
        }

        private Node root;

        public void Insert(int val)
        {
            this.root = Insert(this.root, val);
        }

        private Node Insert(Node root, int val)
        {
            if (root == null)
                return new Node(val);

            if (val < root.val)
                root.left = Insert(root.left, val);
            else
                root.right = Insert(root.right, val);

            root.height = Math.Max(Height(root.left), Height(root.right)) + 1;

            return root;
        }

        private bool IsLeaf(Node root)
        {
            return root.left == null && root.right == null ? true : false;
        }

        private int Height(Node root)
        {
            return root == null ? -1 : root.height;
        }
    }
}
