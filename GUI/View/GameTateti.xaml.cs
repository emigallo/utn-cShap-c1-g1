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
            if (_gameFinish)
            {
                MessageBox.Show("Juego Terminado");
                return;
            }
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
                    string Winner = "El ganador del juego es";
                    lblWin.Content = Winner;
                    lblWinName.Content = _game.UserWinner(FileTurn);
                }
                else
                {
                    if (_game.GameTied())
                    {
                        _gameFinish = true;
                        lblTie.Content = "Hay un empate entre los jugadores";
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo usado");
            }
        }


    
    private void ButtonMainMenu_Click(object sender, RoutedEventArgs e)
    {
        Main x = new Main();
        this.Close();
        x.ShowDialog();
    }
}
}
