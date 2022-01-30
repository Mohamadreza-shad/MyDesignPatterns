using static System.Console;
namespace DesignPatterns.AbstractFactory
{
    public class PrideLuxury : ICar
    {
        public void End()
        {
            WriteLine("PrideLuxury End");
        }

        public void Start()
        {
            WriteLine("PrideLuxury Start");
        }
    }
}