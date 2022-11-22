using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class SortByAge: IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            Person p1 = (Person)obj1;
            Person p2 = (Person)obj2;

            if(p1.Age < p2.Age)       
                return -1;            
            else
                if(p1.Age > p2.Age)
                    return 1;
                else 
                    return 0;

        }
    }
}
