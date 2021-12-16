using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Parrot : PlayableAnimal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Wing[] Wings;
        public Leg[] Legs;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female
        };

        public Parrot() : base(typeof(Parrot))
        {
        }

        public Parrot(string name) : base(name, typeof(Parrot))
        {
        }
        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body(); 
            Tail = new Tail();
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

        public override int GetLimbsAmount() => Legs.Length + Wings.Length + 1;
    }
}
