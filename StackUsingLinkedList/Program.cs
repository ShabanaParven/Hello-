﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();

            Console.ReadKey();
        }
    }
}
