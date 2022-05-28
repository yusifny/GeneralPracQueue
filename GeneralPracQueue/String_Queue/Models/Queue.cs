using System;
using System.Collections;
using System.Collections.Generic;

namespace GeneralPracQueue.Models
{
    public class Queues
    {
        public Queue<string> Reverse(Queue<string> words)
        {
            Queue<string> queue = new Queue<string>();
            Stack stack = new Stack();
            foreach (var item in words)
            {
                stack.Push(item);
            }
            foreach (var item in queue)
            {
                words.Enqueue((string)item);
            }
            return queue;
        }

    }
}
