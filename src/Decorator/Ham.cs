using System;

namespace Decorator
{
    public class Ham : SandwichDecorator
    {
        public Ham(Sandwich sandwich)
            : base(sandwich)
        {
        }

        public override string GetDescription()
        {
            return String.Concat(Sandwich.GetDescription(), ", ham");
        }

        public override decimal GetPrice()
        {
            return Sandwich.GetPrice() + 1.50m;
        }
    }
}