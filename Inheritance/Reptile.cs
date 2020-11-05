﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public bool HasScales { get; set; }

        public string Type { get; set; }

        public string Defense { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool hasBackbone, bool isColdBlooded, bool hasScales, string type, string defense)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Type = type;
            Defense = defense;
        }
    }
}
