using System;

class Program
{
    static void Main()
    {
        Action<string> DisplayMessage;
        DisplayMessage = DisplayToConsole;
        DisplayMessage("This is a message...");
    }
    public static void DisplayToConsole(string message)
    {
        Console.WriteLine(message);
    }
}
