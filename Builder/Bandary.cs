namespace DesignPatterns.Builder
{
    public class Bandary : ISandwichBuilder
    {
        Sandwich sandwich = new Sandwich();
        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void SetBread()
        {
           sandwich.Bread = "Barbary";
        }

        public void SetMeat()
        {
            sandwich.Meat = "Susage";
        }

        public void SetSouce()
        {
            sandwich.Souce = "Kechup";
        }

        public void SetVegs()
        {
            sandwich.Vegs = "onion";
        }
    }
}