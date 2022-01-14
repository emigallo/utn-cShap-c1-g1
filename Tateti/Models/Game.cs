using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Game
    {
        private Board _board;
        private User _user1;
        private User _user2;
        public Game()
        {
            this._board = new Board();
            this._user1 = new User(1, File.User1File);
            this._user2 = new User(2, File.User2File);
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
        public bool AddFile(File file, int NRow, int NCol)
        {
            return this._board.Add(file, NRow, NCol);
        }
        public void AddUser1(string name)
        {
            _user1.Name = name;
        }
        public void AddUser2(string name)
        {
            _user2.Name = name;
        }
        public File UserTurn()
        {
            if ((this._board.GetTurn() % 2) == 1)
            {
                return _user1.File;
            }
            else
            {
                return _user2.File;
            }
        }
        public bool GameTied()
        {
            if (this._board.GetTurn() > 9)
            {
                return true;
            }
            else
                return false;
        }
    }
}
