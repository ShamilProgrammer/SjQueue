
using System;

namespace SjQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //var easyqueue = new Model.EasyQueue<int>();

            //easyqueue.Enqueue(1);
            //easyqueue.Enqueue(2);
            //easyqueue.Enqueue(3);
            //easyqueue.Enqueue(4);
            //easyqueue.Enqueue(5);


            //Console.WriteLine(easyqueue.Dequeue());
            //Console.WriteLine(easyqueue.Peek());
            //Console.WriteLine(easyqueue.Dequeue());

            // OTHER 


            //var arrayqueue = new Model.ArrayQueque<int>();

            //arrayqueue.Enqueue(1);
            //arrayqueue.Enqueue(2);
            //arrayqueue.Enqueue(3);
            //arrayqueue.Enqueue(4);
            //arrayqueue.Enqueue(5);


            //Console.WriteLine(arrayqueue.Dequeue());
            //Console.WriteLine(arrayqueue.Peek());
            //Console.WriteLine(arrayqueue.Dequeue());


            // OTHER 


            //var linkedqueue = new Model.LinkedQueue<int>();

            //linkedqueue.Enqueue(5);


            //Console.WriteLine(linkedqueue.Dequeue());
            //Console.WriteLine(linkedqueue.Peek());
            //Console.WriteLine(linkedqueue.Dequeue());


            // OTHER 


            //var easyDeque = new Model.EasyDeque<int>();

            //easyDeque.PushFront(1);
            //easyDeque.PushFront(1);
            //easyDeque.PushFront(2);
            //easyDeque.PushFront(3);
            //easyDeque.PushFront(1);



            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopFront());


            //Console.ReadLine();

            // OTHER 

            // OTHER 


            var duplexDeque = new Model.DuplexLinkedDeque<int>();

            duplexDeque.PushFront(1);
            duplexDeque.PushFront(2);
            duplexDeque.PushFront(3);
            duplexDeque.PushBack(4);
            duplexDeque.PushBack(5);

            Console.WriteLine(duplexDeque.PopFront()); 
            Console.WriteLine(duplexDeque.PopFront());
            Console.WriteLine(duplexDeque.PopBack());
            Console.WriteLine(duplexDeque.PopBack());
            Console.WriteLine(duplexDeque.PopFront());
            Console.WriteLine(duplexDeque.PopFront());


            Console.ReadLine();

        }
    }
}
