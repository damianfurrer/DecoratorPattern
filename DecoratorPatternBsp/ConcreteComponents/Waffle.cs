using DecoratorPatternBsp.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.ConcreteComponents {
    class Waffle : IceCream {
        public Waffle() {
            this._Description = "Waffle";
        }
        public override double CalcAmount() {
            return 2.99;
        }
    }
}
