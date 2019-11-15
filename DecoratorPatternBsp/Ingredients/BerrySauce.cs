using DecoratorPatternBsp.Components;
using DecoratorPatternBsp.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.Ingredients {
    class BerrySauce : IngredientDecorator {
        IceCream _IceCream;
        public BerrySauce(IceCream iceCream) {
            this._IceCream = iceCream;
        }
        public override string GetDescription() {
            return _IceCream.GetDescription() + ",Berry Sauce";
        }

        public override double CalcAmount() {
            return .15 + _IceCream.CalcAmount();
        }
    }
}
