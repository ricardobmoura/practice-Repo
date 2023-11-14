Console.WriteLine("********** Welcome to B.Hive! **********");

string name = "";
decimal totalCost = 0.0m;


do
{

    Console.Write("Please enter your name: ");
    name = Console.ReadLine();
    if (name.Length > 0)
    {
        int spanishLatteCount = 0;
        int doubleEspressoCount = 0;
        int turkishCoffeeCount = 0;
        string orderSummary = "";
        char choice;
        do
        {
            //do
            //{
                Console.WriteLine($"What can I get you, {name}?");
                Console.WriteLine("a. Turkish Coffee (3.35$)");
                Console.WriteLine("b. Double Espresso (3.25$)");
                Console.WriteLine("c. Spanish Latte (4.80$)");

                choice = Console.ReadLine()[0];
            //} while (choice != 'a' || choice != 'b' || choice != 'c');



            switch (choice)
            {
            case 'a':

                byte turkishCoffeeQuantity = 0;
                do
                {
                    Console.Write("How many Turkish Coffees would you like?(1-5) ");
                    turkishCoffeeQuantity = Convert.ToByte(Console.ReadLine());

                } while (turkishCoffeeQuantity < 1 || turkishCoffeeQuantity > 5);
                //turkishCoffeeQuantity = Math.Min(turkishCoffeeQuantity, 5);
                turkishCoffeeCount += turkishCoffeeQuantity;
                totalCost += turkishCoffeeQuantity * 3.35m;
                orderSummary += $"{turkishCoffeeQuantity} Turkish Coffees @ {turkishCoffeeQuantity * 3.35m}$\n";
                break;

            case 'b':
                Console.Write("Adding a Double Espresso to your order. Would you like some Whipped Cream with it? (y/n) ");
                // add ++ DoubleExpresso
                char whippedCreamChoice = Console.ReadLine()[0];
                if (whippedCreamChoice == 'y')
                {
                    totalCost += 0.75m;
                    orderSummary += "1 Double Espresso with Whipped Cream @ 4$\n";
                }
                else
                {
                    totalCost += 3.25m;
                    orderSummary += "1 Double Espresso @ 3.25$\n";
                }
                break;

            case 'c':
                spanishLatteCount++;
                totalCost += 4.80m;
                Console.Write("Adding a Spanish Latte to your order. Would you like to add another Spanish Latte? (y/n) ");
                char spanishLatteChoice = Console.ReadLine()[0];
                if (spanishLatteChoice == 'y')
                {
                    spanishLatteCount++;
                    totalCost += 4.80m;
                }
                orderSummary += $"{spanishLatteCount} Spanish Latte @ {spanishLatteCount * 4.80m}$\n";
                break;

            default:
                Console.WriteLine("Sorry, I don't recognize this answer.");
                break;
            }

            Console.Write("Would you like to add another beverage to your order? (y/n) ");
        } while (Console.ReadLine()[0] == 'y') ;

        Console.WriteLine($"Your order summary:\n{orderSummary}Total = {totalCost:C}");

        string creditCardNumber;
        do
        {
        Console.Write("Please enter your 16-digits credit card number: ");
        creditCardNumber = Console.ReadLine();
        } while (creditCardNumber.Length != 16);

        int expirationMonth, expirationYear;
        do
        {
            Console.Write("Please enter the month (MM) and year (YY) of expiration – on separate lines: ");
            expirationMonth = int.Parse(Console.ReadLine());
            expirationYear = int.Parse(Console.ReadLine());
        } while (expirationYear < 23 || expirationYear > 28 || (expirationYear == 23 && expirationMonth < 11));

        int ccv;
        do
        {
        Console.Write("Please enter your 3-digits CCV: ");
        ccv = int.Parse(Console.ReadLine());
        } while (ccv < 100 || ccv > 999);
        Console.WriteLine($"Thank you for visiting B.Hive, {name}! We will call your name when your order is ready. Have a great day!");
      

    }
    Console.WriteLine("********** Welcome to B.Hive! **********");

} while (true) ;

        
