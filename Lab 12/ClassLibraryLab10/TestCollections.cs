using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class TestCollections
    {
        public LinkedList<Trial> listT;
        public LinkedList<string> listStr;
        public Dictionary<Trial, Exam> dictT;
        public Dictionary<string, Exam> dictStrT;

        public TestCollections(int count)
        {
            listT = new LinkedList<Trial>();
            listStr = new LinkedList<string>();
            dictT = new Dictionary<Trial, Exam>();
            dictStrT = new Dictionary<string, Exam>();

            for(int i = 0; i < count; i++)
            {
                Exam t = new Exam();
                t.RandomInit();
                listT.AddLast(t.BaseTrial);
                listStr.AddLast(t.BaseTrial.ToString());
                dictT.Add(t.BaseTrial,t);  
                dictStrT.Add(t.BaseTrial.ToString(), t);  
            }

        }
        static public void ShowList<T>(LinkedList<T> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
        }

        static public void ShowDictionary<TKey,TValue>(Dictionary<TKey,TValue> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
        }
    }
    
}
