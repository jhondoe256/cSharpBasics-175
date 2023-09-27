//* what if the 'if' statement didn't work....

//* We need to use : if/else

//* Ex:
bool isRaining = false;

// if(!isRaining)
// {
//     System.Console.WriteLine("I'll cut the grass.");
// }
// else
// {
//     System.Console.WriteLine("I guess I can't cut the grass!");
// }

//another example
bool isGoingOutside = false;

// if(isGoingOutside)
// {
//     System.Console.WriteLine("Make sure to dress for the weather.");
// }
// else
// {
//     System.Console.WriteLine("Sounds like a swater kind of day.");
// }

//* so, lets use else/if:
// if(isGoingOutside)            //* the first condition checked
// {
//     System.Console.WriteLine("Make sure to dress for the weather.");
// }
// else if(isRaining)          //* the second condition checked
// {
//     System.Console.WriteLine("Gosh, it's actually raining?");
// }
// else                  //* this is the 'if all else fails' (default)
// {
//     System.Console.WriteLine("Sounds like a swater kind of day.");
// }

//* lets ask the user how they are feeling (1-5)

//* store a value that can be 'checked' with if/else statements
System.Console.WriteLine("How are you feeling today (1-5).");
string userInput = Console.ReadLine();

if(userInput == "1")
{
    System.Console.WriteLine("I hope your day gets better.");
}
else if(userInput == "2")
{
    System.Console.WriteLine("Oh, sorry to hear that.");
}
else if(userInput == "3")
{
    System.Console.WriteLine("Hope things improve.");
}
else if(userInput == "4")
{
    System.Console.WriteLine("Good Stuff!");
}
else if(userInput == "5")
{
    System.Console.WriteLine("Wow, that's great to hear!");
}
else
{
    System.Console.WriteLine("Invalid Key entry....Please try again later.");
}



