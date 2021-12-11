using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.Animals
{
    public abstract class PlayableAnimal : Animal
    {
        public PlayableAnimal(Type type) : base(type)
        {
        }

        public PlayableAnimal(string name, Type type) : base(name, type)
        {
        }

        public void Play()
        {
            if (!IsWild)
            {
                Console.WriteLine($"{Type.Name} {Name} plays");
            }
            else
            {
                Console.WriteLine($"{Type.Name} plays");
            }
        }
    }
}
