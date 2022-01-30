namespace DesignPatterns.Builder
{
    public class BuilderEntryPoint : EntryPoint
    {
        public override void Ejra()
        {
            var hambergerCreator = new SandwichCreator(new Hamberger());
            hambergerCreator.CreateSandwich();
            var ham = hambergerCreator.GetSandwich();
            System.Console.WriteLine(ham.Bread);

            
            var bandaryCreator = new SandwichCreator(new Bandary());
            bandaryCreator.CreateSandwich();
            var bandary = bandaryCreator.GetSandwich();
            System.Console.WriteLine(bandary.Bread);

        }
    }
}