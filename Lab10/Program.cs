using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab10;

namespace Lab10
{
    public class Program
    {
        static void Query(Trial []arr,ref int count1, ref int count2, ref string subject, ref int score)
        {
            foreach (Trial t in arr)
            {

                if (t is Exam)
                {
                    if (((Exam)t).Mark == 'A')
                    {
                        count1++;
                    }
                    if (((Exam)t).Mark == 'F')
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
                if (t is Test)
                {
                    if (((Test)t).Score > score)
                    {
                        score = ((Test)t).Score;
                        subject = ((Test)t).Name;
                    }
                }
            }
        }
        static void WriteArr(IRandomInit[]arr)
        {
            foreach (var t in arr)
            {

                if (t is Person)
                {
                    ((Person)t).Show();
                }
                else
                {
                    if (t is FinalExam)
                    {
                        ((FinalExam)t).Show();
                    }
                    else
                    {
                        if (t is Exam)
                        {
                            ((Exam)t).Show();
                        }
                        else
                        {
                            if (t is Test)
                            {
                                ((Test)t).Show();
                            }
                            else
                            {
                                if (t is Trial)
                                {
                                    ((Trial)t).Show();
                                }
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Test student1 = new Test("Информатика", 50);
            Test student2 = new Test("Математика", 70);
            Test student3 = new Test("Социология", 95);
            Exam student4 = new Exam("Информатика", 'A');
            Exam student5 = new Exam("Русский язык", 'F');
            Exam student6 = new Exam("Физика", 'A');
            Exam student7 = new Exam("Биология", 'B');
            FinalExam student8 = new FinalExam("Математика", 4);
            FinalExam student9 = new FinalExam("Химия", 2);
            FinalExam student10 = new FinalExam("Русский язык", 2);

            Trial[] arr = new Trial[10] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10};

            

            int count1 = 0;  //Количество студентов, сдавших хотя бы 1 экзамен на отлично
            int count2 = 0;  //Количество студентов, не сдавших хотя бы 1 экзамен
            string subject = "";  //Название предмета, по которому получен наивысший был на тесте
            int score = 0;

            Query(arr,ref count1,ref count2,ref subject,ref score);
           
            Console.WriteLine("Количество студентов, сдавших хотя бы один экзамен на отлично: " + count1);
            Console.WriteLine("Количество студентов, не сдавших хотя бы один экзамен: " + count2);
            Console.WriteLine("Название предмета, по которому получен наивысший бал на тесте: " + subject);
            Console.WriteLine();

            Trial t1 = new Trial();
            Trial t2 = new Trial();
            Test t3 = new Test();
            Test t4 = new Test();
            Exam t5 = new Exam();
            Exam t6 = new Exam();
            FinalExam t7 = new FinalExam();
            FinalExam t8 = new FinalExam();
            Person t9 = new Person();
            Person t10 = new Person();
            Person t11 = new Person();
            Person t12 = new Person();
            Person t13 = new Person();
            Person t14 = new Person();
            Person t15 = new Person();

            IRandomInit[] randomInits = new IRandomInit[] {t1,t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15};
            Console.WriteLine("Инициализация массива");
            for(int i=0;i<randomInits.Length;i++)
            {
                randomInits[i].RandomInit();

            }
            Console.WriteLine("Вывод массива");
            WriteArr(randomInits);
            Console.WriteLine();

            Trial[] randomInits1 = new Trial[] { t1, t2, t3, t4, t5, t6, t7, t8};
            Console.WriteLine("Сортировка массива IComparable");
            Array.Sort(randomInits1);
            WriteArr(randomInits1);
            Console.WriteLine();

            Person[] randomInits2 = new Person[] { t9, t10, t11, t12, t13, t14, t15};
            Console.WriteLine("Сортировка массива IComparer");
            Array.Sort(randomInits2, new SortByAge());
            WriteArr(randomInits2);
            Console.WriteLine();

            Console.WriteLine("Поиск элемента массива IComparer");
            Console.WriteLine("Введите название дисциплины для поиска");
            string nameOfSubject = Console.ReadLine();
            int position = Array.BinarySearch(randomInits1, new Trial(nameOfSubject));
            if(position < 0)
            {
                Console.WriteLine("Элемент не найден");
            }
            else
            {
                Console.WriteLine("Позиция элемента:" + position);
            }
            Console.WriteLine();

            Console.WriteLine("Клонирование объекта");
            Person clone = (Person)randomInits2[0].Clone();
            clone.Show();
            clone.Name="клон-"+clone.Name;
            clone.SecondName = "клон-" + clone.SecondName;
            clone.LastName = "клон-"+clone.LastName;
            clone.id.number = 22;
            Console.Write("Клон: ");
            clone.Show();
            Console.Write("Оригинал: ");
            randomInits2[0].Show();
            Console.WriteLine();

            Console.WriteLine("Копирование объекта");
            Person copy = (Person)randomInits2[1].ShallowCopy();
            copy.Show();
            copy.Name = "копия-" + copy.Name;
            copy.SecondName = "копия-" + copy.SecondName;
            copy.LastName = "копия-" + copy.LastName;
            copy.id.number = 11;
            Console.Write("Копия: ");
            copy.Show();
            Console.Write("Оригинал: ");
            randomInits2[1].Show();
            Console.ReadKey();
        }     
    }
}
