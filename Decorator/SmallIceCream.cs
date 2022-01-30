namespace DesignPatterns.Decorator
{
    public class SmallIceCream : IceCream
    {
        public override decimal GetPrice() => 100;
    }
}