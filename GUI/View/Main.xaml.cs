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
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {       
        public Main()
        {
            InitializeComponent();            
        }        
        private void NewGamebutton_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser1.Text))           
                txtUser1.Text = "Jugador 1";            
            if (string.IsNullOrWhiteSpace(txtUser2.Text))
                txtUser2.Text = "Jugador 2";
            GameTateti x = new GameTateti(txtUser1.Text, txtUser2.Text);
            this.Close();
            x.ShowDialog();           
        }       
    }
}
