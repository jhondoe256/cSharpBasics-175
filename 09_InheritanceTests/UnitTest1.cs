using _09_Inheritance;
namespace _09_InheritanceTests;

public class UnitTest1
{
    private Cat cat;

    public UnitTest1()
    {
        cat = new Cat();
    }

    [Fact]
    public void Create_A_Cat_Should_Return_All_Info()
    {
        //* AAA setup

        //* Arrange -> initial Setup
        Cat cat = new Cat();
        cat.ClawLength = 44.25d;

        //* Act ->  the actual actions that need to be tested
        double expected = cat.ClawLength;

        cat.MakeSound();
        cat.Move();

        //* Assert -> Check to see if our expected result 'work'
        Assert.Equal(expected,cat.ClawLength);
    }

    [Fact]
    public void Create_A_Tabby_Cat()
    {
        //* Arrange
        TabbyCat cat = new TabbyCat();
        cat.NumberOfLegs = 3;
        cat.ClawLength = 2.2d;
        cat.Move();
        cat.MakeSound();

        //* Act
        Type expected = cat.GetType();

        //* Assertion
        Assert.Equal(expected,typeof(TabbyCat));

    }
}