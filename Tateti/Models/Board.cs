using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Board
    {
        //matriz de 9 posiciones para el tablero
        private File[,] _position;
        private int _turn;
        //llenar el tablero
        public Board()
        {
            _turn = 1;
            _position = new File[3, 3];
            this.FillBoard();

        }
        void FillBoard()
        {
            for (int i = 0; i < _position.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _position[i, j] = new File("-");
                }
            }
        }
        public File[,] GetPosition()
        {
            return _position;
        }
        public bool Add(File file, int NRow, int NCol)
        {
            //validacion de las filas y col
            //usuario ingresa "X"
            if (NRow > 2 || NCol > 2)
            {
                throw new IndexOutOfRangeException();
            }
            if (_position[NRow, NCol].Type == "-")
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
        //cambiar nombre
        public File GetWinner()
        {
            File file;

            file = this.WinnerByRow();
            if (file == null)
                file = this.WinnerByCol();
            if (file == null)
                file = this.WinnerByDig();

            return file;

        }
        //limpiar los if
        public File WinnerByRow()
        {
            //usar un solo for
            for (int i = 0; i < _position.GetLength(0); i++)
            {
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
                if ((_position[0, j].Type == _position[1, j].Type) && _position[2, j].Type == _position[0, j].Type)
                    return _position[0, j];
            }

            return null;
            // 0,0 1,0 2,0
            // 0,1 1,1 1,2
            // 0,2 1,2 2,2
        }



        public File WinnerByDig()
        {
            //0,0 1,1 2,2
            //0,2 1,1 2,0


            if ((_position[0, 0].Type == _position[1, 1].Type) && _position[2, 2].Type == _position[0, 0].Type)
                return _position[0, 0];

            if ((_position[0, 2].Type == _position[1, 1].Type) && _position[2, 0].Type == _position[0, 2].Type)
                return _position[0, 2];

            return null;

        }





    }
}
