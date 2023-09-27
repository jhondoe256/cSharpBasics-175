using _08_Properties;

Donut donut = new Donut();

//* write-only
donut.Filling = "Ice Cream";

//* read-only
System.Console.WriteLine(donut.Filling);

donut.Topping = "Sprinkles";
donut.IsSpecial = false;
donut.Price = 1.98m;

System.Console.WriteLine(donut.Topping);
System.Console.WriteLine(donut.IsSpecial);
System.Console.WriteLine(donut.Price);

Donut myDonutA = new Donut();
Donut myDonutB = new Donut("Strawberry","Strawberry Filling","N/A",true,30.00m);

System.Console.WriteLine(myDonutA.GetDonutType());
System.Console.WriteLine(myDonutB.GetDonutType());
System.Console.WriteLine(myDonutA.Price);
System.Console.WriteLine(myDonutB.Price);

//* every Object comes with some methods: 
//* GetType() ,typeof(), ToString() 

System.Console.WriteLine(myDonutA.ToString());
System.Console.WriteLine(myDonutB.ToString());
