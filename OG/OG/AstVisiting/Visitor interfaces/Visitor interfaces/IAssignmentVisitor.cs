using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.AstVisiting
{
    public interface IAssignmentVisitor : IPropertyAssignmentVisitor,
        IMathAssignmentVisitor, IBoolAssignmentVisitor, IPointReferenceAssignmentVisitor, IFunctionCallAssignmentNodeVisitor
    
    {

    }
    
    public interface IFunctionCallAssignmentNodeVisitor : INativeFunctionCallsVisitor
    {
        public void Visit(FunctionCallAssignNode node);
    }

    public interface IPropertyAssignmentVisitor : ICoordinateXyVisitor, IPointReferenceNodeVisitor
    {

        public void Visit(PropertyAssignmentNode node);

    }
    
    public interface IMathAssignmentVisitor : IMathNodeVisitor, IMathFuncCallVisitor
    {
        public void Visit(MathAssignmentNode node);
    }


    public interface IBoolAssignmentVisitor : IBoolNodeVisitor, IBoolFuncCallVisitor
    {
        public void Visit(BoolAssignmentNode node);
    }

    public interface IPointReferenceAssignmentVisitor : IPointReferenceNodeVisitor, IPointFuncCallVisitor
    {
        public void Visit(PointAssignmentNode node);
    }

    public interface IIdAssignmentVisitor : IIdNodeVisitor
    {
        public void Visit(IdAssignNode node);
    }
}