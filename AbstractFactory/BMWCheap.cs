using static System.Console;
namespace DesignPatterns.AbstractFactory
{
    public class BMWCheap : ICar
    {
        public void End()
        {
            WriteLine("BMWCheap End");
            
        }

        public void Start()
        {
            WriteLine("BMWCheap Start");

        }
    }
}