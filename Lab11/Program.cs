using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLab10;
using System.Collections;

namespace Lab11
{
    internal class Program
    {
        static public void PrintMenu()
        {
            Console.WriteLine(@"1. Задание 1
2. Задание 2
3. Задание 3
4. Выход
");
        }
        static public void Print1Menu()
        {
            Console.WriteLine(@"1. Создать коллекцию
2. Добавить элемент в коллеккцию
3. Удалить элемент из коллекции
4. Вывести коллекцию
5. Вывести запросы
6. Клонирование коллекции
7. Сортировка и поиск заданного элемента
8. Назад
");
        }

        static void Main(string[] args)
        {
            int check;
            //var trials=0;
            LinkedList<Trial> trials = null;
            
            do
            {
                PrintMenu();
                do
                {
                    Console.WriteLine("Выберите один из пунктов меню ");
                } while ((!Int32.TryParse(Console.ReadLine(), out check)) && (check < 1 || check > 5));

                switch (check)
                {
                    case 1:
                        //задание 1
                        int check1;

                        do
                        {
                            Print1Menu();
                            do
                            {
                                Console.WriteLine("Выберите один из пунктов меню ");
                            } while ((!Int32.TryParse(Console.ReadLine(), out check1)) && (check1 < 1 || check1 > 6));

                            switch (check1)
                            {
                                case 1: // создать коллекцию
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

                                    var arr = new List<Trial> {student1,student2, student3, student4, student5, student6, student7, student8, student9, student10 };
                                    LinkedList<Trial> tr = new LinkedList<Trial>(arr);
                                    LinkedList<IRandomInit> tr2 = new LinkedList<IRandomInit>(arr);
                                    trials = tr;
                                    Console.WriteLine("Коллекция создана!");
                                    break;
                                case 2: //добавить элемент в коллекцию

                                    break;
                                case 3: //удалить элемент из коллекции

                                    break;
                                case 4: //вывести коллекцию

                                    break;
                                case 5: //вывести запросы

                                    break;
                                case 6: //клонирование коллекции
                                  
                                    break;
                                case 7: // сортировка и поиск заданного элемента

                                    break;

                            }
                        } while (check1 < 8);
                        break;

                    case 2:
                        //задание 2
                        
                        break;

                    case 3:
                        //задание 3  
                        
                        break;


                }
            } while (check < 6);            
        }
    }
}
