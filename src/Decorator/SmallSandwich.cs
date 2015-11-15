namespace Decorator
{
    public class SmallSandwich : Sandwich
    {
        public override string GetDescription()
        {
            return "Small sandwich";
        }

        public override decimal GetPrice()
        {
            return 5;
        }
    }
}