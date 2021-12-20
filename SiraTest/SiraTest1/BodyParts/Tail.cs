using SiraTest1.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{   
    public class Tail : Limb
    {
        public override void Propel()
        {
            Console.WriteLine($"Tail is moving");
        }
    }
}
