namespace DesignPatterns.Builder
{
    public class Hamberger : ISandwichBuilder
    {
        Sandwich sandwich = new Sandwich();
        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void SetBread()
        {
           sandwich.Bread = "Hamberger bread";
        }

        public void SetMeat()
        {
            sandwich.Meat = "Ham";
        }

        public void SetSouce()
        {
            sandwich.Souce = "Mayoneise";
        }

        public void SetVegs()
        {
            sandwich.Vegs = "onion, tomato";
        }
    }
}