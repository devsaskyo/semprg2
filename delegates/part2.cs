using System;

namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
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
}
