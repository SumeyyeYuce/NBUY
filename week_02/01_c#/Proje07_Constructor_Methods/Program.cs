namespace Proje07_Constructor_Methods
{
    class Person
    {
        //her classın boş default bir concstructor'ı var ama ben kendim gidip boş constructor yazdığımda default olmaz artık.
        public Person()//method (normalde methodun önünde bir tip oluyordu ama burda yok.çükü constructor method bu)
                       //constructor method da Tip olmaz
        {
            //Her classın defulat olarak boş bir concrtuctor methodu vardır.ama implicittir,yan, örtülü
            //gizlidr,Şu anda biz kendimiz bir conctructor mrthod yazdık.
            //concdtrutor method ilgili calss dan new keyworü ile yeni bir nesne yaratıldığı esnada çalışacak kodları barındrıır
            //yani bu classda bir nesne üretildiği anda buradaki kodalr çalışır
            Console.WriteLine("Merhaba ben bu person");
        }
        //aşşagıdaki paranteze kadar olan methodu çok kullanacagız
        public Person(string firstName,string lastName)
        {
            //yukarıdaki person.
            FirstName = firstName;//firstname =sümeyye demiş olduk
            LastName = lastName;
        }
        //buraya kadar
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //constructor method lar mirasaldı diye herşeyi geçmiyor.içine constructur yazmamız lazım
    class Student:Person
    {
        public Student(string firstName,string lastName,int studentNumber) : base(firstName,lastName)//ctor kısayolu bu satırı açmanın bir clasın miras aldığı clasa base diyrouz
        {    //bu aşşagıdaki iki satırı kapatmamızdaki sebep "base" ile yaptığımız için.Doğrusu base kullanımı                                                        //base ile yukarıdaki persondan  isimleri istedik
            //FirstName = firstName;
            //LastName = lastName;
            StudentNumber = studentNumber;
        }
        public int StudentNumber { get; set; }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
        //   Person person1 = new Person();//parametresiz
        //   Person person2=new Person("Sümeyye","Yüce");//yeni nesne oluşturduk//overload ile yaptık//parametreli//yukardaki parametreli olan methodla ilişkilendiriiliyor.
        //   Console.WriteLine($"{person2.FirstName} {person2.LastName}");

           Student student1 = new Student("Selin","Candaş",120);
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");

           Console.ReadLine();
        }
    }
}