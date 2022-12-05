namespace _02.LowestCommonAncestor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryTree<T> : IAbstractBinaryTree<T>
        where T : IComparable<T>
    {
        public BinaryTree(
            T value,
            BinaryTree<T> leftChild,
            BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
            if (leftChild != null)
            {
                this.LeftChild.Parent = this;
            }

            if (rightChild != null)
            {
                this.RightChild.Parent = this;
            }
        }

        public T Value { get; set; }

        public BinaryTree<T> LeftChild { get; set; }

        public BinaryTree<T> RightChild { get; set; }

        public BinaryTree<T> Parent { get; set; }

        public T FindLowestCommonAncestor(T first, T second)
        {
            BinaryTree<T> firstNode = this.FindBfs(first, this);
            BinaryTree<T> secondNode = this.FindBfs(second, this);

            if (firstNode is null || secondNode is null)
            {
                throw new InvalidOperationException();
            }

            var firstNodeAncestors = this.FindAncestors(firstNode);
            var secondNodeAncestors = this.FindAncestors(secondNode);
        }

        private Queue<T> FindAncestors(BinaryTree<T> firstNode)
        {
            throw new NotImplementedException();
        }

        private BinaryTree<T> FindBfs(T first, BinaryTree<T> binaryTree)
        {
            throw new NotImplementedException();
        }
    }
}
