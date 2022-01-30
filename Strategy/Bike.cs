namespace DesignPatterns.Strategy
{
    public class Bike : TravelTimeCalculator
    {
        public override string GetTravelTime(string origin, string destination)
        {
            return $"travel time from {origin} to {destination} is 40 min";
        }
    }
    
}