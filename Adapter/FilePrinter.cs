namespace DesignPatterns.Adapter
{
    public class FilePrinter : IPrinter
    {
        public void Print(string input)
        {
            System.IO.File.WriteAllText(@"E:\Projects\DesignPatterns\output.txt",input);
        }
    }
}