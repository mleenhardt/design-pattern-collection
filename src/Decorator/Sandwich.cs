namespace Decorator
{
    /// <summary>
    /// An abstract class that will be implemented by actual sandwiches and sandwich decorators.
    /// </summary>
    public abstract class Sandwich
    {
        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }
}