using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLab10
{
    public class FinalExam:Trial
    {
        private int mark;

        public int Mark
        {
            get { return mark; }
            set
            {
                if (value < 2)
                {
                    Console.WriteLine("Оценка не может быть ниже 2");
                    mark = 2;
                }
                else
                {
                    if (value > 5)
                    {
                        Console.WriteLine("Оценка не может быть выше 5");
                        mark = 5;
                    }
                    else
                    {
                        mark = value;
                    }
                }
            }
        }
        public FinalExam() : base()
        {
            RandomInit();
        }
        public FinalExam(string name, int mark, int id) : base(name, id)
        {
            Mark = mark;
        }
        override public void Show()
        {
            Console.WriteLine("FinalExam: Предмет: " + Name + " Оценка " + Mark);
        }
        public override object Clone()
        {
            return new FinalExam(Name, Mark, Id);
        }
        override public void RandomInit()
        {
            string[] namesOfSubjects = { "Математика", "Русский язык", "Информатика", "Социология", "Химия", "Биология", "Физика", "Физкультура", "ОБЖ", "МХК", "География", "Английский язык" };
            Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
            Mark = rnd.Next(2, 6);
        }
       
    }
}
