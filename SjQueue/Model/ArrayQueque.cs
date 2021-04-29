

using System;
using System.Collections.Generic;
using System.Linq;

namespace SjQueue.Model
{
    class ArrayQueque<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public ArrayQueque() { }

        public ArrayQueque(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            List<T> result = new List<T>();

            result.Add(data);

            foreach(T item in items)
            {
                result.Add(item);
            }

            items = result;
        }

        public T Dequeue()
        {
            if (Count != 0)
            {
                var item = Head;
                items.Remove(item);
                return item;
            }
            else throw new NullReferenceException("Collection is empty");
        }

        public T Peek()
        {
            return Head;
        }

    }
}
