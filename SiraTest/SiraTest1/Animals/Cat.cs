using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Cat : PlayableAnimal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Leg[] Legs;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female
        };

        public Cat() : base(typeof(Cat))
        {
        }

        public Cat(string name) : base(name, typeof(Cat))
        {
        }

        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body();
            Tail = new Tail();
            Legs = new Leg[4];
            for (int i = 0; i < Legs.Length; i++)
            {
                Legs[i] = new Leg();
            }
        }

        public override int GetLimbsAmount() => Legs.Length + 1;
    }
}
