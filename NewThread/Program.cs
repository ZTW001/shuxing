using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NewThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始");
            //IsBackground=true，将其设置为后台线程
            Thread t = new Thread(Run) { IsBackground = true };
            t.Start();
            Console.WriteLine("主线程在做其他的事！");
            //主线程结束，后台线程会自动结束，不管有没有执行完成
            //Thread.Sleep(300);
            Thread.Sleep(1500);
            Console.WriteLine("主线程结束");
        }
        static void Run()
        {
            Thread.Sleep(700);
            Console.WriteLine("这是后台线程调用");
        }
    }
}
