namespace Proje08_Abstract
{
     abstract  class Person//eger bir class abstrct ise o classdan yeni nesne yaratılamaz
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is creat");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Greeting()
        {
            Console.WriteLine("I am a Person");
        }
        public abstract void Intro();//bu classdan miras alan butun classlarda bunun olmsını saglicak
        //eger bir classın içinde abstract bir metot var ise o class da abstrcat olmalı

        

    }

    class Student : Person//abstract metod olmadıgı için yapıyrouz
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
            Console.WriteLine("Student is creat");

        }
        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name:{FirstName} Last NAme:{LastName} student number{StudentNumber}");
        }
        //public void Intro()
        //{
        //    Console.WriteLine($"FirstName:{this.FirstName}, LastName:{this.LastName}");
        //}
    }
   class Teacher:Person
   {
        public Teacher(string firstName,string lastName,string branch):base(firstName,lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Branch = branch;
            Console.WriteLine("Student is creat");

        }
        public string Branch { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name:{FirstName} Last NAme:{LastName} bransh:{Branch}");
        }

        public void Teach()
        {
            Console.WriteLine("BEN ÖGRETMEN");
        }
        //public void Intro()
        //{
        //    Console.WriteLine($"FirstName:{this.FirstName}, LastName:{this.LastName},Branch:{this.Branch}");
        //}

    }

    class Writer:Person
    {
        public Writer(string firstName,string lastName,string bookName):base(firstName,lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            BookName = bookName;
            Console.WriteLine("Student is creat");

        }
        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name:{FirstName} Last NAme:{LastName} book:{BookName}");
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student student1 = new Student("Sümeyye", "yüce", 230);
                student1.Greeting();
                student1.Intro();//NOT:istemediğimiz halde person daki ıntro çalışıyor.

                Teacher teacher1 = new Teacher("şeyma", "budak", "DKT");
                teacher1.Greeting();
                teacher1.Intro();


                Writer writer1 = new Writer("gjhg","ghgfgh","ghjgjhg");
                writer1.Greeting();
                writer1.Intro();

                //Person person1 = new Person("halil", "kanlı");//eger bir class abstracyt ise bu şekilde deger veremeyiz abstrctr oldugu için new kullanılamaz
                
                Console.ReadLine();
            }
        }
    }
