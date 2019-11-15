using DecoratorPatternBsp.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.ConcreteComponents {
    class Plate : IceCream {
        public Plate() {
            this._Description = "Plate";
        }
        public override double CalcAmount() {
            return 0.99;
        }
    }
}
