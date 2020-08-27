using System;
using System.Collections.Generic;
using System.Threading;

namespace ReaderWriterLockSample
{
    class Program
    {
        public static List<int> lists = new List<int>();

        // 创建一个对象
        public static ReaderWriterLock readerwritelock = new ReaderWriterLock();
        static void Main(string[] args)
        {
            //创建一个线程读取数据
            Thread t1 = new Thread(Write);
            t1.Start();
            // 创建10个线程读取数据
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Read);
                t.Start();
            }

            Console.Read();

        }

        // 写入方法
        public static void Write()
        {
            // 获取写入锁，以10毫秒为超时。
            readerwritelock.AcquireWriterLock(10);
            Random ran = new Random();
            int count = ran.Next(1, 10);
            lists.Add(count);
            Console.WriteLine("Write the data is:" + count);
            // 释放写入锁
            readerwritelock.ReleaseWriterLock();
        }

        // 读取方法
        public static void Read()
        {
            // 获取读取锁
            readerwritelock.AcquireReaderLock(10);

            foreach (int li in lists)
            {
                // 输出读取的数据
                Console.WriteLine(li);
            }

            // 释放读取锁
            readerwritelock.ReleaseReaderLock();
        }
    }
}