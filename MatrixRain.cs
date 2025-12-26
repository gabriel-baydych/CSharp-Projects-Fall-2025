using System.Threading;

// Reading the horizontal border:
int horizontalBorder;
Console.Write("Enter the horizontal border of the graph here: ");
bool isValid = int.TryParse(Console.ReadLine(), out horizontalBorder);
while (isValid == false)
{
    Console.Write("ERROR! The input is not an int. Enter the horizontal border of the graph here: ");
    isValid = int.TryParse(Console.ReadLine(), out horizontalBorder);
}

// Reading the scrolling speed:
int speed;
Console.Write("The closer the speed is to 0, the faster it is. Enter the scrolling speed of the graph here: ");
isValid = int.TryParse(Console.ReadLine(), out speed);
while (isValid == false || speed < 0)
{
    Console.Write("ERROR! The input is not an int OR it is negative. Enter the scrolling speed of the graph here: ");
    isValid = int.TryParse(Console.ReadLine(), out speed);
}

// Color:
Console.ForegroundColor = ConsoleColor.Green;

// Main Loop
for (; ;)
{
    for (int horizontalCounter = 0; horizontalCounter < horizontalBorder; horizontalCounter++)
    {
        int chance = Random.Shared.Next(2);
        if (chance == 1)
        {
            Console.Write(' ');
        }
        else
        {
            Console.Write((char)Random.Shared.Next(32, 127));
        }
    }
    Console.WriteLine();
    Thread.Sleep(speed);
}
Console.ResetColor();
