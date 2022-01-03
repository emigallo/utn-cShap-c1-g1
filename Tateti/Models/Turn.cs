using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class Turn
    {
        public int NumberTurn { get; set; }

        public Turn()
        {
            this.NumberTurn = 0;
        }

        public void NextTurn()
        {
            this.NumberTurn = NumberTurn + 1;
        }
    }
}
