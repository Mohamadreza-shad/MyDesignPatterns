using static System.Console;

namespace DesignPatterns.Strategy
{
    public class StrategyEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            
            WriteLine("Please enter your travel strategy: \nCar \nBus \nBike \nWalk");
            string strategy = ReadLine().ToLower();
            switch (strategy)
            {
                case "car" : 
                    new TravelStrategy(new Car()).Calculte("A","B");
                    break;

                case "bus" : 
                    new TravelStrategy(new Bus()).Calculte("A","B");
                    break;
                case "bike" : 
                    new TravelStrategy(new Bike()).Calculte("A","B");
                    break;

                case "walk" : 
                    new TravelStrategy(new Walk()).Calculte("A","B");
                    break;
            }
        }
    }
}