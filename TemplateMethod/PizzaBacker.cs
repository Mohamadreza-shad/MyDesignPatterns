namespace DesignPatterns.TemplateMethod
{
    public abstract class PizzaBacker
    {
        public void PrepareBread(){}
        public abstract void PrepareIngredients();
        public void Combination(){}
        public abstract void Bake();
        public abstract void PackAndSend();
        
    }
}