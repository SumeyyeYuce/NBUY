namespace Proje05_Methods_Advanced
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }    
            public int year { get; set; }   

            public string Intro()
            {
                return $"Ad:{this.Name},Yaş:{this.CalculateAge()}";//this.name burdaki name class persondak iüretilen name dir 
            }
            private int CalculateAge()
            {
                return DateTime.Now.Year - this.year;//burada kişinin şimdiki yıldan doğum yılını çıkarıp yaşını bulduk
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Engin", year = 1975 };
            Person person2 = new Person() { Name = "Aydın", year = 1986 };
            Person person3 = new Person() { Name = "Ayşe", year = 1976 };
            Person person4 = new Person() { Name = "Melis", year = 2000 };
            Person person5 = new Person() { Name = "Doğan", year = 2005 };

            //Console.WriteLine(person3.Intro()); //person3'ü çagırdık
            ////Tüm kişilerin intro bilgilerini yazdırın
            //Console.WriteLine();
            Person[] persons = { person1, person2, person3, person4, person5 };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Intro());
            }

            Console.ReadLine();
            //C# ta her ŞEY bir NESNEDİR!




        }
    }
}