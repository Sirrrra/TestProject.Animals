using System;
using System.Collections.Generic;
using System.Text;

namespace SiraTest1.BodyParts
{
    public class Head
    {
        public void Eat(string food)
        {
            //Приводим food к красивому написанию с большой буквы 
            //Берем первый элемент - его пишем в верхнем регистре, остальные оставляем как есть
            var correctFoodView = $"{food.Substring(0, 1).ToUpper()}{food.Substring(1, food.Length - 1)}";
            Console.WriteLine($"{correctFoodView} was eaten");
        }
    }
}
