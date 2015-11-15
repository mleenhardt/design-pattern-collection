namespace Decorator
{
    public class Client
    {
        public void Run()
        {
            Sandwich sandwich = new SmallSandwich();
            sandwich = new Ham(sandwich);
            sandwich = new Pickle(sandwich);

            // sandwich.GetDescription() --> "Small sandwich, ham, pickle"
            // sandwich.GetPrice() --> 7.75
        }
    }
}