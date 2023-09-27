//* Loops -> use these to repeat lines of code.

//* we can have a specific operation, function, and 'wrap' a loop around it

//* While loops

//* define a variable -> this will be used for the while loops "boolean expression"
int number = 0;

//* while 'number' is less than or equal to 100, lets do something....
// while (number <= 100)
// {
//     //* write to the console
//     System.Console.WriteLine(number);

//     //* increment 'number' by one to get out of the 'while-loop'
//     number++;
//     //* ++number;
//     //* number+=1;
// }

//* Infinite loopes (our enemy)
//! while(number == 0)
//! {
//!     System.Console.WriteLine("Oh, s**t!");
//! }

//* we can control the behavior
int value2 = 100;

while (value2 > 0)
{
    value2--; //subtracting by one
    if(value2 == 90)
    {
        System.Console.WriteLine("We are going to 'Jump' out of the loop!");
        break;
    }
    if(value2 == 80)
    {
        System.Console.WriteLine("We are just goning to Return or leave the loop.");
        return;   
    }
    if(value2 == 10)
    {
        Console.WriteLine($"Lets just carry on with the loop. {value2}");
        continue;   //* Just keep going
    }
    Console.WriteLine($"value2: {value2}");
}

System.Console.WriteLine("== Do while ==");

//* do while
//* runs at least once!

do
{
    Console.WriteLine($"Hello World {value2}");
    value2--;
}while (value2 == 101);

string valueString = "Hello";
do
{
    Console.WriteLine($"Hello World {value2}");
    value2--;
}while (valueString == "101");