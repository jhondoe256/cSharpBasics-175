//* Strings

//* Collection of 'char' or characters

//* created with "string values go here...(msg)"

//* 3 ways to make a string
//* 1 Concatination
//* 2 Composite Formatting
//* 3 Interpolation

//todo: Concatination
string first = "The cars we sell are ";
string second = "BMW, Lexus, and Mercedes.";

string concatinatedResult = first + second;
Console.WriteLine(concatinatedResult);

//* Composite Formatting
string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}",firstName,lastName);
Console.WriteLine(compositeResult);

//* String Interpolation
string interpolationResult = $"Her name is still {firstName} {lastName}";
System.Console.WriteLine(interpolationResult);


