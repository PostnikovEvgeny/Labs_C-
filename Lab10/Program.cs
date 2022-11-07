using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab10;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test student1 = new Test("Информатика", 50);
            Test student2 = new Test("Математика", 70);
            Test student3 = new Test("Социология", 95);
            Exam student4 = new Exam("Информатика", 5);
            Exam student5 = new Exam("Русский язык", 2);
            Exam student6 = new Exam("Физика", 5);
            Exam student7 = new Exam("Биология", 4);
            FinalExam student8 = new FinalExam("Математика", 4);
            FinalExam student9 = new FinalExam("Химия", 2);
            FinalExam student10 = new FinalExam("Русский язык", 2);

            Trial[] arr = new Trial[10] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10};

            

            int count1 = 0;  //Количество студентов, сдавших хотя бы 1 экзамен на отлично
            int count2 = 0;  //Количество студентов, не сдавших хотя бы 1 экзамен
            string subject = "";  //Название предмета, по которому получен наивысший был на тесте
            int score = 0;
            foreach (Trial t in arr)
            {
                
                if(t is Exam )
                {
                    if(((Exam)t).Mark==5)
                    {
                        count1++;
                    }
                    if (((Exam)t).Mark == 2)
                    {
                        count2++;
                    }

                }
                if (t is FinalExam)
                {
                    if (((FinalExam)t).Mark == 5)
                    {
                        count1++;
                    }
                    if (((FinalExam)t).Mark == 2)
                    {
                        count2++;
                    }

                }
                if(t is Test)
                {
                    if(((Test)t).Score > score)
                    {
                        score = ((Test)t).Score;
                        subject = ((Test)t).Name;
                    }
                }
            }
            Console.WriteLine("Количество студентов, сдавших хотя бы один экзамен на отлично: " + count1);
            Console.WriteLine("Количество студентов, не сдавших хотя бы один экзамен: " + count2);
            Console.WriteLine("Название предмета, по которому получен наивысший бал на тесте: " + subject);

            Console.ReadKey();
        }     
    }
}
