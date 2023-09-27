namespace _09_Inheritance
{
    public class Cat : Animal
    {
        public Cat()
        {
            System.Console.WriteLine("This is the Cat constructor.");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }

        public double ClawLength { get; set; }

        public virtual void MakeSound()
        {
            System.Console.WriteLine("Meow.");
        }

        //* using the 'override' keyword
        public override void Move()
        {
            System.Console.WriteLine($"This {GetType().Name} moves quickly.");
        }
    }

    public class TabbyCat: Cat
    {
        public TabbyCat()
        {
            System.Console.WriteLine("This is the Tabby Cat constructor.");
        }

        public override void MakeSound()
        {
            // base.MakeSound();  //-> this allows us to have our parent methods behavior
            System.Console.WriteLine("Purr...");
        }
    }
}