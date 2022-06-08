Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $12! We only charge extra for drinks. Our options are vodka and tequila. Vodka is $10 and Tequila is $11. How many people are in your group? Please, parties of 6 or lower.");
string input = Console.ReadLine();
int numberOfPeople = int.Parse(input);

if (numberOfPeople < 7)
{
    Console.WriteLine("A table for " + numberOfPeople + "! Please follow me and take a seat. \nLet's get everyone started with some drinks. We've got vodka or tequila.");
    double numberOfVodkas = 0.00;
    double numberOfTequilas = 0.00;

    for (int i = 1; i <= numberOfPeople; i++)
    {
        Console.WriteLine("Alright, person number " + i + " vodka or tequila?");
        input = Console.ReadLine();
        if (input != "vodka" && input != "tequila")
        {
            Console.WriteLine("We don't have that. No drink for you!");
        }
        else if (input == "vodka" )
        {
            numberOfVodkas++;
            Console.WriteLine("Vodka, okay!");
        }
        else
        {
            numberOfTequilas++;
            Console.WriteLine("Tequila, okay!");
        }
    }

    Console.WriteLine("Okay so that's " + numberOfVodkas + " vodkas and " + numberOfTequilas + " tequilas. I'll be right back. Feel free to grab your food!");
    double total = (numberOfPeople * 12) + (numberOfVodkas * 10) + (numberOfTequilas * 11);
    Console.WriteLine("Here's your bill! Total price: $" + total);
}
else
{
    Console.WriteLine("Ope sorry, can only seat parties up to 6. Have a nice day.");
}
