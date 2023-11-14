/*1) Prompt the user for two numbers (int or float) and an operator.
a.
Use a switch statement to execute the appropriate instructions assuming the operator entered is an arithmetic operator 
(+, - *, / or %). Read the arithmetic operator as a char.
b.
Use another switch statement to execute the appropriate instructions assuming the operator entered is a relational operator 
(<, <=, >=, >, ==, !=). Read the relational operator as a string.
c.
Nest the switch statements you developed in 1a & 1b into an outer switch. Ask the user if they would like to perform an 
arithmetic operation (choose ‘1’ or ‘a’) or a relational operation (choose ‘2’ or ‘r’). Use the appropriate datatype 
to store their answer and direct them to the relevant case.
*/
using System.Linq.Expressions;

Console.WriteLine("Please enter a number (int or float): ");
float n1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Please enter another number (int or float): ");
float n2 = Convert.ToSingle(Console.ReadLine());

//for (int i = 0; i < 5; i++)
//{
    Console.WriteLine("Please enter (1) to perform an arithmetic operation or (2) to perform a relational operation: ");
    int opType = Convert.ToInt16(Console.ReadLine());

    switch (opType)
    {
        case 1:
            Console.WriteLine("Please enter a operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;
                case '-':
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;
                case '*':
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;
                case '/':
                    Console.WriteLine($"{n1} / {n2} = {n1 + n2}");
                    break;
                default:
                    Console.WriteLine("Invalid data");
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Please enter a operator: ");
            string op2 = Console.ReadLine();

            switch (op2)
            {
                case ">":
                    if (n1 > n2)
                    {
                        Console.WriteLine($"{n1} > {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} > {n2} = False");
                    }
                    break;
                case ">=":
                    if (n1 >= n2)
                    {
                        Console.WriteLine($"{n1} >= {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} >= {n2} = False");
                    }
                    break;
                case "<=":
                    if (n1 <= n2)
                    {
                        Console.WriteLine($"{n1} <= {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} <= {n2} = False");
                    }
                    break;
                case "<":
                    if (n1 < n2)
                    {
                        Console.WriteLine($"{n1} < {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} < {n2} = False");
                    }
                    break;
                case "==":
                    if (n1 == n2)
                    {
                        Console.WriteLine($"{n1} == {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} == {n2} = False");
                    }
                    break;
                case "!=":
                    if (n1 != n2)
                    {
                        Console.WriteLine($"{n1} != {n2} = True");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} != {n2} = False");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid data");
                    break;
            }
            break;
        default:
            Console.WriteLine("Invalid data");
            break;
    }
//}