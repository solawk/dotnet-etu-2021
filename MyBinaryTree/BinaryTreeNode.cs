using System;
using System.Collections.Generic;
using System.Text;

namespace MyBinaryTree
{
    class BinaryTreeNode : IChildNodeContainer
    {
        private int _key;
        private string _value;

        private BinaryTreeNode _leftChild;
        private BinaryTreeNode _rightChild;

        private IChildNodeContainer _parent;

        public BinaryTreeNode(int key, string value, IChildNodeContainer parent)
        {
            _key = key;
            _value = value;

            _leftChild = null;
            _rightChild = null;

            _parent = parent;
        }

        public void CreateChild(int key, string value, bool isLeft)
        {
            if (isLeft)
            {
                _leftChild = new BinaryTreeNode(key, value, this);
            }
            else
            {
                _rightChild = new BinaryTreeNode(key, value, this);
            }
        }

        public bool HasKey()
        {
            return true;
        }

        public int GetKey()
        {
            return _key;
        }

        public void SetKey(int newKey)
        {
            _key = newKey;
        }

        public string GetValue()
        {
            return _value;
        }

        public void SetValue(string newValue)
        {
            _value = newValue;
        }

        public BinaryTreeNode GetChild(bool isLeft)
        {
            if (isLeft) return _leftChild;
            return _rightChild;
        }

        public void SetChild(BinaryTreeNode newChild, bool isLeft)
        {
            if (isLeft) _leftChild = newChild;
            else _rightChild = newChild;
        }

        public IChildNodeContainer GetParent()
        {
            return _parent;
        }

        public void SetParent(IChildNodeContainer newParent)
        {
            _parent = newParent;
        }

        private void PrintShift(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
        }

        public void Print(int depth)
        {
            PrintShift(depth);
            Console.WriteLine("Key: " + _key + ", Value: " + _value);

            PrintShift(depth);
            if (_parent.HasKey()) Console.WriteLine("Parent key: " + _parent.GetKey());

            PrintShift(depth);
            Console.WriteLine("{");

            if (_leftChild != null)
            {
                PrintShift(depth + 1);
                Console.WriteLine("Left:");
                _leftChild.Print(depth + 1);
            }

            if (_rightChild != null)
            {
                PrintShift(depth + 1);
                Console.WriteLine("Right:");
                _rightChild.Print(depth + 1);
            }

            PrintShift(depth);
            Console.WriteLine("}");
        }

        public void Add(int key, string value)
        {
            if (key == _key)
            {
                SetValue(value);
                return;
            }

            if (key < _key)
            {
                if (_leftChild != null)
                {
                    _leftChild.Add(key, value);
                }
                else
                {
                    CreateChild(key, value, true);
                }
            }
            else
            {
                if (_rightChild != null)
                {
                    _rightChild.Add(key, value);
                }
                else
                {
                    CreateChild(key, value, false);
                }
            }
        }

        public BinaryTreeNode Search(int key)
        {
            if (key == _key)
            {
                return this;
            }

            if (key < _key)
            {
                return _leftChild?.Search(key);
            }
            
            return _rightChild?.Search(key);
        }

        private void CopyFrom(BinaryTreeNode node)
        {
            SetKey(node.GetKey());
            SetValue(node.GetValue());
            SetChild(node.GetChild(true), true);
            SetChild(node.GetChild(false), false);
        }

        public void Remove(int key)
        {
            if (key < _key)
            {
                _leftChild?.Remove(key);
                return;
            }

            if (key > _key)
            {
                _rightChild?.Remove(key);
                return;
            }

            bool isThisALeftChild = this == _parent.GetChild(true);

            // No children case
            if (GetChild(true) == null && GetChild(false) == null)
            {
                Console.WriteLine("No children case");

                if (isThisALeftChild)
                {
                    _parent.SetChild(null, true);
                }
                else
                {
                    _parent.SetChild(null, false);
                }

                return;
            }

            // One child case
            Console.WriteLine("One child case");

            if (GetChild(true) != null)
            {
                _parent.SetChild(GetChild(true), isThisALeftChild);
                GetChild(true).SetParent(_parent);
                return;
            }

            if (GetChild(false) != null)
            {
                _parent.SetChild(GetChild(false), isThisALeftChild);
                GetChild(false).SetParent(_parent);
                return;
            }

            // Both children case
        }
    }
}
