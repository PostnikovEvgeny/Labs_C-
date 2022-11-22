using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Trial:IRandomInit,IComparable
    {
        protected string name;
        protected static Random rnd = new Random();
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Trial()
        {
            Name = "Математика";
        }
        public Trial(string name)
        {
            Name = name;
        }
        virtual public void Show()
        {
            Console.WriteLine("Trial: Предмет: " + Name);
        }
        override public string ToString()
        {
            return Name.ToString();
        }
        public virtual void RandomInit()
        {
            string[] namesOfSubjects = {"Математика","Русский язык","Информатика","Социология","Химия","Биология","Физика"};
            this.Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
        }
        public virtual int CompareTo(object obj)
        {
            return String.Compare(this.Name, ((Trial)obj).Name); 
        }
    }
}
