
using System;

namespace SjQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyqueue = new Model.EasyQueue<int>();

            easyqueue.Enqueue(1);
            easyqueue.Enqueue(2);
            easyqueue.Enqueue(3);
            easyqueue.Enqueue(4);
            easyqueue.Enqueue(5);


            Console.WriteLine(easyqueue.Dequeue());
            Console.WriteLine(easyqueue.Peek());
            Console.WriteLine(easyqueue.Dequeue());


        }
    }
}
