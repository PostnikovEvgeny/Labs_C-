using System;
using System.CodeDom;
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
        public int id;
        
        public int Id 
        {
            get => id;
            set => id =value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Trial()
        {
            Name = "Математика";
            //RandomInit();
            id = rnd.Next(1, 1000000);
        }
        public Trial(string name, int index)
        {
            Name = name;
            id = index;
        }
        virtual public void Show()
        {
            Console.WriteLine("Trial: Предмет: " + Name);
        }
        public virtual void RandomInit()
        {
            string[] namesOfSubjects = {"Математика","Русский язык","Информатика","Социология","Химия","Биология","Физика","Физкультура","ОБЖ","МХК","География","Английский язык"};
            this.Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
            this.Id = rnd.Next(1, 1000000);
        }
        public virtual int CompareTo(object obj)
        {
            return String.Compare(this.Name, ((Trial)obj).Name); 
        }
        override public string ToString()
        {
            return (Name + " " + Id).ToString();
        }
        public override int GetHashCode()
        {
            return (this.ToString()).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Trial ob) 
                return Name == ob.Name && Id == ob.Id ;
            return false;
        }
        public virtual object Clone()
        {
            return new Trial(Name, Id);
        }
        public static bool operator < (Trial a, Trial b)
        {
            return a.Id < b.Id;
        }
        public static bool operator > (Trial a, Trial b)
        {
            return a.Id > b.Id;
        }
    }
}
