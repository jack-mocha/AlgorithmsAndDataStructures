using DataStructures.AVLTrees;
using System;

namespace DataStructures
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var avlTree = new AVLTree();
            avlTree.Insert(10);
            avlTree.Insert(20);
            avlTree.Insert(30);

            var tree = new Tree();
            var tree2 = new Tree();
            int[] input = { 4, 1, 6, 0, 2, 5, 7, 3, 8 };
            foreach(var i in input)
            {
                tree.InsertRecursive(i);
                tree2.InsertRecursive(i);
            }
            var isEqual = tree.Equals(tree2);
            //tree.Update();
            var isFound = tree.Find(4);
            isFound = tree.Find(1);
            isFound = tree.Find(6);
            isFound = tree.Find(0);
            isFound = tree.Find(2);
            isFound = tree.Find(5);
            isFound = tree.Find(7);
            isFound = tree.Find(3);
            isFound = tree.Find(8);
            isFound = tree.Find(10);
            var min = tree.Min();
            //tree.BstToGst();
            //tree.Insert(7);
            //tree.Insert(4);
            //tree.Insert(1);
            //tree.Insert(6);
            //tree.Insert(9);
            //tree.Insert(8);
            //tree.Insert(10);
            var depth = tree.Depth(99);
            var bstDepth = tree.BSTDepth(2);
            var height = tree.Height();
            var k = tree.GetNodesAtDistance(2);
            tree.TraverseLevelOder();
            var size = tree.Size();
            var leavesCount = tree.CountLeaves();
            var max = tree.Max();
        }
    }
}
