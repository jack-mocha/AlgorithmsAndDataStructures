using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Tree
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            //This is for us to easily see the value on Watch. 
            public override string ToString()
            {
                return "Node=" + value;
            }
        }

        private Node root;

        //There are 2 scenarios
        //[1] When there is no node in the tree, the new node is root.
        //[2] When there is existing node in the tree, find the parent of the new node.
        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if(current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public void InsertRecursive(int value)
        {
            InsertRecursive(root, null, value);
        }

        private void InsertRecursive(Node root, Node parent, int value)
        {
            if(root == null)
            {
                if (parent == null)
                    this.root = new Node(value);
                else if (value < parent.value)
                    parent.leftChild = new Node(value);
                else
                    parent.rightChild = new Node(value);

                return;
            }

            if (value < root.value)
                InsertRecursive(root.leftChild, root, value);
            else
                InsertRecursive(root.rightChild, root, value);
        }

        public void Update()
        {
            Update(root, 0);
        }
        private void Update(Node root, int val)
        {
            if (root == null)
                return;
            else
                root.value = val;

            if (root.leftChild != null)
            {
                var newVal = 2 * val + 1;
                Update(root.leftChild, newVal);
            }
            if(root.rightChild != null)
            {
                var newVal = 2 * val + 2;
                Update(root.rightChild, newVal);
            }
        }

        public bool FindIterative(int value)
        {
            //Iterative
            var current = root;
            while (current != null)
            {
                if (value == current.value)
                    return true;
                if (value < current.value)
                    current = current.leftChild;
                else
                    current = current.rightChild;
            }

            return false;
        }

        //For BST 
        public bool Find(int value)
        {
            return Find(root, value);
        }

        private bool Find(Node root, int target)
        {
            if (root == null)
                return false;

            if (target == root.value)
                return true;

            return Find(root.leftChild, target) || Find(root.rightChild, target);
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder();
        }

        //This is in ascending order.
        //If you want desc order, right, root, left
        private void TraverseInOrder(Node root)
        {
            if (root == null)
                return;

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        //This traverse from the leaf to root
        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null)
                return;

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        public int Depth(int target)
        {
            return Depth(root, target, 0);
        }

        //This works for Binary Tree and BST
        private int Depth(Node root, int target, int depth)
        {
            if (root == null)
                return -1;

            if (target == root.value)
                return depth;

            return Math.Max(Depth(root.leftChild, target, depth + 1), Depth(root.rightChild, target, depth + 1));
        }

        //This only works for BST
        public int BSTDepth(int target)
        {
            return BSTDepth(root, target);
        }

        private int BSTDepth(Node root, int target)
        {
            var depth = 0;
            var current = root;
            while(current != null)
            {
                if (target == current.value)
                    return depth;

                if (target < current.value)
                    current = current.leftChild;
                else
                    current = current.rightChild;

                depth++;
            }

            return -1; 
        }

        //Height of a node is the longest distance between leaf and the node
        //Depth of a node is the distance between root and the node
        public int Height()
        {
            return Height(root);
        }

        private int Height(Node root)
        {
            if (root == null) //When tree is empty.
                return -1;

            if (IsLeaf(root))
                return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        //This is post order traversal, because we are going from the leaf to the root.
        //O(n)
        //Find the min of the left sub tree and find the min of the right sub tree. Then compare them with the root.
        private int Min(Node root)
        {
            if (root == null)
                return Int32.MaxValue;

            if (IsLeaf(root))
                return root.value;

            var left = Min(root.leftChild);
            var right = Min(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value); //This is how to find min among 3 int
        }

        public int Min()
        {
            return Min(root);
        }

        public bool Equals(Tree other)
        {
            if (other == null)
                return false;

            return IsEqual(root, other.root);
        }

        //Pre-order Traversal
        //Compare 2 nodes first and then compare the left and right subtrees.
        private bool IsEqual(Node first, Node second)
        {
            if (first == null && second == null)
                return true;
            
            if(first != null && second != null)
                return first.value == second.value 
                    && IsEqual(first.leftChild, second.leftChild) 
                    && IsEqual(first.rightChild, second.rightChild);

            return false;
        }

        public bool IsBST()
        {
            return IsBST(root, Int32.MinValue, Int32.MaxValue);
        }

        //Pre-Order and makes sure each node is within bound
        private bool IsBST(Node root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.value < min || root.value > max)
                return false;

            return IsBST(root.leftChild, min, root.value - 1) 
                    && IsBST(root.rightChild, root.value + 1, max);
        }

        public List<int> GetNodesAtDistance(int distance)
        {
            var lst = new List<int>();
            GetNodesAtDistance(root, distance, lst);

            return lst;
        }

        //Pre-order and decrement the distance by 1
        private void GetNodesAtDistance(Node root, int distance, List<int> lst)
        {
            if (root == null)
                return;

            if(distance == 0)
            {
                lst.Add(root.value);
                return; //stop at the target
            }

            GetNodesAtDistance(root.leftChild, distance - 1, lst);
            GetNodesAtDistance(root.rightChild, distance - 1, lst);
        }

        public void TraverseLevelOder()
        {
            for(var i = 0; i <= Height(); i++)
            {
                foreach(var l in GetNodesAtDistance(i))
                    Console.WriteLine(l);
            }
        }

        public int Size()
        {
            return Size(root);
        }

        //Size is the amount of nodes in the tree.
        private int Size(Node root)
        {
            if (root == null)
                return 0;

            if (IsLeaf(root))
                return 1;

            return 1 + Size(root.leftChild) + Size(root.rightChild);

        }

        public int CountLeaves()
        {
            return CountLeaves(root);
        }

        private int CountLeaves(Node root)
        {
            if (root == null)
                return 0;

            if (IsLeaf(root))
                return 1;

            return CountLeaves(root.leftChild) + CountLeaves(root.rightChild);
        }

        public int Max()
        {
            if (root == null)
                throw new InvalidOperationException();

            return Max(root);
        }

        private int Max(Node root)
        {
            if (IsLeaf(root))
                return root.value;

            return Max(root.rightChild);
        }

        public bool Contains(int value)
        {
            return Contains(root, value);
        }

        private bool Contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.value == value)
                return true;

            return Contains(root.leftChild, value) || Contains(root.rightChild, value);
        }

        public bool AreSibling(int first, int second)
        {
            return AreSibling(root, first, second);
        }

        private bool AreSibling(Node root, int first, int second)
        {
            if (root == null)
                return false;

            var areSibling = false;
            if(root.leftChild != null && root.rightChild != null)
            {
                areSibling = (root.leftChild.value == first && root.rightChild.value == second)
                        || (root.leftChild.value == second && root.rightChild.value == second);
            }

            return areSibling || AreSibling(root.leftChild, first, second) || AreSibling(root.rightChild, first, second);
        }

        //Greater Sum Tree
        public void BstToGst()
        {
            BstToGst(root, 0);
        }

        private int BstToGst(Node root, int subTotal)
        {
            if (root == null)
                return 0;

            var sum = root.value + BstToGst(root.rightChild, subTotal);

            root.value = sum + subTotal;

            sum += BstToGst(root.leftChild, sum);

            return sum;
        }
    }
}
