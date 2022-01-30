namespace DesignPatterns.Decorator
{
    public class IceCreamWithChocolate : IceCreamDecrator
    {
        private readonly IceCream _iceCream;

        public IceCreamWithChocolate(IceCream iceCream) : base(iceCream)
        {
            _iceCream = iceCream;
        }
        
        public override decimal GetPrice()
        {
            return  _iceCream.GetPrice() * 1.3m;
        }
    }
}