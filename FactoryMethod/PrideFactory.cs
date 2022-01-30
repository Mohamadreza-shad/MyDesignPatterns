namespace DesignPatterns.FactoryMethod
{
    public class PrideFactory : ICarFactory
    {
        public Car CreateInstance()
        {
            return new Pride();
        }
    }
}