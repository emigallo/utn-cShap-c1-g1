﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tateti.Models;

namespace GUI.ViewModels
{
    public class GameTatetiViewModels
    {
        private Game _game;

        public GameTatetiViewModels()
        {
            _game = new Game();
        }
        public void AddUser1(string name)
        {
            this._game.AddUser1(name);
        }
        public void AddUser2(string name)
        {
            this._game.AddUser2(name);
        }
        public User GetUser1()
        {
            return this._game.GetUser1();
        }
        public User GetUser2()
        {
            return this._game.GetUser2();
        }

    }
}
