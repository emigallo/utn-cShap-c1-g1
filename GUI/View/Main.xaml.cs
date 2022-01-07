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
        new Label
        private void NewGamebutton_click(object sender, RoutedEventArgs e)
        {
            //add de los user
            //abrir ventana del juego
            GameTateti x = new GameTateti();
            this.Close();
            x.ShowDialog();
            
        }
    }
}
