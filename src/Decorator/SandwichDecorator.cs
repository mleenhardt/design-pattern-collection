namespace Decorator
{
    /// <summary>
    /// The base class for all sandwich decorators (i.e. sandwich topping)
    /// </summary>
    public abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich Sandwich;

        protected SandwichDecorator(Sandwich sandwich)
        {
            Sandwich = sandwich;
        }
    }
}