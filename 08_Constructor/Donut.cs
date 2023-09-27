//* Constructor -> what we use to "new-up" a version of the object
//* "versions" -> called "Overloads"

//* Syntax of a constructor (ctor)

//* 1. Access Modifier -> public, private, internal, protected (inheritance)
//* 2. Name of the Type -> our Donut (in this case)
//* 3. A pair of paranthesis that can contain parameters
//* 4. The 'body' that executes the code.


namespace _08_Constructor
{
    public class Donut
    {
        //* public field -> a variable that lives w/n a class
        public string? _donutType;

//*        1     2        3 = these are the "values" that the user will pass in 
        public Donut(string donutType)
        {
//*               4 body
            _donutType = donutType;
        }

        // public Donut()
        // {
            
        // }
    }
}