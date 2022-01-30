namespace DesignPatterns.Decorator
{
    public abstract class IceCreamDecrator : IceCream
    {
        private readonly IceCream _iceCream;

        public IceCreamDecrator(IceCream iceCream) : base()
        {
            _iceCream = iceCream;
        }
        
        public override decimal GetPrice()
        {
            return _iceCream.GetPrice();
        }
    }
}