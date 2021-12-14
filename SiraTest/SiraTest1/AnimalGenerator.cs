using SiraTest1.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1
{
    public class AnimalGenerator
    {
        public static List<Type> animals => new List<Type>
        {
            typeof(Cat),
            typeof(Dog),
            typeof(Fish),
            typeof(Whale)
        };

        public static List<Animal> Perform(int count)
        {
            var result = new List<Animal>();
            var randomizer = new Random();
            for (int i = 0; i < count; i++)
            {
                var animalIndex = randomizer.Next(0, 3);
                var tempAnimal = Activator.CreateInstance(animals[animalIndex]);
                result.Add(tempAnimal as Animal);
            }

            return result;
        }
    }
}
