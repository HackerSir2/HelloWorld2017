using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>where T:IComparable
    {
        private T[] array;
        private int size; //数组的容量
        private int count = 0; //数组元素的个数
   

        public MyList(int size) {
            if (size>0)
            {
                array = new T[size];
            }
        }
        public MyList() {
            array = new T[0];
        }

        //set和get方法
        public int getCapucity {
            //return array.Length;
            get{
                return array.Length;
            }
        }
        public int getCount {
            get {
                return count;
            }
        }
        //向列表中添加元素
        public void Add(T item) {
            if (array.Length==count)
            {
                if (array.Length == 0)
                {
                    array = new T[4]; //如果数组中没有元素，默认定义列表的容量为4
                }
                else {
                    var arraynew = new T[size * 2];
                    Array.Copy(array, arraynew, count); //将数组array中的元素复制到新数组arraynew中
                    array = arraynew; //替换原来的数组
                }
            }
            array[count] = item;
            count++; //计数器加一
        }
        //通过索引查找元素
        public T GetItem(int index){
            if (index >= 0 && index < count)
            {
                return array[index];
            }
            else {
                throw new IndexOutOfRangeException("索引超出范围");
            }
        }
        //索引器的定义
       public T this[int index]{
            get {
               return GetItem(index);
            }
            set {
                if (index >= 0 && index < count)
                {
                    array[index]= value;
                }
                else {
                    throw new IndexOutOfRangeException("索引超出范围");
                }
            }

        }
        //向列表中插入元素
        public void Insert(int index,T item) {
            if (index>=0&&index<count)
            {
                if (count==array.Length)
                {
                    var arraynew = new T[2*array.Length];
                    Array.Copy(array,arraynew,count);
                    array = arraynew;
                }
                for (int i = count-1; i>=index; i--)
                {
                    array[i+1] = array[i];
                }
                array[index] = item;
                count++;  //计数器自增
            }
            else
            {
                throw new IndexOutOfRangeException("插入位置不合法！");
            }
        }

        //移除某个位置的元素
        public void removeAt(int index) {
            if (index>=0&&index<count)
            {
                for (int i = index+1; i <count ; i++)
                {
                    array[i - 1] = array[i];
                }
                count--;
            }
            else
            {
                throw new IndexOutOfRangeException("移除位置不合法！");
            }
        }
        //找到某个元素的索引
        public int IndexOf(T item) {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
              }
            return -1;
            }
        //冒泡排序
        public void Sort() {
            for (int j = 0; j < count-1; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            
        }
        }
    }

