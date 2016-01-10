using System;

namespace Composite
{
    public class BinaryContainsNode : BinaryCriterionNode
    {
        public override bool Evaluate()
        {
            return TestInput.Contains(CriterionInput);
        }

        public override string PrintLiteral()
        {
            return $"{TestInput} Contains {CriterionInput}";
        }
    }
}