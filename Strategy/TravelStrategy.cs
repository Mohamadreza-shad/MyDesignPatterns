using static System.Console;
namespace DesignPatterns.Strategy
{
    public class TravelStrategy
    {
        private readonly TravelTimeCalculator _travelTimeCalculator;

        public TravelStrategy(TravelTimeCalculator travelTimeCalculator)
        {
            _travelTimeCalculator = travelTimeCalculator;
        }

        public void Calculte(string origin, string des)
        {
            WriteLine(_travelTimeCalculator.GetTravelTime(origin,des));
        }
    }
}