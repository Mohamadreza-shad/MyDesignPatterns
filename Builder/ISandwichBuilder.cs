namespace DesignPatterns.Builder
{
    public interface ISandwichBuilder
    {
        void SetBread();
        void SetMeat();
        void SetSouce();
        void SetVegs();
        Sandwich GetSandwich();
    }
}