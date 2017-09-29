using SeqOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearList
{
    class Linear<T> : IListDS<T>
    {
        private Node<T> head;

        /// <summary>
        /// 获取链表的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            if (head == null) return 0;
            Node<T> temp = head;
            int count = 1;
            while (true)
            {
                if (head.Next != null)
                {
                    temp = temp.Next;
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()
        {
            head = null;
        }

        /// <summary>
        /// 判断链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// 在链表中添加数据
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (true)
                {
                    Node<T> temp = head;
                    if (head.Next != null)
                    {
                        temp=temp.Next;
                    }
                    else
                    {
                        break;
                    }
                   temp.Next = newNode;
                }
            }

        }

        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if (index==0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for (int i =1; i <index-1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                
            }
        }

        public T Delete(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

        public T GetEle(int index)
        {
            throw new NotImplementedException();
        }

        public int GetLocal(T value)
        {
            throw new NotImplementedException();
        }
    }
}
