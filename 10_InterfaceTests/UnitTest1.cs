using  _10_Interfaces.Fruits;
using System.Collections.Generic;
namespace _10_InterfaceTests;

public class UnitTest1
{
    [Fact]
    public void Calling_InterFace_Methods()
    {
        //* declaring a new interface instance
        //* the "type" will be "IFruit"
        //* We cannot new-up interfaces
        //* but we can make a new Banana()
        IFruit banana = new Banana();

        string output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The Banana is peeled: "+ banana.IsPeeled);

        Assert.True(banana.IsPeeled);
    }

    [Fact]
    public void Interface_Collections()
    {
        Orange orange = new Orange();

        List<IFruit> fruits = new List<IFruit>(){
            new Banana(),
            new Grape(),
            orange
        };

        foreach(IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());
        }

        System.Console.WriteLine(orange.Squeeze());

    }

    //* Helper Method
    private string GetFruitName(IFruit fruit)
    {
        return $"This fruit is called: {fruit.Name}.";
    }

    [Fact]
    public void Interface_In_Methods()
    {
        var grape = new Grape(); 

        var output = GetFruitName(grape);

        Assert.True(output.Contains("This fruit is called: Grape."));
    }

    [Fact]
    public void Type_Of_Instance()
    {
        var fruitSalad = new List<IFruit>
        {
            new Orange(true),
            new Orange(),
            new Grape(),
            new Orange(),
            new Banana(true),
            new Grape()
        };

        System.Console.WriteLine("Is the orange Peeled?");
        foreach(IFruit fruit in fruitSalad){
            //* 'is' -> a more modern way to 'type-cast' something
            if(fruit is Orange orange)
            {
                if(orange.IsPeeled)
                {
                    System.Console.WriteLine("Is a peeled orange.");
                }else
                {
                    System.Console.WriteLine("Is a orange.");
                }
            }
            else if (fruit.GetType() == typeof(Grape))
            {
                System.Console.WriteLine("Is a grape.");
            }
            else if(fruit.IsPeeled)
            {
                System.Console.WriteLine("You peeled the Banana.");
            }
            else
            {
                System.Console.WriteLine("It's a Banana.");
            }
        }
    }
}

// Pattern Matching
    // Another way to demonstrate checking types is with Pattern Matching
    // Docs: https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
    // This is basically the same way we did the first if (fruit is Orange orange)