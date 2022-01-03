using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Boart
    {
        //matriz de 9 posiciones para el tablero
        private File[] _position;
        private Turn _turn;
        public Boart()
        {
            _turn = new Turn();
            _position = new File[9];
        }

        public File[] GetPosition()
        {
            return _position;
        }
        public void Add()
        {
            //usuario ingresa "X"
            
            _turn.NextTurn();
        }
    }
}
