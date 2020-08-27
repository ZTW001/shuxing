using System;
using System.Threading;

namespace MonitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread testthread = new Thread(Add);
                testthread.Start();
            }

            Console.Read();
        }

        // 共享资源
        public static int number = 1;

        public static void Add()
        {
            Thread.Sleep(1000);
            //获得排他锁
            Monitor.Enter(number);

            Console.WriteLine("the current value of number is:{0}", number++);

            // 释放指定对象上的排他锁。
            Monitor.Exit(number);
        }
    }
}