using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Dog : PlayableAnimal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Leg[] Legs;

        public Dog() : base(typeof(Dog))
        {
        }

        public Dog(string name) : base(name, typeof(Dog))
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
