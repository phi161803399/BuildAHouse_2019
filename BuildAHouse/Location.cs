﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAHouse
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public Location[] Exits;
        public string Description
        {
            get
            {
                string description = $"You're standing in the {Name}.{Environment.NewLine}You see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}