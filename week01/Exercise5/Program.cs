using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();

        string name = AskForName();
        int number = AskForNumber();

        int squaredNumber = squareNumber(number);

        Result(name, squaredNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static string AskForName()

    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;

    }

    static int AskForNumber()

    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void Result(string name, int square)

    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}
