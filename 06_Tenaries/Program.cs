//* Ternary Expressions

//* conditional operator
//*  composed of 3 parts

//* Syntax:

//* 1            //2                    //3
//*  booolean expression  ?    expression if true : expression if false;

//* 3 parts
//* 1. booolean expression to be evaluated
//* 2. signals to the compiler that we are useing a ternary operator
//* 3. seperates the true : false evaluation

System.Console.WriteLine("Enter your age.");

string response = Console.ReadLine();

// int age = int.Parse(response);
int age = Convert.ToInt32(response);

string output = (age >= 18) ? "Lets Party" : "Your too young.";
System.Console.WriteLine(output);

string output2 = (age >= 18) ? (age >=30)? "You may be too old for the club!":"Lets Party" : "Your too young.";
System.Console.WriteLine(output2);


