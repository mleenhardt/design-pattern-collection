namespace Composite
{
    public abstract class BinaryCriterionNode : BinaryNode
    {
        public string TestInput { get; set; }
        public string CriterionInput { get; set; }
    }
}