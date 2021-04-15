namespace OG.AstVisiting
{
    public interface IPropertyAssignmentVisitable
    {
        public void Accept(IPropertyAssignmentVisitor visitor);
    }

    /*
    public class ToStringVisitor : IAstVisitor
    {
        public void Visit(AdditionNode n)
        {
            Console.WriteLine("This is addition___: " + n.ToString());
        }

        public void Visit(DivisionNode n)
        {
            Console.WriteLine(n.ToString());
        }

        public void Visit(LessThanComparerNode n)
        {
            Console.WriteLine(n.ToString());
        }

        public void Visit(GreaterThanComparerNode n)
        {
            Console.WriteLine(n.ToString());
        }

      
    }
    */
}