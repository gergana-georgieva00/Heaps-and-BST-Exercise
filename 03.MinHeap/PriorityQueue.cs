using System;
using System.Collections.Generic;

namespace _03.MinHeap
{
    public class PriorityQueue<T> : MinHeap<T> where T : IComparable<T>
    {
        public PriorityQueue()
        {
            this.elements = new List<T>();
        }

        public void Enqueue(T element)
        {
            this.elements.Add(element);
            this.HeapUp(this.Count - 1);
        }

        private void HeapUp(int v)
        {
            
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public void DecreaseKey(T key)
        {
            var index = this.elements.IndexOf(key);
            HeapUp(index);
        }
    }
}
