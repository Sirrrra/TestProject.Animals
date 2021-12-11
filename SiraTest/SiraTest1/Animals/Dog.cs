using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public class Dog
    {
        public string Name;
        public Head Head;
        public Body Body;
        public Tail Tail;
        public Leg[] Legs;

        public Dog()
        {
            Console.WriteLine("Dog created");
            CreateBodyParts();
        }

        public Dog(string name) 
        {
            Name = name;
            Console.WriteLine($"Dog {Name} created");
            CreateBodyParts();
        }

        public void Play()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Console.WriteLine($"Dog {Name} plays");
            }
            else
            {
                Console.WriteLine("Dog plays");
            }
        }

        private void CreateBodyParts()
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
    }
}
