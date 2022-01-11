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



       
    }
}
