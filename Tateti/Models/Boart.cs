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
        private int _turn;
        public Boart()
        {
            _turn = 1;
            _position = new File[9];

        }

        public File[] GetPosition()
        {
            return _position;
        }
        public bool Add(File file, int site)
        {
            //usuario ingresa "X"
            if(_position[site] == null)
            {
                _position[site] = file;
                _turn = _turn + 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetTurn()
        {
            return _turn;
        }


    }
}
