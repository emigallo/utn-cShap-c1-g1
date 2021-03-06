using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class User
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public File File { get; init; }
        public User(int id, string type)
        {
            this.Id = id;
            this.File = new File(type);            
        }
    }
}
