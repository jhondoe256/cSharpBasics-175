namespace _10_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public Banana() { }

        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        //* public string Name => "Banana";

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the Banana.";
        }
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public bool IsPeeled { get; private set; }
        public string Name => "Orange";
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the Orange.";
        }

        public string Squeeze()
        {
            return "You squeezed the orange, and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name => "Grape";

        public bool IsPeeled => false;

        public string Peel()
        {
            return "Who peels Grapes.";
        }

    }
}