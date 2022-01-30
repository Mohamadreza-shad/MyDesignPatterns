namespace DesignPatterns.TemplateMethod
{
    public class TemplateMethodEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            PizzaBacker pizza = new Pepperoni();
            pizza.PrepareBread();
            pizza.PrepareIngredients();
            pizza.Combination();
            pizza.Bake();
            pizza.PackAndSend();
        }
    }
}