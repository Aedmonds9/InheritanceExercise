using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animals
    {
            public int Wings { get; set; }

           public string Type { get; set; }

            public bool Migrates { get; set; }

            public string FeatherColor { get; set; }

    public Bird()
        {

        }
        
        
    public Bird(int age, int legs, string name, bool hasBackbone, int wings, string type, bool migrates, string featherColor)
        {
            Age = age;
            Legs = legs;
            Name = name;
            HasBackbone = hasBackbone;
            FeatherColor = featherColor;
            Type = type;
            Migrates = migrates;
            Wings = wings;
        }




    }
}
