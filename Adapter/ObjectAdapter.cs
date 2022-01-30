namespace DesignPatterns.Adapter
{
    public class ObjectAdapter : IPrinter
    {
        private readonly ScreenPrinter _screenPrinter;
        public ObjectAdapter()
        {
            _screenPrinter = new ScreenPrinter();
        }
        public void Print(string input)
        {
            _screenPrinter.PrintToScreen(input);
        }
    }
}