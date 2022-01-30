namespace DesignPatterns.Adapter
{
    public class AdapterEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            string input = "Hi there";
            
            IPrinter filePrinter = new FilePrinter();
            filePrinter.Print(input);

            ScreenPrinter screenPrinter1 = new ScreenPrinter();
            screenPrinter1.PrintToScreen(input);

            IPrinter screenPrinter = new ObjectAdapter();
            screenPrinter.Print(input);

            IPrinter inheritancePrinter = new InheritenceAdapter();
            inheritancePrinter.Print(input);
        }
    }
}