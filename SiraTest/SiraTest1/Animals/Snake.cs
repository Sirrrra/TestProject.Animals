using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Snake : Animal
    {
        public Head Head;
        public Body Body;
        public Tail Tail;

        public override Sex[] GetAvailableSexes() => new Sex[]
        {
            Sex.Male,
            Sex.Female,
            Sex.Middle
        };

        public Snake() : base(typeof(Snake))
        {
        }

        public Snake(string name) : base(name, typeof(Snake))
        {
        }

        public override void CreateBodyParts()
        {
            Head = new Head();
            Body = new Body();
            Tail = new Tail();
        }

        public override int GetLimbsAmount() => 1;
    }
}
