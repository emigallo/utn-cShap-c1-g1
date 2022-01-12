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
        bool _gameFinish = false;
        public GameTateti(string NameUser1, string NameUser2)
        {
            InitializeComponent();
            this._game = new GameTatetiViewModels();
            _game.AddUser1(NameUser1);
            _game.AddUser2(NameUser2);
            AddName();
        }

        public void AddName()
        {
            lblUser1.Content = _game.GetUser1().Name;
            lblUser2.Content = _game.GetUser2().Name;
        }
                
        private void ButtonSite_Click(object sender, RoutedEventArgs e)
        {
            if (!_gameFinish)
            {
                Button buttonSite = sender as Button;
                string site = buttonSite.Tag.ToString();
                int NRow = int.Parse(site.Substring(0, 1));
                int NCol = int.Parse(site.Substring(1));
                File FileTurn = _game.UserTurn();
                if (_game.AddFile(FileTurn, NRow, NCol))
                {
                    buttonSite.Content = FileTurn.Type;
                    if (_game.GetWinner() != null)
                    {
                        _gameFinish = true;
                        string Winner = "El ganador del juego es: " + _game.UserWinner(FileTurn);
                        lblWin.Content = Winner;
                    }
                    else
                    {
                        if (_game.GameTied())
                        {
                            _gameFinish = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campo usado");
                }
            }
            else
            {
                MessageBox.Show("Juego Terminado");
            }

        }

        private void ButtonMainMenu_Click(object sender, RoutedEventArgs e)
        {
            Main x = new Main();
            this.Close();
            x.ShowDialog();
        }

        //private void ButtonSite01_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 0, 1))
        //        {
        //            btnSite01.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite02_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 0, 2))
        //        {
        //            btnSite02.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite10_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 1, 0))
        //        {
        //            btnSite10.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite11_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 1, 1))
        //        {
        //            btnSite11.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite12_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 1, 2))
        //        {
        //            btnSite12.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite20_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 2, 0))
        //        {
        //            btnSite20.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite21_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 2, 1))
        //        {
        //            btnSite21.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if (_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}

        //private void ButtonSite22_Click(object sender, RoutedEventArgs e)
        //{           
        //    if (!_gameFinish)
        //    {
        //        File turn = _game.UserTurn();
        //        if (_game.AddFile(turn, 2, 2))
        //        {
        //            btnSite22.Content = turn.Type;
        //            File file = _game.GetWinner();
        //            if (file != null)
        //            {
        //                _gameFinish = true;
        //                lblWin.Content = "Hubo Ganador";
        //            }
        //            if(_game.GameTied())
        //            {
        //                _gameFinish = true;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Campo usado");
        //        }
        //    }
        //    if (_gameFinish)
        //    {
        //        MessageBox.Show("Juego Terminado");
        //    }
        //}
    }
}
