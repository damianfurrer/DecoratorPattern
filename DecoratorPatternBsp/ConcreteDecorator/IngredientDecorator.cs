using DecoratorPatternBsp.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.ConcreteDecorator {
    abstract class IngredientDecorator : IceCream {
        public abstract string GetDescription();
    }
}
