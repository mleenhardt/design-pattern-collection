namespace Composite
{
    public class BinaryOrNode : BinaryConditionalOperatorNode
    {
        static BinaryOrNode()
        {
            Operator = ConditionalOperator.Or;
        }

        public BinaryOrNode()
        {
        }

        public BinaryOrNode(BinaryNode left, BinaryNode right)
            : base(left, right)
        {
        }

        public BinaryOrNode(BinaryNode parent, BinaryNode left, BinaryNode right)
            : base(parent, left, right)
        {
        }

        public override bool Evaluate()
        {
            return Left.Evaluate() || Right.Evaluate();
        }
    }
}