using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryLab10
{
    public class Exam:Trial
    {
        char mark; // A - 5  B - 4  C - 3  D - 3  E - 2 F - 2

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
            Mark = 'F';
        }
        public Exam(string name, char mark) : base(name)
        {
            Mark = mark;
        }
        override public void Show()
        {
            Console.WriteLine("Exam: Предмет: " + Name + " Оценка " + Mark);
        }
        override public string ToString()
        {
            return (Name + " " + Mark).ToString();
        }
        override public void RandomInit()
        {
            char[] marks = { 'A', 'B', 'C', 'C', 'E', 'F' };
            string[] namesOfSubjects = { "Математика", "Русский язык", "Информатика", "Социология", "Химия", "Биология", "Физика" };
            Name = namesOfSubjects[rnd.Next(namesOfSubjects.Length)];
            Mark = marks[rnd.Next(marks.Length)];
        }
      
    }
}
