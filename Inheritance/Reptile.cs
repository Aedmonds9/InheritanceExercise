using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animals
    {
     public bool HasScales { get; set; }
     public bool ColdBlooded { get; set; }
     public string Climate { get; set; }
     public string Size { get; set; }

      public Reptile()
      {

      }
    
    public Reptile(int age, int legs, string name, bool hasBackbone, bool hasScales, bool coldBlooded, string climate, string size)
        {
            Age = age;
            Legs = legs;
            Name = name;
            HasBackbone = hasBackbone;
            Size = size;
            Climate = climate;
            HasScales = hasScales;
            ColdBlooded = coldBlooded;
        }
    }
}
