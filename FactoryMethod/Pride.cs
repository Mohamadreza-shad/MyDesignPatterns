using static System.Console;
namespace DesignPatterns.FactoryMethod
{
    public class Pride : Car
    {
        public override void End()
        {
            WriteLine("Pride End");
        }

        public override void Start()
        {
            WriteLine("Pride End");
        }
    }
}