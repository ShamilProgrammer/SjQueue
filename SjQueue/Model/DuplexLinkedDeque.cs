

using System;

namespace SjQueue.Model
{
    public class DuplexLinkedDeque<T>
    {
        private DuplexItem<T> head;
        
        private DuplexItem<T> tail;
        public int Count { get; set; }

        public DuplexLinkedDeque() { }

        public DuplexLinkedDeque(T data)
        {
            SetDefaultData(data);
        }

        public void PushBack(T data)
        {
            if(Count == 0)
            {
                SetDefaultData(data);
            }
            else
            {
                DuplexItem<T> item = new DuplexItem<T>(data);
                item.Next = tail;
                tail.Previous = item;
                tail = item;
                Count++;
            }
        }

        public void PushFront(T data)
        {
            if(Count == 0)
            {
                SetDefaultData(data);
            }
            else
            {
                DuplexItem<T> item = new DuplexItem<T>(data);
                item.Previous = head;
                head.Next = item;
                head = item;
                Count++;
            }
        }

        public T PopBack()
        {
            if(Count > 0)
            {
                T result = tail.Data;

                var current = tail?.Next;

                if (current != null)
                {
                    current.Previous = null;
                    tail = current;
                    Count--;
                }
                else
                {
                    tail = null;
                    head = null;
                    Count = 0;
                }

                return result;
            }
            else throw new ArgumentOutOfRangeException(nameof(Count), "Count <= 0");
        }

        public T PopFront()
        {
            if(Count > 0)
            {
                T result = head.Data;

                DuplexItem<T> current = head?.Previous;

                if(current != null)
                {
                    current.Next = null;
                    head = current;
                    Count--;
                }
                else
                {
                    tail = null;
                    head = null;
                    Count = 0;
                }
                return result;
            }
            else throw new ArgumentOutOfRangeException(nameof(Count), "Count <= 0");
        }

        public T PeekBack()
        {
            if (Count != 0)
            {
                return tail.Data;
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
                return head.Data;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Count), "Count <= 0");
            }
        }

        private void SetDefaultData(T data)
        {
            DuplexItem<T> item = new DuplexItem<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }
    }
}
