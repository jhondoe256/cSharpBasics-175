using System.Collections.Generic;  // List<T> 
using System;
using System.Linq;

//! WE DON'T DO THIS ANYMORE!!!!
object[] stuff = new object[5];
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 42.75f;
stuff[3] = "Bill Bob";

foreach(var item in stuff)
{
    System.Console.WriteLine(item);
}

//* We need type safety  -> No mixing "Strongly Typed"
string stringExample = "Hello World";

//* Arrays are "Fixed" Values 
//* they ALWAYS start at the index of 0!
//* When it comes to "data retrival" its VERY QUICK!
//* But when it comes to 'copying and moving' IT SUCKS!

//* Array of type 'string' -> object initialization, no need to specify the direct count
string[] stringArray = 
{
    "Hello",
    "World",
    "is it",
    "Always",
    stringExample,
    "?"
};

System.Console.WriteLine(stringArray.Length);  //* .length {get} (readonly) and it will retrive the total count w/n an Array.

//* Lets access some data
System.Console.WriteLine(stringArray[3]);   //* prints 'Always'

System.Console.WriteLine(stringArray[0]);   //* prints 'Hello'

//* What if we want to 'over-write' any values?
stringArray[1] = "Hey there";
System.Console.WriteLine(stringArray[1]);

//* List<T> -> 'T' is a "Generic Type", this "list" collection can be of any Generic Type
List<string> listOfStrings = new List<string>();


//* only holds integers
List<int> listOfIntegers = new List<int>();

//* .Add()  => Allows us to 'add' to our collection
listOfStrings.Add("Tj");
listOfStrings.Add("James");
listOfStrings.Add("Jed");

listOfIntegers.Add(4455);

//* let's access the list of strings
System.Console.WriteLine($"listOfStrings[0]: {listOfStrings[0]}");

//* .Remove() -> this will remove an item from List<T>
int Tj = listOfStrings.IndexOf("Tj");  //*.IndexOf =>returns the 'index' value (int)

System.Console.WriteLine(Tj);

listOfStrings.Remove(listOfStrings[listOfStrings.IndexOf("Tj")]); //* .Remove() -> returns true/false

List<string> stuff2 = new List<string>{
    "Item1",
    "Item2"
};

//* .AddRange() => allows us to add a list of things "all at once"
listOfStrings.AddRange(stuff2);
System.Console.WriteLine(listOfStrings);

//* System.Collections.Generic.List`1[System.String] => you have to 'iterate' or 'loop' through this object to see the data
foreach(string str in listOfStrings)
{
    System.Console.WriteLine(str);
}

//* .RemoveAll(<predicate>) -> this will remove items from List<T> 'Callback'
listOfStrings.RemoveAll(x => x.Contains("Item"));  //* .Contains => returns true/false
System.Console.WriteLine(listOfStrings.Count()); //* .Count() displays how many items are in the collection

//* Removal Results:
foreach(string str in listOfStrings)
{
    System.Console.WriteLine(str);
}

//* Queue<T>
//* F.I.F.O => First In First Out
//* Whoever is "first in line" gets "serviced first"

//* new Queue<string>() => we are "Constructing" a new item in memory. Storing it on the "Heap".
Queue<string> firstInFirstOut = new Queue<string>();

//* add to the queue => .Enqueue(value<T>)  .Enqueue("string value")
firstInFirstOut.Enqueue("I'm First");
firstInFirstOut.Enqueue("I'm Second");

//* See who's next in line .Peek() -> returns whos next in line, doesn't change the collection.
string firstIn = firstInFirstOut.Peek();
System.Console.WriteLine(firstIn);

//* to service 'who's in line' we use the .Dequeue()
//* get rid of the first one
firstInFirstOut.Dequeue();
System.Console.WriteLine("------------------------");
firstIn = firstInFirstOut.Peek();  //* "I'm second"
System.Console.WriteLine(firstIn);

//* if you use the .Peek(), make sure to check the collection count
//* it does not account for zero, if no items in the collection it will "blow up"
if(firstInFirstOut.Count() > 0)
{
    firstInFirstOut.Dequeue();
}else
{
    System.Console.WriteLine("Sorry there are no items available!");
}

//* Dictionary<key,Value>  
//* Can't have the same 'key'
//* When it comes to iterating or looping through a dictionary we can constrain them by 'key' or 'value'
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//* .Add(key,value)
keyAndValue.Add(1,"Terry");
keyAndValue.Add(2,"Tj"); 
//* keyAndValue.Add(1,"Tj");   //Error: item with the same key has already been added. Key: 1

//* looping through with 'no constraints'
foreach(KeyValuePair<int,string> values in keyAndValue )
{
    System.Console.WriteLine(values);
}

//* looping thorugh with 'key constraints'
foreach(int key in keyAndValue.Keys)
{
    System.Console.WriteLine(key);  //* this gives back the 'value of the key'
}

//* looping thorugh with 'value constraints'
foreach(string value  in keyAndValue.Values)
{
    System.Console.WriteLine(value); //* this gives back the 'value of the values'
}

string terry = keyAndValue[1]; //* access the values just like an array but passin the 'key'
System.Console.WriteLine(terry);

//* Honorable mentions :
SortedList<int,string> sortedKeyValuePair = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFirstOut = new Stack<string>(); 

//* And just to be Random....

//* Random 'class' -> based on cpu clock ticks

Random rnd = new Random();

//* first number '5' is 'inclusive and the last number '20' is exclusive, so 5-19.
int number = rnd.Next(5,20);
System.Console.WriteLine(number);