﻿using PetternDecorator.DecoratorTest;
using System;
using PetternDecorator.DecoratorTest.Decorator;

namespace PetternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IObjectTest _objectTest = new DecoratorFirst(new DecoratorTwo(new ObjectTest()));
            _objectTest.GetText();

            ObjectTestBase _objectTestTwo = new DecoratorTwo(new DecoratorFirst(new ObjectTest()));
            _objectTestTwo.GetText();

            Console.WriteLine("--- End --- offline");

            //RunTimeTest

            while(true)
            {
                Console.WriteLine("Please prees key or press Enter to exite programm");
                ConsoleKeyInfo keyPress = Console.ReadKey();
                Console.WriteLine($"{1}", keyPress.Key.ToString());
            }
        }
    }
}
