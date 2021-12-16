using SiraTest1.Animals;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //var cat1 = new Cat("Kitty");
            //cat1.Move();
            //Console.WriteLine($"Limbs count {cat1.GetLimbsAmount().ToString()}");

            
            var zoo = AnimalGenerator.Perform(50);

            var femaleZoo = zoo.Where(x => x.Sex == Sex.Female);

            var firstMiddle = zoo.FirstOrDefault(x => x.Sex == Sex.Middle);

            var zooSexes = zoo.Select(x => new TestClass(x.Sex).GetSexString()).ToList();

            var single = zoo.Single(x => x.IsWild);

            zoo.ForEach(x => {
                Console.WriteLine($"Type : {x.GetType().Name}. Sex : {x.Sex.ToString()}");
            });
        }
    }

    public class TestClass
    {
        public Sex _sex { get; set; }
        public TestClass(Sex sex)
        {
            _sex = sex;
        }

        public string GetSexString()
        {
            return $"Sex : {_sex.ToString()}";
        }
    }
}
