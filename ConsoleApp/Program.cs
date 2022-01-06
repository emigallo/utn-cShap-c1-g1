using System;
using Tateti.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("******************************************************************");
            Console.WriteLine("************************     TATETI    ***************************");
            Console.WriteLine("******************************************************************");
            Game game = new Game();
            Console.WriteLine("Ingrese jugador 1");
            string nam1 = Console.ReadLine();
            game.AddUser(nam1, 1);
            Console.WriteLine("Ingrese jugador 2");
            string nam2 = Console.ReadLine();
            game.AddUser(nam2, 2);
            Console.WriteLine("Enter para comenzar partida");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("******************************************************************");
            Console.WriteLine("************************     TATETI    ***************************");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Partida entre " + game.GetUser1().Name + " y " + game.GetUser2().Name);
            Random x = new Random();
            while (game.GetBoart().GetTurn() < 10)
            {
                game.AddFile(game.UserTurn(), x.Next(0, 3), x.Next(0, 3));
            }
            //game.AddFile(game.UserTurn(), 0, 0);
            //game.AddFile(game.UserTurn(), 0, 1);
            //game.AddFile(game.UserTurn(), 0, 2);
            //game.AddFile(game.UserTurn(), 1, 0);
            //game.AddFile(game.UserTurn(), 1, 1);
            //game.AddFile(game.UserTurn(), 1, 2);
            //game.AddFile(game.UserTurn(), 2, 0);
            //game.AddFile(game.UserTurn(), 2, 1);
            //game.AddFile(game.UserTurn(), 2, 2);





            //Random x = new Random();
            //for (int i = 0; i < game.GetBoart().GetPosition().GetLength(0); i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        game.GetBoart().Add(new File(x.Next(1, 3)), i, j);
            //    }
            //}
            var boart = game.GetBoart().GetPosition();
            for (int i = 0; i < game.GetBoart().GetPosition().GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("   " + boart[i, j].Type + "   " + boart[i, j+1].Type + "   " + boart[i, j+2].Type);
                }
            }

            var zzz = game.GetBoart().Winner();
            if (zzz != null)
            {
                if (zzz.Type == "X")
                    Console.WriteLine("El ganador de la partida es... EL JUGADOR 1, " + game.GetUser1().Name);
                if (zzz.Type == "O")
                    Console.WriteLine("El ganador de la partida es... EL JUGADOR 2, " + game.GetUser2().Name);
            }
            else
                Console.WriteLine("Hay un empate");
            Console.ReadKey(true);
        }
       
    }
}
    