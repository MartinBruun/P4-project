using System.Collections.Generic;
using OG.AST;
using OG.AST.Functions;
using OG.AST.Shapes;

namespace OG
{
    public interface IGlobalNameCollissionErrorable : ISemanticErrorable, ITopNodeable
    {
        public GlobalTableHandler handler { get; set; }

    }

    public class GlobalTableHandler : IGlobalTableHandler
    {
        public List<SemanticError> AddShapeToGlobalTable(ShapeNode node)
        {
            throw new System.NotImplementedException();
        }

        public List<SemanticError> AddFunctionToGlobalTable(FunctionNode node)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IGlobalTableHandler
    {
        public List<SemanticError> AddShapeToGlobalTable(ShapeNode node);
        public List<SemanticError> AddFunctionToGlobalTable(FunctionNode node);
    }
}