using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kid kid = new Kid();
            kid.PrintMessage();

            Kid gamer = new Gamer();
            gamer.PrintMessage();

            Kid bookworm = new Bookworm();
            bookworm.PrintMessage();
        }
    }
}
