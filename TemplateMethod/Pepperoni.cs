namespace DesignPatterns.TemplateMethod
{
    public class Pepperoni : PizzaBacker
    {
        public override void Bake()
        {
            throw new System.NotImplementedException();
        }

        public override void PackAndSend()
        {
            throw new System.NotImplementedException();
        }

        public override void PrepareIngredients()
        {
            throw new System.NotImplementedException();
        }
    }
}