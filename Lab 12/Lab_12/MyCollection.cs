using ClassLibraryLab10;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_12
{
    public class MyCollection<T> : ICollection<T>,IEnumerable<T>
    {
        int count;
        public DPoint<T> beg;


        public int Count 
        {
            get { return count; }
            set { count = value; }
        }
       
        public bool IsReadOnly => throw new NotImplementedException();

        public MyCollection() 
        {
            DPoint<T> point = new DPoint<T>();
            beg = point;
            Count++;
        }

        public MyCollection(int capacity)
        {
            beg = DPoint<T>.IdealTree(capacity, beg);
            Count += capacity;
        }
        public MyCollection(MyCollection<T> c)
        {
            MyCollection<T> col1 = new MyCollection<T>();
            foreach(T point in c)
            {
                c.Add(point);
            }
        }

        public static void ShowTree(DPoint<T> p, int l)
        {
            if (p != null)
            {
                ShowTree(p.left, l + 3);
                for (int i = 0; i < l; i++) Console.Write("    ");
                Console.WriteLine(p.data.ToString());
                Console.WriteLine();
                ShowTree(p.right, l + 3);
            }
            else
            {
                Console.WriteLine("Коллекции не существует");
            }
        }
        public void UpDownRun(DPoint<T> p)
        {
            if (p != null)
            {
                Console.WriteLine("Обработка");
                UpDownRun(p.left);
                UpDownRun(p.right);
            }
        }
        /*
        public void LeftRightRun(DPoint<T> p)
        {
            if (p != null)
            {

                LeftRightRun(p.left);
                Console.WriteLine("Обработка");
                LeftRightRun(p.right);
            }
        }
        public void DownUpRun(DPoint<T> p)
        {
            if (p != null)
            {
                DownUpRun(p.left);
                DownUpRun(p.right);
                Console.WriteLine("Обработка");
            }
        }*/

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}
