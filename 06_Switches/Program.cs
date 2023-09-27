//* Switch Statements

//* like 'if-statements' but does away with "branching"

//* 1. value that is being evaluated
//* 2. "value" will be checked w/n the argument of the switch statement (value)
//*     they will be checked by a 'case'
//* 3. "break" to indicate that we want to leave the switch statement
//* 4. "defalut" -> if all else fails then do this


System.Console.WriteLine("Please input your Name...");

//* value to be evaluated...
string name = Console.ReadLine();

//todo: we are going to 'switch' off of this 'name' value

switch (name)
{
    case "Pete":
    case "pete":
    case "PETE":
        System.Console.WriteLine("Hi, Pete!");
        break;
    default:
        System.Console.WriteLine($"Invalid Operation: {name} is Invalid!");
        break;
}

System.Console.WriteLine("How are you feeling (1-5)");
string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        System.Console.WriteLine("I hope your day gets better!");
        break;
    case "2":
        System.Console.WriteLine("Oh sory to hear that.");
        break;
    case "3":
        System.Console.WriteLine("Hope things improve.");
        break;
    case "4":
        System.Console.WriteLine("Good Stuff!");
        break;
    case "5":
        System.Console.WriteLine("Wow, thats great to hear!");
        break;
    default:
        System.Console.WriteLine($"Invalid Operation: {userInput} is Invalid!");
        break;
}