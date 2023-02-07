using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLab10
{
    public class Test:Trial
    {
        private int score;
        public int Score
        {
            get => score;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество баллов не может быть отрицательным");
                    score = 0;
                }
                else
                {
                    if (value > 100)
                    {
                        Console.WriteLine("Количество баллов не может быть больше 100");
                        score = 100;
                    }
                    else
                    {
                        score = value;
                    }

                }
            }
        }
        public Test() : base()
        {
            RandomInit();
        }
        public Test(string name, int score, int id) : base(name,id)
        {
            Score = score;
        }
        public override object Clone()
        {
            return new Test(Name, Score, Id);
        }
        override public void Show()
        {
            Console.WriteLine("Test: Предмет: " + Name + " Количество баллов: " + score);
        }
        override public void RandomInit()
        {
            string[] namesOfSubjects = { "Математика", "Русский язык", "Информатика", "Социология", "Химия", "Биология", "Физика", "Физкультура", "ОБЖ", "МХК", "География", "Английский язык" };
            Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
            Score = rnd.Next(0, 101);
        }
    }
}
