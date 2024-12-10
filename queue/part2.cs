using System;
using System.Collections.Generic;

namespace DoingQueueApparently
{
    class Program
    {
        static void Main()
        {
            Queue<string> highPriorityTasks = new Queue<string>();
            Queue<string> lowPriorityTasks = new Queue<string>();

            string input;
            while (true)
            {
                input = Console.ReadLine();

                if (input == "konec")
                {
                    break;
                }

                if (input.StartsWith("vp"))
                {
                    highPriorityTasks.Enqueue(input.Substring(3));
                }
                else if (input.StartsWith("np"))
                {
                    lowPriorityTasks.Enqueue(input.Substring(3));
                }
            }
            
            int taskNumber = 1;
            
            while (highPriorityTasks.Count > 0)
            {
                Console.WriteLine($"{taskNumber++}. {highPriorityTasks.Dequeue()}");
            }

            while (lowPriorityTasks.Count > 0)
            {
                Console.WriteLine($"{taskNumber++}. {lowPriorityTasks.Dequeue()}");
            }
        }
    }

}
