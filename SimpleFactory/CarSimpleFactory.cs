namespace DesignPatterns.SimpleFactory
{
    public class CarSimpleFactory
    {
        public Car GetCar(string carName)
        {
            Car car = null;
            switch (carName.ToLower())
            {
                case "pride":
                    car = new Pride();
                    break;

                case "bmw":
                    car = new BMW();
                    break;
            }
            return car;
        }
    }

}