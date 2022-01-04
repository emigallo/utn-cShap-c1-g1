using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class File
    {
        public string Type { get; init; }

        public File(int id)
        {
            if(id == 1)
            {
                this.Type = "X";
            }
            if (id == 2)
            {
                this.Type = "O";
            }
            
        }      
    }
}
