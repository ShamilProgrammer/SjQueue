

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SjQueue.Model
{
    public class EasyDeque<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count; 

        public EasyDeque() { }

        public EasyDeque(T data)
        {
            items.Add(data);
        }

        public void PushBack(T data)
        {
            items.Insert(0, data);
        }

        public void PushFront(T data)
        {
            items.Add(data);
        }

        public T PopBack()
        {
            T item = Tail;
            items.Remove(item);
            return item;
        }

        public T PopFront(T data)
        {
            T item = Head;

            List<T> temp = (((IEnumerable<T>)items).Reverse()).ToList();

            temp.Remove(item);

            items = temp.Reverse<T>().ToList();

            return item;
        }

        public T PeekBack()
        {
            if (Count != 0)
            {
                return Tail;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Count), "Count <= 0");
            }
        }

        public T PeekFront()
        {
            if (Count != 0)
            {
                return Head;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Count), "Count <= 0");
            }
        }
    }
}
