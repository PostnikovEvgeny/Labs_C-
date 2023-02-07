using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    public class MyEnumerator<T> : IEnumerator<T>
    {
        DPoint<T> beg;
        DPoint<T> current;
        public T Current
        {
            get { return current.data; }
        }

        public MyEnumerator(MyCollection<T> c)
        {
            beg = c.beg;
            current = c.beg;
        }
        

        object IEnumerator.Current
        {
            get { return Current;}
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            current = beg;
        }
    }
}
