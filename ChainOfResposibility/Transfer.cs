namespace DesignPatterns.ChainOfResposibility
{
    public class Transfer : TransferMoney
    {
        public Transfer(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            requestContext.From.AcountValue -= requestContext.From.MaxDailyValue;
            requestContext.To.AcountValue += requestContext.From.MaxDailyValue;
            
            return new ResponseContext
            {
                Message = " transfer is done"
            };
        }
    }
}