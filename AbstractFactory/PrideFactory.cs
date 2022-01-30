namespace DesignPatterns.AbstractFactory
{
    public class PrideFactory : IAbstractFactory
    {
        public ICar Cheap()
        {
            return new PrideCheap();
        }

        public ICar Luxury()
        {
            return new PrideLuxury();
        }
    }
}