using System;
Console.Clear();

//todo: Bronze
//*  For this challenge go ahead and create a list of variables using the following 
//* data types: int ,string ,bool ,decimal ,float ,double , and ulong (can only be positive) .

//*  For each of these types, do the following:
//*  Make at least two examples for each type
//*  Make one a declaration only    
//*  Declare and initialize the other

//* Make one a declaration only    
int myInt;
//* Declare and initialize the other
myInt = 20;

string myString;
myString = "Hello";

bool myBool;
myBool = true;

decimal myDecimal;
myDecimal = 33.14m;

float myFloat;
myFloat = 1.24f;

double myDouble;
myDouble = 22.3478d;

ulong myULong;
myULong = 100000000000;

//* Once you have your variables, go ahead and print some of these values to the console.
System.Console.WriteLine("myULong: " + myULong);
System.Console.WriteLine("myDouble: " + myDouble);
System.Console.WriteLine("myString: " + myString);
System.Console.WriteLine("myint: " + myInt);
System.Console.WriteLine("myFloat: " + myFloat);
System.Console.WriteLine("myFloat: " + myBool);

//todo: silver
//* Concatenate two string variables. If you don't remember how to do that,
//* check the Microsoft Docs here (Links to an external site.).
//* -> Hello, How are you? 
string stringConcatination = myString + " How are you?";
System.Console.WriteLine(stringConcatination);
//* Next, try to concatenate a number with a string as well and see what happens.
//* My favorite number is: 20.
string strConcat2 = "My favorite number is: " + myInt + ".";
//* Finally, print the results to the console.
System.Console.WriteLine(strConcat2);

//todo: Gold
//* Create an  variable to hold a year.
int year = 2020;
//* ask the user to enter a string value that represents a year (whole number)
Console.WriteLine("Please enter a string value that represents a year (whole number)");

//* The catch for this challenge is that you want to gather the value for the year as an int .
//* Your task will be to research how to convert a string to an integer in C#.
string userInput = Console.ReadLine();      //* (Console.ReadLine()) gives back what the user types in the terminal.
                                            //* returns a string, so the variable container has to be of type
                                            //* 'string'
int intConversion = int.Parse(userInput);  //*(int.Parse()) this gives back the 'interger' version of the value passed in

//* Once you have accomplished this, display the year in the console.
System.Console.WriteLine("You input the year of: " + intConversion);
