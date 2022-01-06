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
        private File[,] _position;
        private int _turn;

        public Boart()
        {
            _turn = 1;
            _position = new File[3, 3];

        }

        public File[,] GetPosition()
        {
            return _position;
        }
        public bool Add(File file, int NRow, int NCol)
        {
            //usuario ingresa "X"
            if (_position[NRow, NCol] == null)
            {
                _position[NRow, NCol] = file;
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
            File file;

            file = this.WinnerByRow();
            if (file == null)
                file = this.WinnerByCol();
            if (file == null)
                file = this.WinnerByDig();

            return file;

        }

        public File WinnerByRow()
        {
            //usar un solo for
            for (int i = 0; i < _position.GetLength(0); i++)
            {
                if (_position[i, 0] != null && _position[i, 1] != null && _position[i, 2] != null)
                    if ((_position[i, 0].Type == _position[i, 1].Type) && _position[i, 2].Type == _position[i, 0].Type)
                        return _position[i, 0];
            }
            return null;
            // 0,0 0,1 0,2
            // 1,0 1,1 1,2
            // 2,0 2,1 2,2
        }
        public File WinnerByCol()
        {
            //usar un solo for

            for (int j = 0; j < _position.GetLength(1); j++)
            {
                if (_position[0, j] != null && _position[1, j] != null && _position[2, j] != null)
                    if ((_position[0, j].Type == _position[1, j].Type) && _position[2, j].Type == _position[0, j].Type)
                        return _position[0, j];
            }

            return null;
            // 0,0 1,0 2,0
            // 0,1 1,1 1,2
            // 0,2 1,2 2,2
        }

        //public File WinnerByRow()
        //{
        //    //usar un solo for
        //    for (int i = 0; i < _position.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < 1; j++)
        //        {
        //            if (_position[i, j] != null && _position[i, j + 1] != null && _position[i, j + 2] != null)
        //                if ((_position[i, j].Type == _position[i, (j + 1)].Type) && _position[i, (j + 2)].Type == _position[i, j].Type)
        //                    return _position[i, j];
        //        }
        //    }
        //    return null;
        //    // 0,0 0,1 0,2
        //    // 1,0 1,1 1,2
        //    // 2,0 2,1 2,2
        //}

        //public File WinnerByCol()
        //{
        //    //usar un solo for

        //    for (int i = 0; i < 1; i++)
        //    {
        //        for (int j = 0; j < _position.GetLength(1); j++)
        //        {
        //            if (_position[i, j] != null && _position[i + 1, j] != null && _position[i + 2, j] != null)
        //                if ((_position[i, j].Type == _position[(i + 1), j].Type) && _position[(i + 2), j].Type == _position[i, j].Type)
        //                    return _position[i, j];
        //        }
        //    }
        //    return null;
        //    // 0,0 1,0 2,0
        //    // 0,1 1,1 1,2
        //    // 0,2 1,2 2,2
        //}

        public File WinnerByDig()
        {
            //0,0 1,1 2,2
            //0,2 1,1 2,0

            if (_position[0, 0] != null && _position[1, 1] != null && _position[2, 2] != null)
                if ((_position[0, 0].Type == _position[1, 1].Type) && _position[2, 2].Type == _position[0, 0].Type)
                    return _position[0, 0];
                else
                    return null;

            if (_position[0, 2] != null && _position[1, 1] != null && _position[2, 2] != null)
                if ((_position[0, 2].Type == _position[1, 1].Type) && _position[2, 0].Type == _position[0, 2].Type)
                    return _position[0, 2];
                else
                    return null;
            else
                return null;

        }


        // public File Winner()
        //{
        //if (((_position[0].Type == _position[1].Type) && _position[2].Type == _position[1].Type) ||
        //    ((_position[3].Type == _position[4].Type) && _position[5].Type == _position[3].Type) ||
        //    ((_position[6].Type == _position[7].Type) && _position[8].Type == _position[7].Type) ||
        //    ((_position[0].Type == _position[3].Type) && _position[6].Type == _position[0].Type) ||
        //    ((_position[1].Type == _position[4].Type) && _position[7].Type == _position[1].Type) ||
        //    ((_position[2].Type == _position[5].Type) && _position[8].Type == _position[2].Type) ||
        //    ((_position[0].Type == _position[4].Type) && _position[8].Type == _position[0].Type) ||
        //    ((_position[2].Type == _position[4].Type) && _position[6].Type == _position[0].Type))
        //    return true;

        //metodos individuales 


        //if ((_position[0].Type == _position[1].Type) && _position[2].Type == _position[1].Type) 
        //    return _position[0];
        //if ((_position[3].Type == _position[4].Type) && _position[5].Type == _position[3].Type)
        //    return _position[3];
        //if ((_position[6].Type == _position[7].Type) && _position[8].Type == _position[7].Type)
        //    return _position[6];
        //if ((_position[0].Type == _position[3].Type) && _position[6].Type == _position[0].Type)
        //    return _position[0];
        //if ((_position[1].Type == _position[4].Type) && _position[7].Type == _position[1].Type)
        //    return _position[1];
        //if ((_position[2].Type == _position[5].Type) && _position[8].Type == _position[2].Type)
        //    return _position[2];
        //if ((_position[0].Type == _position[4].Type) && _position[8].Type == _position[0].Type)
        //    return _position[0];
        //if ((_position[2].Type == _position[4].Type) && _position[6].Type == _position[0].Type)
        //    return _position[2];
        //else
        //    return null;

        //si hay ganador se anuncia
        //si es null sigue

        //}


    }
}
