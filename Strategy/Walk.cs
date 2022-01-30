namespace DesignPatterns.Strategy
{
    public class Walk : TravelTimeCalculator
    {
        public override string GetTravelTime(string origin, string destination)
        {
            return $"travel time from {origin} to {destination} is 1 day";
        }
    }
    
}