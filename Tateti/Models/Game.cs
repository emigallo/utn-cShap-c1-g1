using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Game
    {
        public  Boart _boart;     
        private User _user1;
        private User _user2;

        public Game()
        {
            this._boart = new Boart();
            this._user1 = new User(1);
            this._user2 = new User(2);
        }

        public void AddUser(string name,int id)
        {
            if(id==1)
                _user1.Name = name;
            if(id==2)  
                _user2.Name = name;
        }

        public void UserTurn()
        {
            if ((this._boart.GetTurn() % 2) == 1)
            {
                //user 1 turno
                //le envia la file
            }
            else
            {
                //turno user 2
            }

        }        
    }
}
