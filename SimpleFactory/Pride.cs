using static System.Console;
namespace DesignPatterns.SimpleFactory
{
    public class Pride : Car
    {
        public override void End() => WriteLine("Pride End");
        public override void Start() => WriteLine("Pride Start");
    }

}