using System;

namespace Decorator
{
    public class Pickle : SandwichDecorator
    {
        public Pickle(Sandwich sandwich)
            : base(sandwich)
        {
        }

        public override string GetDescription()
        {
            return String.Concat(Sandwich.GetDescription(), ", pickle");
        }

        public override decimal GetPrice()
        {
            return Sandwich.GetPrice() + 1.25m;
        }
    }
}