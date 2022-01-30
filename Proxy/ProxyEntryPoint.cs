namespace DesignPatterns.Proxy
{
    public class ProxyEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            NestProxy proxy = new NestProxy(new RealNest());
            proxy.AccessToNest("sheep");
        }
    }
}