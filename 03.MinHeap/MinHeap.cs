﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.MinHeap
{
    public class MinHeap<T> : IAbstractHeap<T>
        where T : IComparable<T>
    {
        protected List<T> elements;

        public MinHeap()
        {
            this.elements = new List<T>();
        }

        public int Count => this.elements.Count;

        public void Add(T element)
        {
            
        }

        public T ExtractMin()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
