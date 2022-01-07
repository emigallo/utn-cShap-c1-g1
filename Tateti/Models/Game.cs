using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Game
    {
        private  Board _board;     
        private User _user1;
        private User _user2;

        public Game()
        {
            this._board = new Board();
            this._user1 = new User(1);
            this._user2 = new User(2);
        }
        public Board GetBoard()
        {
            return this._board;
        }
        public User GetUser1()
        {
            return this._user1;
        }
        public User GetUser2()
        {
            return this._user2;
        }

        public void AddFile(File file, int NRow, int NCol)
        {
            this._board.Add(file, NRow, NCol);
        }
        //hacer dos add
        public void AddUser(string name,int id)
        {
            if(id==1)
                _user1.Name = name;
            if(id==2)  
                _user2.Name = name;
        }

        public File UserTurn()
        {
            if ((this._board.GetTurn() % 2) == 1)
            {
                return _user1.File;
                //user 1 turno
                //le envia la file
            }
            else
            {
                //turno user 2
                return _user2.File;
            }
        }        
        public bool GameState()
        {
            if(this._board.GetTurn() > 9)
            {
                return true;
            }else
                return false;
        }
    }
}
