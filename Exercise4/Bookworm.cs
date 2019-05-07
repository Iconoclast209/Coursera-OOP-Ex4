using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Bookworm : Kid
    {
        public override void PrintMessage()
        {
            Console.WriteLine("This is a message from the bookworm child class.");
        }
    }
}
