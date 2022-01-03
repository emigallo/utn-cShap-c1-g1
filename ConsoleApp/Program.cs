using System;
using Tateti.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User _user1 = new User(2);
            Game game = new Game();
            string type = _user1.File.Type;

            game.AddUser("lucas");

            Console.WriteLine(type);
    }
    }
}
