namespace DesignPatterns.FactoryMethod
{
    public class BMWFactory : ICarFactory
    {
        public Car CreateInstance()
        {
            return new BMW();
        }
    }
}