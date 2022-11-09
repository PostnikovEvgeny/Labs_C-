using ClassLibraryLab10;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestLab10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trial t = new Trial("Математика");
            Assert.AreEqual("Математика",t.Name);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Trial t = new Trial();
            Assert.AreEqual("Математика", t.Name);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Trial t = new Trial("Математика");
            t.Show();
        }
        [TestMethod]
        public void TestMethod4()
        {
            Trial t = new Trial("Математика");
            t.RandomInit();
        }
        [TestMethod]
        public void TestMethod5()
        {
            Trial t = new Trial("Математика");
            Trial t1 = new Trial();
            Assert.AreEqual(0, t.CompareTo(t1));
        }


        [TestMethod]
        public void TestMethod6()
        {
            Test t = new Test("Математика", 0);
            Test t1 = new Test();
            Assert.AreEqual(t.Name, t1.Name);
            Assert.AreEqual(t.Score, t1.Score);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Test t = new Test("Математика", -1);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Test t = new Test("Математика", 101);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Test t = new Test();
            t.Show();
        }
        [TestMethod]
        public void TestMethod10()
        {
            Test t = new Test();
            t.RandomInit();
        }


        [TestMethod]
        public void TestMethod11()
        {
            Exam t = new Exam("Математика",'F');
            Exam t1 = new Exam();
            Assert.AreEqual(t.Name, t1.Name);
            Assert.AreEqual(t.Mark,t1.Mark);            
        }
        [TestMethod]
        public void TestMethod12()
        {
            Exam t = new Exam("Математика", '.');
        }
        [TestMethod]
        public void TestMethod13()
        {
            Exam t = new Exam();
            t.Show();
        }
        [TestMethod]
        public void TestMethod14()
        {
            Exam t = new Exam();
            t.RandomInit();
        }


        [TestMethod]
        public void TestMethod15()
        {
            FinalExam t = new FinalExam("Математика", 2);
            FinalExam t1 = new FinalExam();
            Assert.AreEqual(t.Name, t1.Name);
            Assert.AreEqual(t.Mark, t1.Mark);
        }
        [TestMethod]
        public void TestMethod16()
        {
            FinalExam t = new FinalExam("Математика", 1);
        }
        [TestMethod]
        public void TestMethod17()
        {
            FinalExam t = new FinalExam("Математика", 6);
        }
        [TestMethod]
        public void TestMethod18()
        {
            FinalExam t = new FinalExam();
            t.Show();
        }
        [TestMethod]
        public void TestMethod19()
        {
            FinalExam t = new FinalExam();
            t.RandomInit();
        }


        [TestMethod]
        public void TestMethod20()
        {
            Person t1 = new Person(10,"Иван","Иванов","Иванович",10);
            t1.Show();
        }
        [TestMethod]
        public void TestMethod21()
        {
            Person t = new Person(10, "Иван", "Иванов", "Иванович", -1);
        }
        [TestMethod]
        public void TestMethod22()
        {
            Person t = new Person(10, "Иван", "Иванов", "Иванович", 11);
            Person t1 = new Person(10, "Иван", "Иванов", "Иванович", 11);
            Assert.AreEqual(0, t.CompareTo(t1));
        }
        [TestMethod]
        public void TestMethod23()
        {
            Person t = new Person(10, "Иван", "Иванов", "Иванович", 11);
            Person copy = (Person)t.ShallowCopy();
            Assert.AreEqual(t.Name, copy.Name);
        }
        [TestMethod]
        public void TestMethod24()
        {
            Person t = new Person(10, "Иван", "Иванов", "Иванович", 11);
            Person clone = (Person)t.Clone();
            Assert.AreEqual(t.Name, clone.Name);
        }
        [TestMethod]
        public void TestMethod25()
        {
            Person t9 = new Person(10, "Иван", "Иванов", "Иванович", 11);
            Person t10 = new Person(10, "Иван", "Иванов", "Иванович", 46);
            Person t11 = new Person();
            Person t12 = new Person();
            Person t13 = new Person();
            Person t14 = new Person();
            Person t15 = new Person();
            Person[] randomInits2 = new Person[] { t9, t10, t11, t12, t13, t14, t15 };
            
            Array.Sort(randomInits2, new SortByAge());
        }
        [TestMethod]
        public void TestMethod26()
        {
            Person t9 = new Person();
            Person t10 = new Person();
            Person t11 = new Person();
            Person t12 = new Person();
            Person t13 = new Person();
            Person t14 = new Person();
            Person t15 = new Person();
            Person[] randomInits2 = new Person[] { t9, t10, t11, t12, t13, t14, t15 };
            for (int i = 0; i < randomInits2.Length; i++)
            {
                randomInits2[i].RandomInit();

            }
        }
        /*[TestMethod]
        public void TestMethod26()
        {
            string inputString = "Химия\n\n";
            MemoryStream InStream = new MemoryStream(256);
            StreamWriter writer = new StreamWriter(InStream);
            writer.Write(inputString);
            writer.Flush();
            InStream.Position = 0;
            TextReader t = new StreamReader(InStream);
            Console.SetIn(t);
            //Program.Main();
            //Program.Run(null);
            //Interface.Start();

        }*/


        /*[TestMethod]
        public void TestMethod27()
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

            Trial[] arr = new Trial[10] { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };



            int count1 = 0;  //Количество студентов, сдавших хотя бы 1 экзамен на отлично
            int count2 = 0;  //Количество студентов, не сдавших хотя бы 1 экзамен
            string subject = "";  //Название предмета, по которому получен наивысший был на тесте
            int score = 0;

            Program.Query(arr, ref count1, ref count2, ref subject, ref score);
            Program.Run(null);

        }*/



    }
}