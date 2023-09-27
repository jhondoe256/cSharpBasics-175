namespace _09_Inheritance
{
    public class Sloth : Animal
    {
        public Sloth()
        {
            Console.WriteLine("Sloth Constructor.");
        }

        public bool IsSlow     //* this is a read-only property
        {
            get
            {
                return true;
            }
        }

        public override Move()
        {
            Console.WriteLine("The Sloth moves Slowly.");
        }
    }

    public class Megatherium : Sloth
    {
        public Megatherium()
        {
            Console.WriteLine("This sloth is extinct.");
        }

        public override void Move()
        {
            Console.WriteLine("Megatherium uses move! Its not super Effective....");
        }
    }

}