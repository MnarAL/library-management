// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("my first console app");
// Console.WriteLine("sda") ; 

// string 
string name = "alice"; 
System.Console.WriteLine(name);
// name : variable 
// string : data type
// value : alice 

// integer
int age = 1;
System.Console.WriteLine($"her age is {age}");
//bool 
// true or false

bool hasEmail = true; 
System.Console.WriteLine($"he has an email or not {hasEmail}");

// Console.ReadLine() to get user input 
System.Console.WriteLine("Hey user, please input your age : ");
string userInputAge = Console.ReadLine();

int userInputAgeConvert = Convert.ToInt32(userInputAge);

System.Console.WriteLine($"this is the age of the user input {userInputAge}");

System.Console.WriteLine($"this is the age of the user input {userInputAgeConvert}");

System.Console.WriteLine("Enter  nummer of your level ");
string num =  Console.ReadLine();
int numConvert = Convert.ToInt32(num) ; 
int num3 = numConvert+=5 ; 
System.Console.WriteLine(num3);