namespace DesignPatterns.Strategy
{
    public class Car : TravelTimeCalculator
    {
        public override string GetTravelTime(string origin, string destination)
        {
            return $"travel time from {origin} to {destination} is 60 min";
        }
    }
}