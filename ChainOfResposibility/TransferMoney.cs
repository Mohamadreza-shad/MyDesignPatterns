namespace DesignPatterns.ChainOfResposibility
{
    public abstract class TransferMoney
    {
        protected readonly TransferMoney _succesor;

        public TransferMoney(TransferMoney succesor)
        {
            _succesor = succesor;
        }

        public abstract ResponseContext Execute(RequestContext requestContext);
    }
}