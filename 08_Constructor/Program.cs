using _08_Constructor;

//* There is no argument given that corresponds to the required parameter 'donutType' of 'Donut.Donut(string)
Donut doug = new Donut("Creme Filled");
System.Console.WriteLine(doug); 

//*if _donutType is (private)
//* 'Donut._donutType' is inaccessible due to its protection level

System.Console.WriteLine(doug._donutType); 