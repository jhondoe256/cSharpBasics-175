using _09_Inheritance.Contracts;

namespace _09_Inheritance
{
    public class Dragon : Animal
    {
        public Dragon()
        {
            HasFur = false;
            IsMammal = false;
            DietType = DietType.Carnivore;
            Console.WriteLine("This is the Dragon constructor.");
        }

    }

    public class Wyrm : Dragon
    {
        public Wyrm()
        {
            NumberOfLegs = 0;
            System.Console.WriteLine("This is the Wyrm Constructor.");
        }
    }

    public class Hydra : Dragon 
    {
        public Hydra(int headCount = 5)
        {
            HeadCount = headCount;
            System.Console.WriteLine("This is the Hydra Constructor.");
        }
        public int HeadCount { get; set; }

    }

    public class IceDragon : Dragon , IIceShootable
    {
        public void ShootIce()
        {
            Console.WriteLine("I Shoot Ice!!!");
        }
    }

    public class FireDragon : Dragon , IFireable
    {
        public void ShootFire()
        {
            Console.WriteLine("I Shoot Fire!!!");
        }
    }

    public class SuperDuperDragon : Dragon, IIceShootable, IFireable
    {
        public void ShootFire()
        {
              Console.WriteLine("I Shoot Fire!!!");
              //* other functionality....
              System.Console.WriteLine("Fire Storms form!!!!");
        }

        public void ShootIce()
        {
            Console.WriteLine("I Shoot Ice!!!");
              //* other functionality....
              System.Console.WriteLine("Ice Storms form!!!!");
        }
    }
}