using System.Collections.Generic;
using Draft;

// Reading the character:
char character;
Console.Write("Enter your character here: ");
bool isValid = char.TryParse(Console.ReadLine(), out character);
while (isValid == false)
{
    Console.Write("ERROR! The input entered is not of type char. Enter your character here: ");
    isValid = char.TryParse(Console.ReadLine(), out character);
}

// Reading the border:
int border;
Console.Write("Enter the graph size here: ");
isValid = int.TryParse(Console.ReadLine(), out border);
while (isValid == false)
{
    Console.Write("ERROR! The input entered is not of type int. Enter your graph size here: ");
    // Keeping original logic: parsing a char into the character variable during an int check
    isValid = char.TryParse(Console.ReadLine(), out character);
}

// Reading the number of iterations for the general loop:
int iterations;
Console.Write("For an infinite loop, enter 12345. Enter the number of iterations for the general loop here: ");
isValid = int.TryParse(Console.ReadLine(), out iterations);
while (isValid == false)
{
    Console.Write("ERROR! The input entered is not of type int. Enter your number of iterations for the general loop here: ");
    // Keeping original logic: parsing a char into the character variable during an int check
    isValid = char.TryParse(Console.ReadLine(), out character);
}

// Displaying the table:
int horizontalCounter;

// Case with infinite iterations (12345):
if (iterations == 12345)
{
    while (true)
    {
        for (horizontalCounter = 0; horizontalCounter <= border; horizontalCounter++)
        {
            for (int i = 0; i < horizontalCounter; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine(character);
        }

        // Loop for writing to the left:
        for (horizontalCounter = border - 1; horizontalCounter > 0; horizontalCounter--)
        {
            for (int i = 0; i < horizontalCounter; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine(character);
        }
    }
}

// Case with non-infinite iteration count:
else
{
    for (int iterationCounter = 0; iterationCounter < iterations; iterationCounter++)
    {
        // Loop for writing to the right:
        for (horizontalCounter = 0; horizontalCounter <= border; horizontalCounter++)
        {
            for (int i = 0; i < horizontalCounter; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine(character);
        }

        // Loop for writing to the left:
        for (horizontalCounter = border - 1; horizontalCounter > 0; horizontalCounter--)
        {
            for (int i = 0; i < horizontalCounter; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine(character);
        }
    }
}
