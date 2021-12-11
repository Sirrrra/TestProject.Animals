using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Fish : Animal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Fin[] Fins;

        public Fish() : base(typeof(Fish))
        {
        }

        public Fish(string name) : base(name, typeof(Fish))
        {
        }

        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body();
            Tail = new Tail();
            Fins = new Fin[3];
            for (int i = 0; i < Fins.Length; i++)
            {
                Fins[i] = new Fin();
            }
        }
    }
}
