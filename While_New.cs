// See https://aka.ms/new-console-template for more information

/*
int i = 1;
while(i<=10)
{
    Console.WriteLine(i);
    i++;
}

for (int j=1; j <= 10; j++)
{
    Console.Write(j);
}
*/
/*
 *#1 Write a program that prints all the numbers between 1 and 10 – as well as their sum.
 **/
/*
int sum = 0;

for (int j = 1; j <= 10; j++)
{
    Console.WriteLine(j);
    sum += j;
    Console.Write(sum);
}
Console.WriteLine(sum);
*/
//#2 Write a program to print all the characters whose decimal values range between 33 and 126. (ASCII table) 

//char asc = (char)33;

//for (int j = 33; j <= 126; j++)
//{
//    Console.WriteLine($"{Convert.ToChar(j)}");
//    //asc++;

//}

//#3 Write a program that prints all the numbers from 0 to 6 except 3 and 6. 

//for (int i = 0; i <=6; i++)
//{
//    //if (i != 3 && i != 6)
//    //{
//    //    Console.Write($"{i} ");
//    //}
//    if (i % 3 != 0 || i == 0)
//    {
//        Console.Write($"{i} ");
//    }
//}


//ORDER OF FOR: CONDITION >> BODY >> INCREMENTING

//#4 Write a program to print the numbers between 1500 and 2700, such that they are divisible by 5 and 7.  


//for (int j = 1500, iterat = 1; j <= 2700; j++)
//{
//    if (j % 5 == 0 && j % 7 == 0)
//    {
//        Console.WriteLine(j);
//    }   
//}

/*
 * #5 Write a program that prompts the user to input an integer. Validate the input, then print this number’s multiplication table.  
 * E.g.:  
 * 1 x m = …  
 * 2 x m = … 
 * 3 x m = … 
 * 4 x m = … 
 * . . . 
 * 10xm = … 
 */
/*
string num;
bool validation;

do
{
    Console.WriteLine("Please enter a integer number: ");
    num = (Console.ReadLine());
    validation = int.TryParse(num, out int result);
} while (validation == false) ;

int num2 = Convert.ToInt16(num);

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {num} = {i*num2}");
}

*/
/*
 *#6 Write a program that prompts the user for a positive integer. Validate the input, then let the user know whether this number is prime or not. 
 A prime number is only divisible by 1 and itself. 
*/
//using System;

int x = 0;
int notPrime = 0; ;
do
{
    Console.WriteLine("Please enter a positive integer number: ");
    x = Convert.ToInt16(Console.ReadLine());

} while (x <= 0);

for (int i = 1; i <= x; i++)
{
    if (x % i == 0)
    {
        notPrime++;
    }
}
Console.WriteLine(notPrime == 2 ? "Is Prime!" : "Is NOT Prime!");

//string x;
//bool validation;

//do
//{
//    Console.WriteLine("Please enter a positive integer number: ");
//    x = (Console.ReadLine());
//    validation = byte.TryParse(x, out byte result);
//} while (validation == false);

//byte num2 = Convert.ToByte(x);

//if (num2 == 1 || num2 == 0)
//{
//    Console.WriteLine($"{num2} is NOT a prime number!");
//}
//else if (num2 == 2 || num2 % num2 == 0 && num2 % 1 == 0 && num2 % 2 != 0)
//{
//    Console.WriteLine($"{num2} is a prime number!");
//}
//else
//{
//    Console.WriteLine($"{num2} is NOT a prime number!");
//}

/*
 * #7 Write a program that prompts the user for two positive integers. Validate the input, 
 * then find the value of one number raised to the power of another.   
 * E.g.:  2, 3 = 2 x 2 x 2 = 8 4, 2 = 4 x 4 = 16 
 */
/*
string a, b;
bool validation2;

do
{
    Console.WriteLine("Please enter a positive integer number: ");
    a = (Console.ReadLine());
    validation2 = byte.TryParse(a, out byte result);
} while (validation2 == false);

do
{
    Console.WriteLine("Please enter another positive integer number: ");
    b = (Console.ReadLine());
    validation2 = byte.TryParse(b, out byte result);
} while (validation2 == false);

byte numA = Convert.ToByte(a);
byte numB = Convert.ToByte(b);
int res = numA; 

if (numB == 0)
{
    Console.WriteLine($"{numA} raised by {numB} = 1");
}
else
{
    for (int i = 1; i < numB; i++)
    {
        res *= numA;
    }
    Console.WriteLine($"{numA} raised by {numB} = {res}");
}
/*
while (i <= numB)
{

}
*/
/*
 * #8 Write a program that prompts the user for a positive integer and finds the factorial value of a positive integer 
 * entered through the keyboard. The factorial of a number n is calculated by multiplying the number by all 
 * the numbers that come before it – down to 1.   
 * n! = n x (n-1)!  E.g.:  
 * 7! = 7 x 6 x 5 x 4 x 3 x 2 x 1 
 * 5! = 5 x 4 x 3 x 2 x 1 
 * 3! = 3 x 2 x 1 
 */
/*
string numX;
bool validation3;

do
{
    Console.WriteLine("Please enter a positive integer number: ");
    numX = (Console.ReadLine());
    validation3 = byte.TryParse(numX, out byte result);
} while (validation3 == false);

byte numY = Convert.ToByte(numX);

int factorial = 1;

//i = 3 numY = 3 factorial = 3x2=6 
//i = 2
/*
while (i < numY && i >= 1)
{
    factorial = i * (i-1);
    i--;
}
Console.WriteLine($"{numY}! ====== {factorial}");
*/
/*
for  (int i = 1; i <= numY; i++)
{
    factorial *= i;
}
Console.WriteLine($"{numY}! = {factorial}");
*/
/*
 * #9 Write a program to guess a number between 1 and 9. If the user guesses wrong, then the prompt appears again until the guess is correct. 
 * On a successful guess, the user gets a “Well guessed!” message, and the program will exit. 
 * Modify the program to cap the number of guesses.
 */
/*
const byte guess = 7;
int userGuess;
int i = 0;

do
{
    i++;
    Console.WriteLine("Please guess a number between 1 and 9: ");
    userGuess = Convert.ToByte(Console.ReadLine());
    
} while (userGuess != guess);

Console.WriteLine($"WELL GUESSED!!! You tried {i} times!");
*/

//ex.10
//int num;

//do 
//{ 

//} while()