using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLab10
{
    public class Exam:Trial
    {
        char mark; // A - 5  B - 4  C - 3  D - 3  E - 2 F - 2
        
        public Trial BaseTrial
        {
            get
            {
                return new Trial(name, id); //возвращает объект базового класса
            }
        }


        public char Mark
        {
            get { return mark; }
            set
            {
                if (!Char.IsLetter(value) && (value != 'A' || value != 'B' || value != 'C' || value != 'D' || value !='E' || value != 'F'))
                {
                    Console.WriteLine("Вы ввели не букву, необходимо ввести оценку по шкале A(отл) B(оч.хор) C(хор) D(уд) E(слаб) F(неуд)");
                    mark = 'F';
                }
                else
                {
                    mark= value;
                }
            }
        }
        public Exam() : base()
        {
            RandomInit();
        }
        public Exam(string name, char mark, int id) : base(name, id)
        {
            Mark = mark;
        }
        override public void Show()
        {
            Console.WriteLine("Exam: Предмет: " + Name + " Оценка " + Mark);
        }
        override public void RandomInit()
        {
            char[] marks = { 'A', 'B', 'C', 'C', 'E', 'F' };
            string[] namesOfSubjects = { "Математика", "Русский язык", "Информатика", "Социология", "Химия", "Биология", "Физика", "Физкультура", "ОБЖ", "МХК", "География", "Английский язык" };
            Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
            Id = rnd.Next(1, 1000000);
            Mark = marks[rnd.Next(marks.Length)];
        }
        override public string ToString()
        {
            return (Name + " " + Mark + " " + Id).ToString();
        }
        public override int GetHashCode()
        {
            return (this.ToString()).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Exam ob)
                return Name == ob.Name && Mark == ob.Mark && Id == ob.Id ;
            return false;
        }
        public override object Clone()
        {
            return new Exam(Name, Mark, Id);
        }

    }
}
