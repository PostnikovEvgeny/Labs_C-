using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Person : IRandomInit, IComparable, ICloneable
    {
        private static Random rnd = new Random();
        private string name;
        private string secondName;
        private string lastName;
        private int age;
        public IdNumber id { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Возраст не может быть меньше 1");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Person()
        {
            Name = "Иван";
            SecondName = "Иванов";
            LastName = "Иванович";
            Age = 18;
            id = new IdNumber(rnd.Next(100,1000));
        }
        public Person(int index, string name, string secondname, string lastname, int age)
        {
            id = new IdNumber(index);
            Name = name;
            SecondName = secondname;
            LastName = lastname;
            Age = age;
        }
        public void Show()
        {
            Console.WriteLine("ФИО: " + SecondName + " " + Name + " " + LastName + " Возраст: " + Age +" id: "+id );
        }
        public void RandomInit()
        {
            string[] namesOfPersons = { "Иван", "Петр", "Егор", "Василий", "Владимир", "Антип", "Савелий", "Юрий", "Юлий", "Евгений", "Алексей", "Илья", "Владислав", "Игорь", "Виталий", "Дмитрий" };
            string[] secondNamesOfPersons = { "Иванов", "Петров", "Егоров", "Васильев", "Антипин", "Антипьев", "Савельев", "Юрьев", "Волков", "Сидоров", "Щербаков", "Жданов", "Голдырев", "Дроздов", "Дятлов", "Булкин" };
            string[] lastNamesOfPersons = { "Иванович", "Петрович", "Егорович", "Васильевич", "Владимирович", "Антипович", "Савельевич", "Юрьевич", "Игоревич", "Евгеньевич", "Алексеевич", "Ильич", "Владиславович", "Константинович", "Витальевич", "Дмитриевич" };
            Name = namesOfPersons[rnd.Next(namesOfPersons.Length)];
            SecondName = secondNamesOfPersons[rnd.Next(namesOfPersons.Length)];
            LastName = lastNamesOfPersons[rnd.Next(namesOfPersons.Length)];
            Age = rnd.Next(1, 100);
        }
        public virtual int CompareTo(object obj)
        {
            return String.Compare(this.Name, ((Person)obj).Name);
        }
        public object Clone()    // глубокое клонироване
        {
            return new Person(this.id.number, this.Name, this.SecondName, this.LastName, this.Age); 
        }
        public object ShallowCopy()    // поверхностное копирование
        {
            return this.MemberwiseClone();  
        }
    }
}
