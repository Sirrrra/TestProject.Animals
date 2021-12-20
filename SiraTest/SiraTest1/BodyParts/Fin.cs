using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{
    public class Fin : Limb
    {
        public override void Propel()
        {
            Console.WriteLine($"Fin is moving");
        }
    }
}
