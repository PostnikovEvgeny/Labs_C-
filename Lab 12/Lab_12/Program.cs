using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab10;


namespace Lab_12
{
    public class Program
    {
        static void Main(string[] args)
        {

           /* Point begin = Point.MakeList(10);
            Point.PrintList(begin);*/
            //Trial trial = new Trial();
            //Trial trial1 = new Trial();
            MyCollection<Trial> MyCol = new MyCollection<Trial>(10);
            //DPoint<Trial> root = null;
            //root = DPoint<Trial>.IdealTree(10, MyCol.Root);
           // root = DPoint.MakeRoot(trial);
            //DPoint.Add(root, trial1);
            //trial.RandomInit();
            //trial1.RandomInit();
            //trial1.RandomInit();
            //trial1.RandomInit();
           // trial1.RandomInit();
            //trial1.RandomInit();
            //DPoint newelem = new DPoint(trial);
           // for (int i = 1; i < 10; i++)
           // {
            //    trial1.RandomInit();
           //     DPoint.Add(root, trial1);
           // }
            MyCollection<Trial>.ShowTree(MyCol.beg,4);
            Console.ReadKey();
        }
    }
}
