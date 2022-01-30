namespace DesignPatterns.Builder
{
    public class SandwichCreator
    {
        public ISandwichBuilder _sandwichBuilder { get; set; }
        public SandwichCreator(ISandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void CreateSandwich()
        {
            _sandwichBuilder.SetBread();
            _sandwichBuilder.SetMeat();
            _sandwichBuilder.SetSouce();
            _sandwichBuilder.SetVegs();
        }

        public Sandwich GetSandwich()
        {
            return _sandwichBuilder.GetSandwich();
        }
    }
}