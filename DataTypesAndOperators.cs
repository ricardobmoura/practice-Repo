/*****************************************************************************************************
 * 
 * miche_kh@lasallecollege
 * Datatypes in C#
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
 * C/C++ --> bool, char, byte, short, int, long, float, double 
 * C# equivalent types --> Bool, Char, Byte, Int16, Int32, Int64, Single, Double, ... 
 * 
*****************************************************************************************************/


Console.WriteLine("To store data (true, false, 1, 0, -1, 5.5, -700.8590, \"programming\"...), we need to allocate space in memory." + // notice the escape sequence in front of each " 
    "Data going into memory is like a car going into a parking spot" +
    "A bicycle goes into an XS space,\n" +
    "a motorcyle into a S space,\n" +
    "a car into a M space,\n" +
    "an SUV, a van, etc. into a L space,\n" +
    "a bus into an XL space, and finally\n" +
    "a truck into an XXL space, and so on.\n\n");

Console.WriteLine("The same applies to data!\n" +
    "In order to store a piece of data in memory, we need to know exactly how much space it needs to fit comfortably.\n" +
    "Data of type ... requires ... bytes in memory: \n" +
    "\t     bool\t   "+ sizeof(bool) + "\n" +
    "\t     char\t   " + sizeof(char) + "\n" +
    "\t     byte\t   " + sizeof(byte) + "\n" +
    "\t     short\t   " + sizeof(short) + "\n" +
    "\t     int\t   " + sizeof(int) + "\n" +
    "\t     long\t   " + sizeof(long) + "\n" +
    "\t     float\t   " + sizeof(float) + "\n" +
    "\t     double\t   " + sizeof(double) + "\n" +
     
    "We neither want to waste space by allocating more than the data needs, nor do we want to to lose data by allocating less space than it actually needs.\n" +
    "To let the compiler and the OS allocate the space, we need to let them know the type of data we want to store.\n" +
    "This happens with declaration. The syntax to declare a variable (space in memory that will hold a value) is as follows:\n" +
    "datatype varName; // decalaration, allocating space in memory, reserving a parking spot, it remains empty\n" +
    "datatype varName = value; // declaration and initialization, allocating space in memory AND putting a value in it, reserving a parking spot AND parking the car in it!\n");


// bool
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool

Console.WriteLine("The Boolean type -- short for boolean");
Console.WriteLine("----------------------------------\n");

Console.WriteLine("The bool type contains two values: true and false (by default)\n" +
                    "It does not have a definition for MinVal and MaxVal.\n" + 
                    "Instead, it has a FalseString and a TrueString.\n");
Console.WriteLine("bool.FalseString = " + bool.FalseString);
Console.WriteLine("bool.TrueString = " + bool.TrueString);
Console.WriteLine("sizeof(bool) = " + sizeof(bool) + " byte(s)");
Console.WriteLine("\n");


// char
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
Console.WriteLine("The Char type -- short for character");
Console.WriteLine("------------------------------------\n");

Console.WriteLine("There are 65,535 characters. Each character has a numerical, hexadecimal, and unicode representation\n." +
                    "Character literals (A, \\u+dddd, \\x+dddd) must be enclosed in single quotes\n"); 
                    
char aChar = 'A';
char aCharInDecimal = (char)65;
char aCharInHexadecimal = '\x0041';
char aCharInUnicode = '\u0041';

Console.WriteLine(aChar + aCharInDecimal + aCharInHexadecimal + aCharInUnicode); // characters have numerical representation, so this will yield a number
Console.WriteLine(aChar + "" + aCharInDecimal + "" + aCharInHexadecimal + "" + aCharInUnicode); // but this will give you AAAA

char aCharMinValue = char.MinValue; 
char aCharMaxValue = char.MaxValue;

Console.WriteLine("char.MinVal = " + char.MinValue); // this is the empty character
Console.WriteLine("char.MaxVal = " + char.MaxValue); // and this is the last character

Console.WriteLine(aCharMinValue + " <= aChar <= " + aCharMaxValue);
Console.WriteLine("sizeof(char) = " + sizeof(char) + " byte(s)");
Console.WriteLine("\n");


// short
Console.WriteLine("The Int16 type -- or short");
Console.WriteLine("---------------------------\n");

Console.WriteLine("The Int16 type is also known as short. It has MinVal and MaxVal definitions.\n" +
                    "Notice how all operations below on short and Int16 yield the same results.\n" +
                    "Be consistent in your programming, use one or the other but not both.\n");

Console.WriteLine("sizeof(bool) = " + sizeof(Int16) + " byte(s)");

short aShortMinVal = short.MinValue;
short aShortMaxVal = short.MaxValue;

Console.WriteLine("aShortMinVal = " + aShortMinVal);
Console.WriteLine("aShortMaxVal = " + aShortMaxVal);
Console.WriteLine(aShortMinVal + " <= aShortNum <= " + aShortMaxVal);


Int16 aInt16MinVal = Int16.MinValue;
Int16 aInt16MaxVal = Int16.MaxValue;

Console.WriteLine("aInt16MinVal = " + aInt16MinVal);
Console.WriteLine("aInt16MaxVal = " + aInt16MaxVal);
Console.WriteLine(aInt16MinVal + " <= aInt16Num <= "+ aInt16MaxVal);

Console.WriteLine("\n\n");

Console.WriteLine("Explore the following types on your own, practice declaring variables in addition to the min and max values and printing them:\n" +
                    "byte/Byte\n" +
                    "int/Int32\n" +
                    "long/Int64\n" +
                    "float/Single\n" + 
                    "double/Double\n");

// long
long aLong = 5_000_000;  // 5000000 is an integer. It gets implicitly converted to long.
                         // The _ is for readability. It can be placed between numbers only 

// float vs. Single
float aFloat1 = 5; // this literal 5 here is an integer that will implicitly be converted into a float
float aFloat2 = 5.0f; // the literal 5.0 alone is considered a double. It needs the f to turn into float 
float aFloat3 = 5.0F; // f or F both work 

// double vs. Double
double aDouble = 5; // the literal 5 here is an integer that will implicitly be converted into a double
double aDouble1 = 5.050_007_5; // the literal 5.05 is a double
double aDouble2 = 5.0500075D; // a small d or D can be appended at the end of the literal but it's not required

// Integral types: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
// Floating point types: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

// Arithmetic Operators : + - * / %

int a = 10;
int b = 5;
int c = 3;

int sum_ab = a + b; // 10 + 5 = 15
Console.WriteLine(a + " + " + b + " = " + sum_ab);

int diff_ab = a - b; // 10 - 5 = 5 
int diff_ba = b - a; // 5 - 10 = -5
int product_ab = a * b; // 10 * 5 = 50
int quotient_ab = a / b; // 10/5 = 2 
int quotient_ac = a / c; // 10/3 = 3, this is a division of integers, the result is a whole number


Console.WriteLine(a + " - " + b + " = " + diff_ab);
Console.WriteLine(a + " - " + b + " = " + diff_ba);
Console.WriteLine(a + " * " + b + " = " + product_ab);
Console.WriteLine(a + " / " + b + " = " + quotient_ab);
Console.WriteLine(a + " / " + c + " = " + quotient_ac);

Console.WriteLine("Saving 10/3 in a float variable will not give you 3.333: ");
float quotientf_ac = a / c;

Console.WriteLine(a + " / " + c + " = " + quotientf_ac);
Console.WriteLine("This is because 10/3 is a division of integers. It yields an integer." +
                "Saving an integer into a float is possible, it's an implicit conversion, but all it does is add a .0 to the integer.\n\n");
        

Console.WriteLine("Outside the variables, 10/3 = " + 10/3); // this is a division of integers, the result is an integer
Console.WriteLine("Outside the variables, 10.0/3 = " + 10.0 / 3); // this is a division of a double and an integer, the result is a double
Console.WriteLine("Outside the variables, 10.0f/3 = " + 10.0f / 3); // this is a division of a float and an integer, the result is a float

int remainder_ab = a % b;   // remainder of the division of a/b
int remainder_ac = a % c;   // remainder of the division of a/c

Console.WriteLine(a + " % " + b + " = " + remainder_ab);     
Console.WriteLine(a + " % " + c + " = " + remainder_ac);

Console.WriteLine("In a numerical expression, the larger type trumps:\n\n"); 

Console.WriteLine("numerator_type | denominator_type | quotient_type\n" +
                  "int            | int              | int\n" +
                  "float          | float            | float\n" +
                  "double         | double           | double\n" +
                  "int            | float            | float\n" +
                  "double         | float            | double\n");

// Conversions (casting) between types
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions

// A2.
// Ex.2a.i
int aNum1 = 5;
float aNum2 = (float)aNum1; // this is explicit casting, it takes the value of aNum1,
                            // which is an integer, and turns it into a float,
                            // but here the float is redundant
float aNum3 = aNum1; // this is because an int can be implicitly cast into a float

// Ex.2b
float aNum4 = Convert.ToSingle(aNum1); // this uses Convert.To syntax 

// Ex. 3a
Console.Write("Please enter a float: ");
float aFloatVar = Convert.ToSingle(Console.ReadLine());
int anIntVar1 = (int)aFloatVar; // an explicit cast is required to move from float to int
int anIntVar2 = Convert.ToInt32(aFloatVar); // or a conversion

Console.WriteLine("(int)aFloatVar = " + anIntVar1); // the decimal point is stripped
Console.WriteLine("Convert.ToInt32(aFloatVar) = " + anIntVar2); // both results are identical
