using System;
using System.Collections.Generic;
using System.Linq;
using GeneralPracQueue.Models;

namespace GeneralPracQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stack = new Stack<string>();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Queues queues = new Queues();

            stack.Reverse();

        }
    }
}
