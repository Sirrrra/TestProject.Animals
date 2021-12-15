using SiraTest1.Animals;
using SiraTest1.BodyParts;
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
            typeof(Whale),
            typeof(Chicken),
            typeof(Dolfin),
            typeof(Frog),
            typeof(Grasshopper),
            typeof(Hummingbird),
            typeof(Parrot),
            typeof(Snake)
        };

       /* public enum Sex 
        {
            Undefined,
            Male,
            Female,
            Middle
        }*/
        public static List<Animal> Perform(int count)
        {
            var result = new List<Animal>();
            var randomizer = new Random();
            //var sexRandomizer = new Random();
            //var sexIndex1 = Enum.GetValues(typeof(Sex));

            for (int i = 0; i < count; i++)
            {
                var animalIndex = randomizer.Next(0, 11);
                //     var sexIndex = sexRandomizer.Next(0, 4);
                var tempAnimal = Activator.CreateInstance(animals[animalIndex]); //, sexIndex1.GetValue(sexIndex));
                result.Add(tempAnimal as Animal);
            }

            return result;
        }
    }
}
