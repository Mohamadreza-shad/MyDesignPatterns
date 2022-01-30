namespace DesignPatterns.Decorator
{
    public class LargeIceCream : IceCream
    {
        public override decimal GetPrice() => 200;
    }
}