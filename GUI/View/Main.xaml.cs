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
        private GameTatetiViewModels _vm; 
        public Main()
        {
            InitializeComponent();
            this._vm = new GameTatetiViewModels();
        }
        
        private void NewGamebutton_click(object sender, RoutedEventArgs e)
        {           
            _vm.AddUser1(txtUser1.Text);
            _vm.AddUser2(txtUser2.Text);
            //add de los user
            //abrir ventana del juego
            //pasar los usuarios e crear el vm en gm
            GameTateti x = new GameTateti(_vm);
            this.Close();
            x.ShowDialog();           
        }       
    }
}
