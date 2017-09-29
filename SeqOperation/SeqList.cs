using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqOperation
{
    class SeqList<T> : IListDS<T>
    {
        private T[] data;
        private int count;

        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }

        public SeqList() : this(10)
        {

        }

        public int GetLength()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// 判断线性表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// 在线性表中添加数据
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Add(T item)
        {
            if (count == data.Length)
                Console.WriteLine("数组已满！！！");
            else
            {
                data[count] = item;
                count++;
            }
        }

        /// <summary>
        /// 在顺序表中插入数据
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void Insert(T item, int index)
        {
            if (index < 0 || index >= count)
                Console.WriteLine("插入位置不合法！！！");
            else
            {
                for (int i =count-1; i <=index; i--)
                {
                    data[i+1] = data[i];
                }
                data[index] = item;
               
            }
            //Console.WriteLine(count);
        }

        /// <summary>
        /// 删除顺序表中的元素
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index)
        {
            if (index > 0 && index < count)
            {
                T temp = data[index];
                for (int i = index; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
                return data[index];
            }
            else
            {
                Console.WriteLine("删除位置不合法！！！");
                return default(T);
            }
        }

        public T this[int index]
        {
            get { return GetEle(index);}
        }

        public T GetEle(int index)
        {
            if (index < 0 || index > count - 1)
            {
                Console.WriteLine("查找数据不合法！！！");
                return default(T);
            }
            else
                return data[index];
        }
        /// <summary>
        /// 查找线性表中某个数据的位置
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int GetLocal(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
