using DesignPatterns.Observer;

namespace DesignPatterns
{    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FullName = "Arash Ajdari"
            };
            Person alireza = new Person
            {
                FullName = "Alireza Oroumand"
            };
            Department foroosh = new Department
            {
                DepId = 1
            };
            Department ersal = new Department
            {
                DepId = 2
            };

            Stock subject = new Stock();
            subject.Register(person);
            subject.Register(alireza);
            subject.Register(foroosh);
            subject.Register(ersal);
            subject.Product = 2;
            System.Console.WriteLine("------------------------");
            subject.Product = 3;

            System.Console.WriteLine("------------------------");
            subject.Remove(person);
            subject.Product = 2;

            System.Console.WriteLine("------------------------");


            System.Console.Read();
        }
    }

}
