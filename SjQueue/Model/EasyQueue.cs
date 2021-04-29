

using System;
using System.Collections.Generic;
using System.Linq;

namespace SjQueue.Model
{
    class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public EasyQueue() { }

        public EasyQueue(T data)
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

    }
}
