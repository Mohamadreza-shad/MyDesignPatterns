namespace DesignPatterns.Decorator
{
    public class IceCreamWithSmartis : IceCreamDecrator
    {
        private readonly IceCream _iceCream;

        public IceCreamWithSmartis(IceCream iceCream) : base(iceCream)
        {
            _iceCream = iceCream;
        }
        public override decimal GetPrice()
        {
            return _iceCream.GetPrice() * 1.2m;
        }
    }
}