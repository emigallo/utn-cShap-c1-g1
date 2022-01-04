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
        private int length;

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

        public File Winner()
        {
            //if (((_position[0].Type == _position[1].Type) && _position[2].Type == _position[1].Type) ||
            //    ((_position[3].Type == _position[4].Type) && _position[5].Type == _position[3].Type) ||
            //    ((_position[6].Type == _position[7].Type) && _position[8].Type == _position[7].Type) ||
            //    ((_position[0].Type == _position[3].Type) && _position[6].Type == _position[0].Type) ||
            //    ((_position[1].Type == _position[4].Type) && _position[7].Type == _position[1].Type) ||
            //    ((_position[2].Type == _position[5].Type) && _position[8].Type == _position[2].Type) ||
            //    ((_position[0].Type == _position[4].Type) && _position[8].Type == _position[0].Type) ||
            //    ((_position[2].Type == _position[4].Type) && _position[6].Type == _position[0].Type))
            //    return true;
                 


            if ((_position[0].Type == _position[1].Type) && _position[2].Type == _position[1].Type) 
                return _position[0];
            if ((_position[3].Type == _position[4].Type) && _position[5].Type == _position[3].Type)
                return _position[3];
            if ((_position[6].Type == _position[7].Type) && _position[8].Type == _position[7].Type)
                return _position[6];
            if ((_position[0].Type == _position[3].Type) && _position[6].Type == _position[0].Type)
                return _position[0];
            if ((_position[1].Type == _position[4].Type) && _position[7].Type == _position[1].Type)
                return _position[1];
            if ((_position[2].Type == _position[5].Type) && _position[8].Type == _position[2].Type)
                return _position[2];
            if ((_position[0].Type == _position[4].Type) && _position[8].Type == _position[0].Type)
                return _position[0];
            if ((_position[2].Type == _position[4].Type) && _position[6].Type == _position[0].Type)
                return _position[2];
            else
                return null;
           

            
        }


    }
}
