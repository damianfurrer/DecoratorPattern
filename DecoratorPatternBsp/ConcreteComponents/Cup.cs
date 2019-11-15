using DecoratorPatternBsp.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.ConcreteComponents {
    class Cup : IceCream {
        public Cup() {
            this._Description = "Cup";
        }
        public override double CalcAmount() {
            return 1.99;
        }
    }
}
