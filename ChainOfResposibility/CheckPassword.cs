using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResposibility
{
    public class CheckPassword : TransferMoney
    {
        public CheckPassword(TransferMoney succesor) : base(succesor)
        {
        }

        public override ResponseContext Execute(RequestContext requestContext)
        {
            if(requestContext.Password == requestContext.From.Password)
                _succesor.Execute(requestContext);

            return new ResponseContext
            {
                Message = "Invalid password"
            };
        }
    }
}