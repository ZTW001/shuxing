using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Semaphore
{
    class Program
    {
        static SemaphoreSlim semLim = new SemaphoreSlim(3); //3表示最多只能有三个线程同时访问
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(SemaphoreTest).Start();
            }
            Console.Read();
        }
        static void SemaphoreTest()
        {
            semLim.Wait();
            Console.WriteLine("线程" + Thread.CurrentThread.ManagedThreadId.ToString() + "开始执行");
            Thread.Sleep(2000);
            Console.WriteLine("线程" + Thread.CurrentThread.ManagedThreadId.ToString() + "执行完毕");
            semLim.Release();
        }
    }
}
