namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            var prideFactory = new PrideFactory();

            Car pride = prideFactory.CreateInstance();
            pride.Start();
            pride.End();

            var bmwFactory = new BMWFactory();
            Car bmw = bmwFactory.CreateInstance();
            bmw.Start();
            bmw.End();
        }
    }
}