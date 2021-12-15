using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Whale : Animal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Fin[] Fins;

        public Whale() : base(typeof(Whale))
        {
        }

        public Whale(string name) : base(name, typeof(Whale))
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

        public override int GetLimbsAmount() => Fins.Length + 1;
    }
}
