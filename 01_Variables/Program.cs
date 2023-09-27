using System;
Console.Clear();
//* Remember variables are 'containers', In C# we start with the variable 'type' and 
//* then we name it!

//1      //2      //3   //4
string   firstName = "Terry";

//todo: 1 type
//todo: 2 variable name
//todo: 3 assignment operator
//todo: 4 value

Console.WriteLine(firstName);
System.Console.WriteLine("What is your favorite color?");

string color = Console.ReadLine();

System.Console.WriteLine("You said your favorite color is: " + color);

System.Console.WriteLine("I can't remember...what is your name?");

string newName = Console.ReadLine();
System.Console.WriteLine("Ok, so your name is: " + newName); 
