using static System.Console;

namespace DesignPatterns.Decorator
{
    public class DecoratorEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
          var largeIceCream = new LargeIceCream();
           WriteLine(largeIceCream.GetPrice());

           var mediumIceCream = new MediumIceCream();
           var iceCreamWithSmartis = new IceCreamWithSmartis(mediumIceCream);
           WriteLine(iceCreamWithSmartis.GetPrice());

           var smallIceCream = new SmallIceCream();
           var smallIceCreamWithSmartis = new IceCreamWithSmartis(smallIceCream);
           var smallIceCreamWithSmartisAndChocolate = new IceCreamWithChocolate(smallIceCreamWithSmartis);
           WriteLine(smallIceCreamWithSmartisAndChocolate.GetPrice());

        }
    }
}