
using System;

namespace SjQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyqeue = new Model.EasyQueue<int>();

            easyqeue.Enqueue(10);
            easyqeue.Enqueue(40);
        }
    }
}
