

using System;
using System.Linq;

namespace SjQueue.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;
        private T Head => items[Count - 1];
        private T Tail => items[0];
        public int Count { get; private set; }



    }
}
