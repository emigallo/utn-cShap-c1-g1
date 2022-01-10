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
        public static string EmptyFile
        {
            get { return "-"; }
        }
        public static string User1File
        {
            get { return "X"; }
        }
        public static string User2File
        {
            get { return "O"; }
        }
        public File(string type)
        {
            this.Type = type;
        }
    }
}
