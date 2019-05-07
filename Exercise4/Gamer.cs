using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Gamer : Kid
    {
        public override void PrintMessage()
        {
            Console.WriteLine("This is a message the Gamer kid subclass");
        }
    }
}
