namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            IAbstractFactory prideFactory = new PrideFactory();
            ICar prideCheap = prideFactory.Cheap();
            prideCheap.Start();
            prideCheap.End();
        }
    }
}