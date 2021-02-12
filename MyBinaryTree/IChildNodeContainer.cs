using System;
using System.Collections.Generic;
using System.Text;

namespace MyBinaryTree
{
    interface IChildNodeContainer
    {
        public void CreateChild(int key, string value, bool isLeft);

        public BinaryTreeNode GetChild(bool isLeft);

        public void SetChild(BinaryTreeNode newChild, bool isLeft);

        public bool HasKey();

        public int GetKey();
    }
}
