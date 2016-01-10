namespace Composite
{
    public class BinaryAndNode : BinaryConditionalOperatorNode
    {
        static BinaryAndNode()
        {
            Operator = ConditionalOperator.And;
        }

        public BinaryAndNode()
        {
        }

        public BinaryAndNode(BinaryNode left, BinaryNode right)
            : base(left, right)
        {
        }

        public BinaryAndNode(BinaryNode parent, BinaryNode left, BinaryNode right)
            : base(parent, left, right)
        {
        }

        public override bool Evaluate()
        {
            return Left.Evaluate() && Right.Evaluate();
        }
    }
}