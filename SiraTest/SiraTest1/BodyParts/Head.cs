using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{
    public class Head
    {
        public void Eat(string food)
        {
            var correctFoodView = $"{food.Substring(0, 1).ToUpper()}{food.Substring(1, food.Length - 1)}";
            Console.WriteLine($"{correctFoodView} was eaten");
        }
    }
}
