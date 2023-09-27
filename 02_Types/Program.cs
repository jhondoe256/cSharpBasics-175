using _02_Types.TestMe;

//* C# Types
Console.Clear();
//* Variable naming conventins:
//* camel-cased : 'camelCased' first letter is lower cased all appeded words are Capitalized

//* bool (Boolean)-> true/false, 0/1, Yes/No
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//* integers -> whole numbers
int age = 20;
//cw, tab
System.Console.WriteLine(age);

//* decimal -> very percise (used mainly for $$$)
//* we need the 'suffix' of 'm' or 'M'
decimal accountBalance = 90_000m;
System.Console.WriteLine(accountBalance);

//* integers
int i = 0;                         //* 32bit interger value
short sh = 32767;                  //* 16bit integer value
Int16 anotherShortEx = 32000;     //*  16bit integer value
byte by = 255;                    //*  a group of binary digits (usually eight) operated as a unit;

//* strings -> these are nothing but a 'collection' of 'characters' (char)
string s = "hey!";
System.Console.WriteLine(s.Length);    //* the 'String' obj itself has its own Methods/properties 'length' is a property

//* char -> a single character
char c = 'i';
System.Console.WriteLine(c);

string s2 = @"f:\tree";  //* use the @ to acceess/storing a directory (relative path)

//* bool 
bool b = false;  //* true/false

long L = 7;                          //* this is a LARGE INTEGER VALUE
                                     //* -9Q - 9Q (data science)

decimal d = 99.999999m;           //* 'm' or 'M' at the end, 128 bit percision, 28-29 decimal places

double db = 7.8000d;             //* 'd' at the end (optional) [defalut], 15-16 digits after the decimal point

float f = 10.8f;               //* 'f' at the end, half the size of a double, the least percise

//* dealing with decimals
//* these values should truncate
System.Console.WriteLine(1.25878058705150144511210841f);
System.Console.WriteLine(1.25878058705150144511210841d);
System.Console.WriteLine(1.25878058705150144511210841m);

//* DateTime
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTime birthday = new DateTime(1972, 06, 20);
System.Console.WriteLine(birthday);

//* Enums -> types that are represented by numbers
PastryType myPastry = PastryType.Cake;
PastryType anotherOne = PastryType.Croissant;

System.Console.WriteLine("I Like " + myPastry + " and " + anotherOne); //* Concatination

BlandObj obj = new BlandObj();

obj.PastryType = myPastry;
System.Console.WriteLine(obj.PastryType);