using static System.Console;

namespace DesignPatterns.Proxy
{
    public class RealNest : INest
    {
        public void AccessToNest(string name)
        {
            WriteLine($"the {name} can enter the nest");
        }
    }
}