using DecoratorPatternBsp.Components;
using DecoratorPatternBsp.ConcreteComponents;
using DecoratorPatternBsp.Ingredients;
using System;

namespace DecoratorPatternBsp {
    class Program {
        static void Main(string[] args) {
            IceCream iceCreamWithWaffle = new Waffle();
            Console.WriteLine(iceCreamWithWaffle.GetDescription() + " " + iceCreamWithWaffle.CalcAmount() + " ");

            IceCream iceCreamWithCup = new Cup();
            iceCreamWithCup = new Vanille(iceCreamWithCup);
            iceCreamWithCup = new HoneySauce(iceCreamWithCup);
            Console.WriteLine(iceCreamWithCup.GetDescription() + " " + iceCreamWithCup.CalcAmount() + " ");

            IceCream IceCreamOnPlate = new Chocolate(new BerrySauce(new HoneySauce(new Cup())));
            Console.WriteLine(IceCreamOnPlate.GetDescription() + " " + IceCreamOnPlate.CalcAmount() + " ");
            Console.ReadKey();
        }
    }
}
