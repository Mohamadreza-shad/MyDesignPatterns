namespace DesignPatterns.Strategy
{
    public class Bus : TravelTimeCalculator
    {
        public override string GetTravelTime(string origin, string destination)
        {
            return $"travel time from {origin} to {destination} is 120 min";
        }
    }
}