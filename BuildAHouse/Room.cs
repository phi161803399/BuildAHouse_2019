﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAHouse
{
    class Room: Location
    {
        private string decoration;
        public Room(string name, string decoration):
            base(name)
        {
            this.decoration = decoration;
        }
    }
}