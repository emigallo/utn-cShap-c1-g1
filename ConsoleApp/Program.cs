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
            while (game.GetBoard().GetTurn() < 10)
            {
                game.AddFile(game.UserTurn(), x.Next(0, 3), x.Next(0, 3));
                win();
            }
          
            var boart = game.GetBoard().GetPosition();
            for (int i = 0; i < game.GetBoard().GetPosition().GetLength(0); i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("   " + boart[i, j].Type + "   " + boart[i, j+1].Type + "   " + boart[i, j+2].Type);
                }
            }

            void win()
            {
                var zzz = game.GetBoard().GetWinner();
                if (zzz != null)
                {
                    if (zzz.Type == "X")
                    {
                        var boart = game.GetBoard().GetPosition();
                        for (int i = 0; i < game.GetBoard().GetPosition().GetLength(0); i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.WriteLine("   " + boart[i, j].Type + "   " + boart[i, j + 1].Type + "   " + boart[i, j + 2].Type);
                            }
                        }
                        Console.WriteLine("El ganador de la partida es... EL JUGADOR 1, " + game.GetUser1().Name);                        
                        Console.ReadKey(true);
                        

                    }
                    
                    if (zzz.Type == "O")
                    {
                        var boart = game.GetBoard().GetPosition();
                        for (int i = 0; i < game.GetBoard().GetPosition().GetLength(0); i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.WriteLine("   " + boart[i, j].Type + "   " + boart[i, j + 1].Type + "   " + boart[i, j + 2].Type);
                            }
                        }

                        Console.WriteLine("El ganador de la partida es... EL JUGADOR 2, " + game.GetUser2().Name);
                        Console.ReadKey(true);
                    }
                        
                }
                if(game.GetBoard().GetTurn() == 9)
                    Console.WriteLine("Hay un empate");            
            }
            
        }
       
    }
}
    