using System;
using System.Collections.Generic;
using System.Text;

namespace MyBinaryTree
{
    class BinaryTree : IChildNodeContainer
    {
        private BinaryTreeNode _root;

        public BinaryTree()
        {
            _root = null;
        }

        public void Add(int key, string value)
        {
            if (_root == null)
            {
                _root = new BinaryTreeNode(key, value, this);
            }
            else
            {
                _root.Add(key, value);
            }
        }

        public void Search(int key)
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            BinaryTreeNode targetNode = _root.Search(key);

            if (targetNode == null)
            {
                Console.WriteLine("Search failed");
                return;
            }

            Console.WriteLine("Value found: " + targetNode.GetValue());
        }

        public void Remove(int key)
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }

            if (_root.Search(key) == null)
            {
                Console.WriteLine("No node with this key!");
                return;
            }

            _root.Remove(key);
        }

        public void Print()
        {
            Console.WriteLine("Tree:");
            _root?.Print(0);
        }

        public void CreateChild(int key, string value, bool isLeft)
        {
            _root = new BinaryTreeNode(key, value, null);
        }

        public BinaryTreeNode GetChild(bool isLeft)
        {
            return _root;
        }

        public void SetChild(BinaryTreeNode newChild, bool isLeft)
        {
            _root = newChild;
        }

        public bool HasKey()
        {
            return false;
        }

        public int GetKey()
        {
            return -1;
        }
    }
}
