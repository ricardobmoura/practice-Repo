/*
 * #5 [boolean expressions] 
 */
//a. Fill in the blanks to determine if a character is a vowel: bool isVowel = ……………;  
/*Console.WriteLine("Please enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());

ch = Char.ToLower(ch);
bool isVowel = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');

if (isVowel)
{
    Console.WriteLine($"{ch} is a Vowel!");
}
else
{
    Console.WriteLine($"{ch} is NOT a Vowel!");
}
*/
/*
// b. Fill in the blanks to determine if a number is even or odd: bool isOdd = …………., isEven = …………….;  

Console.WriteLine("Please enter a number: ");
int numA = Convert.ToInt16(Console.ReadLine());

bool isEven = numA % 2 == 0;

if (isEven)
{
    Console.WriteLine($"{numA} is Even!");
}
else
{
    Console.WriteLine($"{numA} is Odd!");
}

// #6 Prompt the user for a 4-digit year and let him/her know if it’s a leap year.
// A leap year is a year divisible by 4, but not by 100. A leap year is a year that is divisible by 400.


Console.WriteLine("Please enter a 4 digit year: ");
int year = Convert.ToInt16(Console.ReadLine());

bool isLeap = ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0));

if (isLeap)
{
    Console.WriteLine($"{year} is a Leap Year!");
}
else
{
    Console.WriteLine($"{year} is NOT a Leap Year!");
}

/*#7 Prompt the user for a month m, a day d and a 4 digit year y, and let him/her know what day of the week 
 * his input corresponds to. Use the following formulas:   
 * y0 = y – (14-m)/12  
 * x = y0 +y0/4 – y0/100 + y0/400 
 * m0 = m +12 * ((14-m)/12) -2  
 * d0 = (d + x + (31*m0)/12) mod 7   
 */
/*
Console.WriteLine("Please enter a month: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Please enter a day: ");
int d = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Please enter a 4 digit year: ");
int y = Convert.ToInt16(Console.ReadLine());

int y0 = y - (14 - m) / 12,
x = y0 + y0 / 4 - y0 / 100 + y0 / 400,
m0 = m + 12 * ((14 - m) / 12) - 2,
d0 = (d + x + (31 * m0) / 12) % 7;

switch (d0)
{
    case 0:
        Console.WriteLine("Sunday");
        break;
    case :
            Console.WriteLine("Monday");
            break;
        case 1:
            Console.WriteLine("Tuesday");
            break;
        case 2:
            Console.WriteLine("Wednesday");
            break;
        case 3:
            Console.WriteLine("Thursday");
            break;
        case 4:
            Console.WriteLine("Friday");
            break;
        case 5:
            Console.WriteLine("Saturday");
            break;
        default:
            Console.WriteLine("Dados invalidos");
            break;
}
*/
/*
if (d0 == 1)
{
    Console.WriteLine("Monday");
}
else if (d0 == 2)
{
    Console.WriteLine("Tuesday");
}
else if (d0 == 3)
{
    Console.WriteLine("Wednesday");
}
else if (d0 == 4)
{
    Console.WriteLine("Thursday");
}
else if (d0 == 5)
{
    Console.WriteLine("Friday");
}
else if (d0 == 6)
{
    Console.WriteLine("Saturday");
}
else if (d0 == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Dados invalidos");
}
*/
/*#8 Prompt the user for a month m and a day d and let him/her know the season.    
 * WINTER  December 01 – February 28  
 * SPRING   March 01 – May 31   
 * SUMMER   June 01 – August 31
 * AUTUMN  September 01 – November 30  
 */

using System.Text;

Console.WriteLine("Please enter a month: ");
int m2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Please enter a day: ");
int d2 = Convert.ToInt16(Console.ReadLine());



if ((m2==12 && d2>=21 && d2<=31) || (m2==1 && d2>=1 && d2<=31) || (m2==2 && d2>=1 && d2<=29) || (m2==3 && d2>=1 && d2<21))
{
    Console.WriteLine("WINTER");
}
else if ((m2 == 3 && d2 >= 21 && d2 <= 31) || (m2 == 4 && d2 >= 1 && d2 <= 30) || (m2 == 5 && d2 >= 1 && d2 <= 30) || (m2 == 6 && d2 >= 1 && d2 < 20))
{ 
    Console.WriteLine("SPRING");
}
else if ((m2 == 6 && d2 >= 21 && d2 <= 30) || (m2 == 7 && d2 >= 1 && d2 <= 31) || (m2 == 8 && d2 >= 1 && d2 <= 31) || (m2 == 9 && d2 >= 1 && d2 <= 20))
{
    Console.WriteLine("SUMMER");
}
else if ((m2 == 9 && d2 >= 21 && d2 <= 30) || (m2 == 10 && d2 >= 1 && d2 <= 31) || (m2 == 11 && d2 >= 1 && d2 <= 30) || (m2 == 12 && d2 >= 1 && d2 <= 20))
{
    Console.WriteLine("FALL");
}
else
{
    Console.WriteLine("Invalid data!!!");
}



//#9 Write a C# program to determine whether a character is an alphabet, a digit, or a special character.
/*
Console.WriteLine("Please enter a character: ");
char w = Convert.ToChar(Console.ReadLine());


if (w >= 48 && w <= 57)
{
    Console.WriteLine($"{w} is a Digit!");
}
else if (w >= 65 && w <= 90 || w >= 97 && w <= 122)
{
    Console.WriteLine($"{w} is an Alphabet!");
}
else
{
    Console.WriteLine($"{w} is an Symbol!");
}
    

*/
/*if (char.IsLetter(w))
 {
     Console.WriteLine($"{w} is an Alphabet!");
 }
 else if (char.IsDigit(w))
 {
     Console.WriteLine($"{w} is a Digit!");
 }
 else
 {
     Console.WriteLine($"{w} is a special character!");
 }

int x = 10;
int y = 20;

int max = (x > y) ? x : y; // If x > y is true, max gets the value of x, otherwise, it gets the value of y.
1, 2 and 9.
*/


