using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Game
    {
        private Boart _boart;     
        private User _user1;
        private User _user2;

        public Game()
        {
            this._boart = new Boart();
            this._user1 = new User(1);
            this._user2 = new User(2);
        }

        public void AddUser(string name)
        {
            _user1.Name = name;
        }
        
    }
}
