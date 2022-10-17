namespace Proje06_Inheritance_Kalıtım_Miras
{
    class Person//bir class istenildiği kadar başka classa miras verebilir.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Intro()//virtual keywordi bu methodun miras alınan classlarda ovirride edeilmesine izin verir
        {
            Console.WriteLine($"FirstName:{this.FirstName},LastName{this.LastName}");
            
        }
    }
    class Writer:Person
    {
        public string BookName { get; set; }

    }

    class Teacher:Person
    {
        public string Branch { get; set; }

    }

                         
    class Student: Person //student'ın aynı zamanda person olmasını istiyoruz.Yani bir personda ne varsa student ta da olsun diyoruz(firtname ve lastname persondan miras alarak student'ın içine geldi)
                          //bir class sadece tek bir class'dan miras alabilir(student:person) gibi.                     
    {

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int StudentNumber { get; set; }
        public override void Intro()//bu methodun miras alınan sınıftaki versiyonunu ezip, yok sayıp yerine bu methodu kabul eder
        {
            Console.WriteLine($"FirstName:{this.FirstName},LastName:{this.LastName},StudentNumber:{this.StudentNumber}");
        }
    }

        class a
        {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
         }

        class b : a
        {
            public int MyProperty3 { get; set; }
            public int MyProperty4 { get; set; }
        }
        class c : b//c classında  bütün propertyler var
        {
            public int MyProperty5 { get; set; }
            public int MyProperty6 { get; set; }
        }
    internal class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();

            student.FirstName = "KEMAL";
            student.LastName = "KAPUCU";
            student.StudentNumber = 125;

            student.Intro();


            Teacher teacher = new Teacher()
            {
                FirstName = "AYŞE",
                LastName= "ay",
                Branch= "Matematik"
                
                
            };
            teacher.Intro();

             Person person1 = new Student();
            //Student student1 = new Person();//Burası hatalı bir yaklaşım

            //bir teacher tanımlayın içini doldurun ekrana yazdırın
            Console.ReadLine();
        }
        
    }
}