using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单链表
{
    public interface IListDs<T>
    {
        int GetLength();//求长度
        void Clear();//清空操作
        bool IsEmpty();//判断线性表是否为空
        void Append(T item);//附加操作
        void Insert(T item, int i);//插入操作
        T Delete(int i);//删除操作
        T GetElem(int i);//取表元
        int Locate(T value);//按值查找
    }
}