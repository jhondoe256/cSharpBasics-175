//* C# operators

//* addition(+)

//* subtraction(-)

//* multiplication(*)

//* division(/)

//* remainder [Modulus,Mudulo] (%)

//* unary Operators
//* Ex: increment++ (counting up by one)
//* Ex: decrement-- (counting down by one)

//* lets assume that we have a 'studentCount' variable container that holds 30 students;
int studentCount = 30;

//todo: lets add one to the studentCount
//* this addition happens 'after the fact' -> add the value second!!!!
studentCount++;
System.Console.WriteLine(studentCount);

//* so add the value first!!!
++studentCount;
System.Console.WriteLine(studentCount);

//* decrement
studentCount--;
--studentCount;

//* addition
int additionResult = 5+2;
System.Console.WriteLine("5+2= " + additionResult);

//* subtraction 
int subtractionResult = 5-2;
System.Console.WriteLine("5-2= "+subtractionResult);

//* multiplication 
int multiplicationResult = 5*2;
Console.WriteLine("5*2= " + multiplicationResult);

//* division
int divisionResult = 10/2;
Console.WriteLine("10/2= "+ divisionResult);

//* Modulus -> this gives back the 'remainder' value
Console.WriteLine(10%2);
Console.WriteLine(10%9);
Console.WriteLine(16%3);
Console.WriteLine(19%5);