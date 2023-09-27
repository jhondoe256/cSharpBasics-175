using System.Linq;
using System;

//* Methods

//* These are usually in classes, but we will explore them here (functional programming)

//* Perform samll modular tasks

//* They can give us something back (returned value)

//* They can give us 'nothing' back (void) 

/*
*     1      2        3         4 
*    public void SayHello(string Name)
*   {
*               5
*        Console.WriteLine(Name);
*   }
*/

//* 1. Access Modifier (4) public (every class and assembly can use this),
//*                        private(only used within "Object/Class" scope),
//*                        internal(can be accessed within the current assemblies "Classes") ,
//*                        protected(inherited Members have access to 'private' values)

//* 2. 'return type' -> what we are giving back after we perform some work

//* 3. Method Name -> what we call the method

//* 4. Method Parameters -> this is the data that will be 'passed-into' the method
//*                        this could be a calculation that is being done to the data

//todo:  Method Name + Parameters 'SayHello(string Name)' = Method Signature
//todo:                            SayHello(string Name, int Age)  //different Method signature (compiler :))

//*5  Method Body -> So, where the 'work' of the "Method-Machine" will happen

//* this method only works if you pass in a variable container of type 'string'
void SayHello(string name)
{
    System.Console.WriteLine(name);
}

//* Method in action...
SayHello("Bill Esquire");
SayHello("Ted Theodore Rogan");

//* Sometimes methods have no parameters
void Greeting()
{
    System.Console.WriteLine("Hello!");
}

Greeting();
Greeting();
Greeting();

//* Add 2 int together -> 2 parameters (b/c we are scafolding this method)
int AddMe(int valueA, int valueB)
{
    int sum = valueA + valueB;
    return sum;
    // return valueA+valueB;
}

System.Console.WriteLine(AddMe(3,5));

//* When we are using methods with return types, we can store them into a variable
//* A VARIABLE IS NOTHING MORE THAN A CONTAINER -> A BOX THAT HOLDS STUFF

int sum = AddMe(10,2);

//* so lets use this

System.Console.WriteLine(AddMe(sum,sum));


//* subtraction

int SubtractMe(int valueA, int valueB)
{
    return valueB - valueA;
}

System.Console.WriteLine(SubtractMe(10,20));

int SubtractMeDouble(double valueA, double valueB)
{
    return Convert.ToInt32(valueB - valueA);
}

System.Console.WriteLine(SubtractMeDouble(10.5,20.5));

//* Squared

double SquareMe(int value)
{
    return value * value;
}

System.Console.WriteLine(SquareMe(3));

System.Console.WriteLine(SquareMe(AddMe(sum,3)));

//* Something Crazy

int CrazyMath_AddUs(params int[] values)
{
    // //* this is where we will start
    int grandTotal = 0;

    foreach(int value in values)
    {
        grandTotal+=value;
    }
    return grandTotal;
    // return values.Sum();
}

int grandTotal = CrazyMath_AddUs(100,1000,300,3,20,12,1400);
System.Console.WriteLine(grandTotal);

string[] availableGreetings = {
        "Hello",
        "Howdy",
        "Hola",
        "Yo",
        "Greetings"
    };

    string[] availableGreetings2 = {
        "Hello World",
        "Heres Johnny",
        "Greetings"
    };
    
void GetRandomGreeting(string[] Greetings)
{
    Random _random = new Random();
    
    int randomNumber = _random.Next(0,Greetings.Length);
   
    string randomGreeting = Greetings[randomNumber];
   
    System.Console.WriteLine($"{randomGreeting}");
}

GetRandomGreeting(availableGreetings);
GetRandomGreeting(availableGreetings2);

