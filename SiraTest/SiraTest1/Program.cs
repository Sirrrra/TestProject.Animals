using SiraTest1.Animals;
using System;

namespace SiraTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Its animal creator program!\n");

            //var dog1 = new Dog("Pes1");
            //dog1.Play();
            //dog1.Name = "Pes2";
            //dog1.Head.Eat("chicken");

            var zoo = AnimalGenerator.Perform(100);

            zoo.ForEach(iterationObject => {
                if (iterationObject is PlayableAnimal)
                {
                    (iterationObject as PlayableAnimal).Play();
                }
            });
        }
    }
}
