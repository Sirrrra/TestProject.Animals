using SiraTest1.Animals;
using System;

namespace SiraTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Its animal creator program!\n");

            var dog1 = new Dog("Pes1");
            dog1.Play();
        }
    }
}
