using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{
    public class Leg : Limb
    {
        public override void Propel()
        {
            Console.WriteLine($"Leg is moving");
        }
    }
}
