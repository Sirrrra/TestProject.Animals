using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{
    public class Wing : Limb
    {
        public override void Propel()
        {
            Console.WriteLine($"Wing is moving");
        }
    }
}
