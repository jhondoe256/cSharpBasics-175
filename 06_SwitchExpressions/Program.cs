//* Switch Expressions:

//* Syntax
//*  value being evalueate, often be a variable
//*  The switch keyword
//*  A body that contains 'cases', called "expression arms", denoted by {}
//*  Commas will seperate the "experession arms"
//*  Made up of 3 parts

//* 1. The expected value, called a "Pattern"
//* 2. The "Fat Arrow", denoted as  '=>'
//* 3. The actual expression (the value returned)
//* 4. '_', this is the default

System.Console.WriteLine("Please enter a user name");
string userName = Console.ReadLine();

string greeting = userName switch
{
  "Pete" or
  "P-e-t-e" or
  "pete" => "Hello, Pete!",   //* => "message" we are 'returning' the value of message.
  _=>"Who are you?"  
};

System.Console.WriteLine(greeting.ToUpper());  //* makes everything w/n the string uppercased. 

//* Challenge 
//* We have 2 questions in our code:
//* "How are you feeling today?
//* "How were you feeling yesterday?

//* we got 2 variables
//* feelingRating
//* yesterdayRating

//* The challenge is to compare these two values and display how much better or worse 
//* they are feeling today than yesterday.

//* you don't have to use switch expressions for this challenge.
//* use whatever works for you.

//* Tools you should think about using:
//* Converting strings to numbers
//* Comparison Operators
//* Conditionals