namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        ICar Luxury();
        ICar Cheap();
    }
}