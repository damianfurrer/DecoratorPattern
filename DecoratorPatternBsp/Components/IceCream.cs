using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternBsp.Components {
    abstract class IceCream {
        public string _Description = "Unknown IceCream";

        public string GetDescription() {
            return _Description;
        }
        public abstract double CalcAmount();
    }
}
