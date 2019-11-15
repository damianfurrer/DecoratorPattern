using DecoratorPatternBsp.Components;
using DecoratorPatternBsp.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.Ingredients {
    class Chocolate : IngredientDecorator {
        IceCream _IceCream;
        public Chocolate(IceCream iceCream) {
            this._IceCream = iceCream;
        }

        public override string GetDescription() {
            return _IceCream.GetDescription() + ",Chocolate";
        }

        public override double CalcAmount() {
            return 1.50 + _IceCream.CalcAmount();
        }
    }
}
