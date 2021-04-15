using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IAssignmentVisitor : IMathNodeVisitor,
        IBoolNodeVisitor, IPointReferenceNodeVisitor, IFunctionCallNodeVisitor, IPropertyAssignmentVisitor, IMathAssignmentVisitor, IBoolAssignmentVisitor, IPointReferenceAssignmentVisitor
    
    {

    }

    public interface IPropertyAssignmentVisitor : ICoodinateXyVisitor
    {

        public void Visit(PropertyAssignmentNode node);

    }
    
    

    public interface IMathAssignmentVisitor
    {
        public void Visit(MathAssignmentNode node);
    }
    
    public interface IMathFunctionCallAssigmentVisitor
    {
        public void Visit(FunctionCallAssignNode node);
    }


    public interface IBoolAssignmentVisitor
    {
        public void Visit(BoolAssignmentNode node);
    }

    public interface IPointReferenceAssignmentVisitor
    {
        public void Visit(PointAssignmentNode node);
    }

    public interface IIdAssignmentVisitor : IIdNodeVisitor
    {
        public void Visit(IdAssignNode node);
    }
}