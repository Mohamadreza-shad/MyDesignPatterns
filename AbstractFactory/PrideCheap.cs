using static System.Console;
namespace DesignPatterns.AbstractFactory
{
    public class PrideCheap : ICar
    {
        public void End()
        {
            WriteLine("PrideCheap End");
        }

        public void Start()
        {
            WriteLine("PrideCheap Start");
        }
    }
}