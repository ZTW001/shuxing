using System;
using System.Diagnostics;
using System.Threading;

namespace InterlockedSample
{
    // 比较使用锁和不使用锁锁消耗的时间
    // 通过时间来说明使用锁性能的影响
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
            Console.WriteLine("the current value of number is:{0}", ++number);
        }
    }
}