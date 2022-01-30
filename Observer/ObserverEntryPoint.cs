using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class ObserverEntryPoint : EntryPoint
    {
        public override void Ejra()
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
                DepId = 1
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

        public interface ISubject
    {
        List<IObserver> List { get; set; }

        void Register(IObserver observer);
        void Remove(IObserver observer);
    }

    public class Stock : ISubject
    {
        public List<IObserver> List { get; set; } = new List<IObserver>();
        private int _product;

        public int Product
        {
            get { return _product; }
            set {
                _product = value;

                foreach (var item in List)
                {
                    item.Update();
                }
            }
        }

        public void Register(IObserver observer)
        {
            List.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            List.Remove(observer);
        }
    }
    public interface IObserver
    {
        
        void Update();
    }
    public class Person : IObserver
    {
        public string FullName { get; set; }

        public void Update()
        {
            System.Console.WriteLine($"{FullName} Is Happy");
        }
    }
    public class Department : IObserver
    {
        public int DepId { get; set; }
        public void Update()
        {
            System.Console.WriteLine($"Departman {DepId} Is Sad");

        }
    }

}