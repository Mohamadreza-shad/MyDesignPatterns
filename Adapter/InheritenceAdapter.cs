namespace DesignPatterns.Adapter
{
    public class InheritenceAdapter : ScreenPrinter, IPrinter
    {
        public void Print(string input)
        {
            this.PrintToScreen(input);           
        }
    }
}