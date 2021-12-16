using SiraTest1.Animals;
using SiraTest1.BodyParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1
{
    public class AnimalGenerator
    {
        public static Sex[] Sex = (Sex[])Enum.GetValues(typeof(Sex));
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

        public static List<Animal> Perform(int count)
        {
            var result = new List<Animal>();
            var randomizer = new Random();
            for (int i = 0; i < count; i++)
            {
                var animalIndex = randomizer.Next(0, 11);
                var tempAnimal = Activator.CreateInstance(animals[animalIndex]);

                var availableSexes = tempAnimal.GetType().GetMethod("GetAvailableSexes").Invoke(tempAnimal, null);

                var sexRundomizer = new Random();
                var sexIndex = sexRundomizer.Next(0, (availableSexes as Sex[]).Length);

                (tempAnimal as Animal).Sex = (availableSexes as Sex[])[sexIndex];

                result.Add(tempAnimal as Animal);
            }

            return result;
        }
    }
}
