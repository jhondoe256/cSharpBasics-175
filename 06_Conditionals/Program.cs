//* Conditionals

//* Handels decision making...

//* Anytime we want our application to do work based on an condition(true/false)

bool isRaining = true;
bool isGoingOutside = false;

/*
*   if statements:
?   formula:

*    if(boolean expression)
*    {
*       so, if  boolean expression evaluates to 'true' then this code block will run...        
*    }
*/

if(isRaining)
{
   System.Console.WriteLine("It's raining out!"); 
}

if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring out an umbrella.");
}


//* OR
if(isRaining || isGoingOutside)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

if(!isRaining || isGoingOutside == false)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

//* branching -> (isRaining && isGoingOutside)
if(isRaining)
{
    if(isGoingOutside)
    {
        System.Console.WriteLine("Better bring out an umbrella.");
    }
}


//* XOR 
if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will go outside if it's not raining.");
}


//* Challenge
//* write an if statement that uses a new boolean called 'hasUmbrella' that will display text
//* to the Console if the user has an umbrella and is going outside while it's raining.
//* Example of expected output:
//*  Good thing I have my umbrella so I can go outside while it's raining!