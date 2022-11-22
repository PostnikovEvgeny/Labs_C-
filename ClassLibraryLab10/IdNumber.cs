using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class IdNumber
    {
        public int number;
        public IdNumber(int n)
        {
            number = n;
        }
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
