using static System.Console;
namespace DesignPatterns.ChainOfResposibility
{
    public class ChainOfResponsibilityEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            Customer from = new Customer()
            {
                AcountValue = 1000,
                IsActive = true,
                MaxDailyValue = 250,
                Password = "1234"
            };

            Customer to = new Customer()
            {
                AcountValue = 500,
                IsActive = true,
                MaxDailyValue = 100,
                Password = "1234"
            };

            var transaction = new CheckIsActive(new CheckPassword(new CheckRemain(new Transfer(null))));
            transaction.Execute(new RequestContext
            {
                From = from,
                Password = "1234",
                To = to,
                Value = from.MaxDailyValue
            });

            WriteLine(from.AcountValue);
            WriteLine(to.AcountValue);
        }
    }
}
    
