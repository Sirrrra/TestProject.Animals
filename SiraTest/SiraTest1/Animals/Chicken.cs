using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Chicken : Animal
    {
        public Head Head;
        public Body Body;
        public Wing[] Wings;
        public Leg[] Legs;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female
        };

        public Chicken() : base(typeof(Chicken))
        {
        }

        public Chicken(string name) : base(name, typeof(Chicken))
        {
        }

        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body();
            Wings = new Wing[2];
            for (int i = 0; i < Wings.Length; i++)
            {
                Wings[i] = new Wing();
            }
            Legs = new Leg[2];
            for (int x = 0; x < Legs.Length; x++)
            {
                Legs[x] = new Leg();
            }
        }

        public override int GetLimbsAmount() => Legs.Length + Wings.Length;
        public override void Move()
        {
            for (int i = 0; i < Legs.Length; i++)
            {
                Legs[i].Propel();
            }
            for (int x = 0; x < Wings.Length; x++)
            {
                Wings[x].Propel();
            }

        }
    }
}
