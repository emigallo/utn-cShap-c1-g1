﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tateti.Models
{
    public class File
    {
        public string Type { get; init; }

        public File(string type)
        {
            this.Type = type;
        }
    }
}
