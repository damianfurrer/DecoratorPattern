using DecoratorPatternBsp.Components;
using DecoratorPatternBsp.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.Ingredients {
    class HoneySauce : IngredientDecorator {
        IceCream _IceCream;
        public HoneySauce(IceCream iceCream) {
            this._IceCream = iceCream;
        }

        public override string GetDescription() {
            return _IceCream.GetDescription() + ",Honey";
        }

        public override double CalcAmount() {
            return .10 + _IceCream.CalcAmount();
        }
    }
}
