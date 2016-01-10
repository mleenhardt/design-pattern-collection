using System;

namespace Composite
{
    public abstract class BinaryConditionalOperatorNode : BinaryNode
    {
        public static ConditionalOperator Operator { get; protected set; }

        public BinaryNode Parent { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }

        protected BinaryConditionalOperatorNode()
        {
        }

        protected BinaryConditionalOperatorNode(BinaryNode left, BinaryNode right)
        {
            Left = left;
            Right = right;
        }

        protected BinaryConditionalOperatorNode(BinaryNode parent, BinaryNode left, BinaryNode right)
            : this(left, right)
        {
            Parent = parent;
        }

        public override string PrintLiteral()
        {
            return String.Format("{0}{1} {2} {3}{4}",
                Parent != null ? "(" : String.Empty,
                Left.PrintLiteral(),
                Operator,
                Right.PrintLiteral(),
                Parent != null ? ")" : String.Empty);
        }
    }
}