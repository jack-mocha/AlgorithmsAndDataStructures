﻿using System;
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

        public bool Find(int value)
        {
            var current = root;
            while(current != null)
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

    }
}