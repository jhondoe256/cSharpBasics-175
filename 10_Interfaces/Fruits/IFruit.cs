//todo: This is a "HAS A" relationship
//todo: This is a CONTRACT
//todo: I don't care what you do, JUST Implement the contract
//todo: Interfaces are ALWAYS public

namespace _10_Interfaces.Fruits
{
    public interface IFruit
    {
        string Name {get;}  //* we only want this to be 'read-only'
        bool IsPeeled {get;}
        string Peel();
    }
}