namespace Decorator
{
    public class LargeSandwich : Sandwich
    {
        public override string GetDescription()
        {
            return "Large sandwich";
        }

        public override decimal GetPrice()
        {
            return 10;
        }
    }
}