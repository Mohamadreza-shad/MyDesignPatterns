using static System.Console;
namespace DesignPatterns.Adapter
{
    public class ScreenPrinter
    {
        public bool PrintToScreen(string input)
        {
            WriteLine(input);
            return true;
        }
    }
}