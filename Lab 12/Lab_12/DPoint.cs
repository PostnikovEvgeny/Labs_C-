using ClassLibraryLab10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    public class DPoint<T>
    {
        public T data;
        public DPoint<T> left;
        public DPoint<T> right;

        public DPoint() 
        { 
            data = default(T);
            left = null;
            right = null;
        }
        public DPoint(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        /*public static DPoint MakeRoot(Trial data)
        {
            return new DPoint(data);
        }*/
        /*public void UpDownRun(DPoint p)
        {
            if (p != null)
            {
                Console.WriteLine("Обработка");
                UpDownRun(p.left);
                UpDownRun(p.right);
            }
        }
        public void LeftRightRun(DPoint p)
        {
            if (p != null)
            {

                LeftRightRun(p.left);
                Console.WriteLine("Обработка");
                LeftRightRun(p.right);
            }
        }
        public void DownUpRun(DPoint p)
        {
            if (p != null)
            {
                DownUpRun(p.left);
                DownUpRun(p.right);
                Console.WriteLine("Обработка");
            }
        }*/

        /*public static DPoint Add(DPoint root, Trial trial)
        {
            DPoint p = root;
            DPoint r = null;
            bool ok = false;
            if (p != null)
            {
                while (p!=null && !ok)
                {
                    r = p;
                    if (trial == p.data) ok = true;
                    else
                    {
                        if (trial < p.data)
                        {
                            p = p.left;
                        }
                        else 
                            p = p.right;
                    }
                }
                if (ok)
                {
                    Console.WriteLine("такой элемент существует");
                    return p;
                }

                DPoint NewPoint = new DPoint(trial);
                if (trial < r.data)
                {
                    r.left = NewPoint;
                }
                else
                {
                    r.right = NewPoint;
                }
                return NewPoint;
            }
            else
            {
                Console.WriteLine("Корня не создано");
                return null;
            }
            
        }*/

        public static DPoint<T> IdealTree(int size, DPoint<T> p)
        {
            DPoint<T> r;
            int cl, cr;
            if (size == 0) 
            {
                p = null;
                return p; 
            }
            cl = size / 2;
            cr = size - cl - 1;
            r = new DPoint<T>();
            r.left = IdealTree(cl, r.left);
            r.right = IdealTree(cr, r.right);
            return r;
        }

        /*public static void ShowTree(DPoint<T> p, int l)
        {
            if(p != null)
            {
                ShowTree(p.left, l+3);
                for (int i = 0; i < l; i++) Console.Write("    "); 
                Console.WriteLine("элем");
                Console.WriteLine();
                ShowTree(p.right,l+3);
                
            }
        }*/
        /*public static class ExtensionTreeNode
        {
            public static void AddSearch(this BinaryTreeNode<Engine> node, Engine engine)
            {
                if (node.Value is null)
                {
                    node.Value = engine;
                }
                else
                {
                    int compare = node.Value.CompareTo(engine);
                    if (compare == 1)
                    {
                        if (node.Right is not null)
                            node.Right.AddSearch(engine);
                        else
                            node.Right = new BinaryTreeNode<Engine>(engine, node);
                    }
                    else if (compare == -1)
                    {
                        if (node.Left is not null)
                            node.Left.AddSearch(engine);
                        else
                            node.Left = new BinaryTreeNode<Engine>(engine, node);
                    }
                    else
                    {
                        throw new Exception("Element already in SearchTree");
                    }
                }
            }
        }*/

    }
}
