using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Frog : Animal
    {
        public Head Head;
        public Body Body;
        public Leg[] Legs;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female
        };

        public Frog() : base(typeof(Frog))
        {
        }

        public Frog(string name) : base(name, typeof(Frog))
        {
        }

        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body();
            Legs = new Leg[4];
            for (int i = 0; i < Legs.Length; i++)
            {
                Legs[i] = new Leg();
            }
        }

        public override int GetLimbsAmount() => Legs.Length + 1;
    }
}
