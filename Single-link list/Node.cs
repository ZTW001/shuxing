using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表
{
    public class Node<T>
    {
        private T data;//数据域
        private Node<T> next;//引用域
        //构造器
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }
        //构造器
        public Node(Node<T> p)
        {
            next = p;
        }
        //构造器
        public Node(T val)
        {
            data = val;
        }
        //构造器
        public Node()
        {
            data = default(T);
            next = null;
        }
        //数据域属性
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        //引用域属性
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
}