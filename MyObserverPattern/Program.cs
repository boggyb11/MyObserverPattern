using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hay hay = new Hay(true);
            hay.Add(new Horse("Jerry"));
            hay.Add(new Horse("Mouse"));
            hay.Add(new Horse("Don"));
            hay.Add(new Horse("Chipper"));
            hay.Add(new Horse("Lucy"));


            hay.FoodReady = false;


            hay.FoodReady = true;

            Console.ReadKey();
        }
    }
}
