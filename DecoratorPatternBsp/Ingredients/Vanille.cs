using DecoratorPatternBsp.Components;
using DecoratorPatternBsp.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.Ingredients {
    class Vanille : IngredientDecorator {
        IceCream _IceCream;

        public Vanille(IceCream iceCream) {
            this._IceCream = iceCream;
        }

        public override string GetDescription() {
            return _IceCream.GetDescription() + ",Vanille";
        }

        public override double CalcAmount() {
            return 1.50 + _IceCream.CalcAmount();
        }
    }
}
