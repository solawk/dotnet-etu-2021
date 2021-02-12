using System;
using System.Collections.Generic;
using System.Text;

namespace MyBinaryTree
{
    class BinaryTreeNode
    {
        private int _value;
        private int _key;

        private BinaryTreeNode _leftChild;
        private BinaryTreeNode _rightChild;

        public BinaryTreeNode(int value, int key)
        {
            _value = value;
            _key = key;

            _leftChild = null;
            _rightChild = null;
        }

        public void CreateChild(int value, int key, bool isLeft)
        {
            if (isLeft)
            {
                _leftChild = new BinaryTreeNode(value, key);
            }
            else
            {
                _rightChild = new BinaryTreeNode(value, key);
            }
        }

        public int GetValue()
        {
            return _value;
        }

        public void SetValue(int newValue)
        {
            _value = newValue;
        }
    }
}
