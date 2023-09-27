//* Booleans

//* can hold true/false values

bool isCool = false;
//* later on ....
isCool = true;

//todo: Booleans have logical operators
/*
    *   AND
    *   OR
    *   NOT
*/


//* NOT -> THE Negation operator (!), this evalueates the OPPOSITE of the set value
isCool = !isCool;   //* this does the opposite
Console.WriteLine(isCool);   //* false

//* AND
//* C# uses ampersands (&&) to indicate AND statements
//* a single (&) evalueates BOTH  sides always 
//* the (&&) only evaluates the 'right' side if its required

//* OR
//* C# uses (|) to indicate OR statements
//* similar to and the pipe will check both conditions
//* (||) evaluates the first and then the right. 

//* XOR
//* C# uses this character (^) indicate XOR staement

//* --Boolean Operators

bool isTrue = !false;  //true;
bool isFalse = !true;  //false;

//todo: And operator
bool trueAndExample = true && true; //Both sides are true
bool falseAndExample = true && false; //Result is false

//todo: Or Operator
bool trueOrExample = true || false; //Results is true;
bool faseOrExample = false || true; //Restult is true;

//todo: XOR Example
bool trueExclusiveOr = true ^ false; //Result is true b/c one of them is 'true'
bool falseExclusiveOr = true ^ true; // result is false
bool falseExclusiveOr2 = false ^ false; //result false

Console.WriteLine($"NOT False = {isTrue}");
Console.WriteLine($"False and True = {falseAndExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}");
Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

Console.WriteLine(true ^ true);      //output: false
Console.WriteLine(true ^ false);    //output: true
Console.WriteLine(false ^ true);   //output: True
Console.WriteLine(false ^ false); //output: false


//* Comparison operators

//* Equal declare that the values are equal

//* Not Equal  declare that the values are not equal.

//* Greater than (>)

//* Less than (<)

//* Greater than or equal to (>=)

//* Less than or equal to (<=)

bool isGreaterThan = 10 > 10; 
bool isGreaterThanOrEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5<5;
bool isLessThanOrEqualTo= 5 <= 5; 
Console.WriteLine($"5 < 5 is {isLessThan}, and 5 <= 5 is {isLessThanOrEqualTo}");

bool equality = 17 == 19;
bool inequality = 17 != 19;
Console.WriteLine($"17 == 19 is {equality}, and 17 != 19 is {inequality}");




