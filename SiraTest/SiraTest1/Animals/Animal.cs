﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public abstract class Animal
    {
        public string Name;

        protected Type Type;

        public Sex Sex = Sex.Undefined;

        public abstract Sex[] GetAvailableSexes();

        //public static Sex[] Sex = (Sex[])Enum.GetValues(typeof(Sex));
        public bool IsWild => string.IsNullOrEmpty(Name);

        public Animal(Type type)
        {
            CreateBodyParts();
            Type = type;
            Console.WriteLine($"{Type.Name} created");
        }

        public Animal(string name, Type type)
        {
            CreateBodyParts();
            Name = name;
            Type = type;
            Console.WriteLine($"{Type.Name} {Name} created");
        }

        public abstract void CreateBodyParts();

        public abstract int GetLimbsAmount();

        public void Sleep()
        {
            if (!IsWild)
            {
                Console.WriteLine($"{Type.Name} {Name} is sleeping");
            }
            else
            {
                Console.WriteLine($"{Type.Name} is sleeping");
            }
        }

        public void Move()
        {
            if (!IsWild)
            {
                Console.WriteLine($"{Type.Name} {Name} is moving!");
            }
            else
            {
                Console.WriteLine($"{Type.Name} is moving!");
            }
        }
    }
}
