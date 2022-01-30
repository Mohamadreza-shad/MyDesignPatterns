namespace DesignPatterns.AbstractFactory
{
    public class BMWFactory : IAbstractFactory
    {
        public ICar Cheap()
        {
            return new BMWCheap();
        }

        public ICar Luxury()
        {
            return new BMWLuxury();
        }
    }
}