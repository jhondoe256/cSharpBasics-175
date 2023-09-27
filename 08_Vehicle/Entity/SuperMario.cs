namespace _08_Vehicle.Entity
{
    public class SuperMario
    {
        public int Lives { get; set; } = 3;
        public float Speed { get; set; } =3.7f;
        public Powerup Powerup { get; set; }

        public void PoweredUp()
        {
            Random rnd = new Random();
            Thread.Sleep(500);
            int PoweredUpValue = rnd.Next(0,3);

            switch(PoweredUpValue)
            {
                case 1:
                System.Console.WriteLine("You activated the Fire Flower!!!");
                break;
                case 2:
                System.Console.WriteLine("You activated the Ice Flower");
                break;
                default:
                System.Console.WriteLine("You activated the Mushroom....BIG....");
                break;
            }
        }
    }
}