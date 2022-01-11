using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tateti.Models;

namespace GUI.View
{
    /// <summary>
    /// Lógica de interacción para GameTateti.xaml
    /// </summary>
    public partial class GameTateti : Window
    {
        GameTatetiViewModels _game;
        bool gameState =  false;
        public GameTateti(GameTatetiViewModels game)
        {
            InitializeComponent();
            this._game = game;
            AddName();
        }

        public void AddName()
        {
            lblUser1.Content = _game.GetUser1().Name;
            lblUser2.Content = _game.GetUser2().Name;
        }

        private void ButtonSite00_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 0, 0))
                {
                    btnSite00.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if(gameState)
            {
                MessageBox.Show("Juego Terminado");
            }    
            
        }

        private void ButtonSite01_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 0, 1))
                {
                    btnSite01.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite02_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 0, 2))
                {
                    btnSite02.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite10_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 1, 0))
                {
                    btnSite10.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite11_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 1, 1))
                {
                    btnSite11.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite12_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 1, 2))
                {
                    btnSite12.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite20_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 2, 0))
                {
                    btnSite20.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite21_Click(object sender, RoutedEventArgs e)
        {
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 2, 1))
                {
                    btnSite21.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if (_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }

        private void ButtonSite22_Click(object sender, RoutedEventArgs e)
        {           
            if (!gameState)
            {
                File turn = _game.UserTurn();
                if (_game.AddFile(turn, 2, 2))
                {
                    btnSite22.Content = turn.Type;
                    File file = _game.GetWinner();
                    if (file != null)
                    {
                        gameState = true;
                        lblWin.Content = "Hubo Ganador";
                    }
                    if(_game.GameState())
                    {
                        gameState = true;
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            if (gameState)
            {
                MessageBox.Show("Juego Terminado");
            }
        }
    }
}
