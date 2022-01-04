using System;
using Tateti.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.AddUser("T", 1);
            game.AddUser("F", 2);
            //game._boart.Add()

            Boart boar = new Boart();
            File file = new File(1);
            File file2 = new File(2);
            boar.Add(file, 0);
            boar.Add(file2, 4);
            boar.Add(file, 1);
            boar.Add(file2, 6);
            boar.Add(file, 2);

            foreach (var item in boar.GetPosition())
            {
                if (item == null)
                    Console.WriteLine("null");
                else
                {
                    Console.WriteLine(item.Type);
                }
                
            }
            Console.WriteLine(boar.Win());
    }
    }
}
