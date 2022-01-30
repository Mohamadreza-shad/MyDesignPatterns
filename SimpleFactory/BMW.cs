using static System.Console;
namespace DesignPatterns.SimpleFactory
{
    public class BMW : Car
    {
        public override void End()
        {
            WriteLine("BMW End");
        }

        public override void Start()
        {
            WriteLine("BMW Start");
        }
    }

}