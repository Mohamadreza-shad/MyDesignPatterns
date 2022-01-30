using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResposibility
{
    public class CheckRemain : TransferMoney
    {
        public CheckRemain(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if(requestContext.Value < requestContext.From.AcountValue)
                _succesor.Execute(requestContext);

            return new ResponseContext
            {
                Message = "Invalid Remain"
            };
        }
    }
}