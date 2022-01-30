using static System.Console;

namespace DesignPatterns.Proxy
{
    public class NestProxy : INest
    {
        private readonly RealNest _realNest;
        public NestProxy(RealNest realNest)
        {
            _realNest = realNest;
        }
        public void AccessToNest(string name)
        {
            if(HasAccess(name)) 
                _realNest.AccessToNest(name);
            else    
                WriteLine($"the {name} can not enter the nest");
        }

        public bool HasAccess(string name)
        {
            if(name == "Lion") return false;
            return true;
        }
    }
}