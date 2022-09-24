using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasFeathers { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool hasBackbone, int wings, string type, bool isWarmBlooded, bool hasFeathers)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            Wings = wings;
            Type = type;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
        }

     
    }
}
