namespace DesignPatterns.SimpleFactory
{
    public class SimpleFactoryEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            var carFactory = new CarSimpleFactory();
            Car pride = carFactory.GetCar("pride");
            Car BMW = carFactory.GetCar("BMW");
            pride.Start();
            pride.End();
            BMW.Start();
            BMW.End();
        }
    }

}