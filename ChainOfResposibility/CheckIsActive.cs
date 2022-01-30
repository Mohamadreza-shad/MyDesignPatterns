using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResposibility
{
    public class CheckIsActive : TransferMoney
    {
        public CheckIsActive(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if(requestContext.From.IsActive)
                _succesor.Execute(requestContext);

            return new ResponseContext
            {
                Message = "User is not active"
            };
        }
    }
}