using static System.Console;
namespace DesignPatterns.AbstractFactory
{
    public class BMWLuxury : ICar
    {
        public void End()
        {
            WriteLine("BMWLuxury End");
        }

        public void Start()
        {
            WriteLine("BMWLuxury Start");
        }
    }
}