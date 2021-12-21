using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Dolfin : PlayableAnimal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Fin[] Fins;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female
        };

        public Dolfin() : base(typeof(Dolfin))
        {
        }

        public Dolfin(string name) : base(name, typeof(Dolfin))
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
        public override void Move()
        {
            for (int i = 0; i < Fins.Length; i++)
            {
                Fins[i].Propel();
            }
        }
    }
}
