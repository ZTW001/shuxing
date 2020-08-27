using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> link = new LinkList<string>();
            link.Append("123");
            link.Append("567");
            link.Append("jqk");
            link.Insert("abc", 2);
            link.InsertPost("def", 2);
            int length = link.GetLength();
            int k = link.Locate("567");
            string m = link.GetElem(3);
            Console.WriteLine("567的位置为" + k);
            Console.WriteLine("位置为3的值为" + m);
            Console.WriteLine("链表的长度为" + length);
            Node<string> n = link.Head;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next;
            }
        }
    }
}
