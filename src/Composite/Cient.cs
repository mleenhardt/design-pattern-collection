namespace Composite
{
    public class Cient
    {
        public void Run()
        {
            var tree = new BinaryAndNode
            {
                Left = new BinaryContainsNode
                {
                    TestInput = "cccccc",
                    CriterionInput = "c"
                },
                Right = new BinaryAndNode
                {
                    Left = new BinaryContainsNode
                    {
                        TestInput = "cccccc",
                        CriterionInput = "c"
                    },
                    Right = new BinaryContainsNode
                    {
                        TestInput = "cccccc",
                        CriterionInput = "c"
                    }
                }
            };

            var result = tree.Evaluate();
            var literal = tree.PrintLiteral();
        }
    }
}