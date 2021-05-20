using System;
using System.Collections.Generic;

namespace OG.ASTBuilding.TreeNodes
{
    /// <summary>
    /// Visits a single function declaration and builds a FunctionNode from it by building a BodyNode, IdNode, and setting return type of the node. Global symbol table for functions is checked for duplicate values.
    /// </summary>
    public class FunctionNodeListBuilder : AstBuilderErrorInheritor<List<FunctionNode>>
    {

        private readonly FunctionNodeExtractor _functionNodeExtractor;
        private readonly List<FunctionNode>    _functionNodes = new List<FunctionNode>();

        public FunctionNodeListBuilder(List<SemanticError> errs) : base(errs)
        {
            _functionNodeExtractor  = new FunctionNodeExtractor(errs);
        }
        public override List<FunctionNode> VisitFunctionDcls(OGParser.FunctionDclsContext context)
        {
            OGParser.FunctionDclContext  current       = context.functionDcl();
            OGParser.FunctionDclsContext nextFunctions = context.functionDcls();
            //If current is valid
            if (current != null && !current.IsEmpty)
            {
                //Console.WriteLine("\nFunction found. Detecting return type... "+current.GetText());
                _functionNodes.Add(_functionNodeExtractor.VisitFunctionDcl(current));
            }
            
            //If there are more functions to create nodes from
            if (nextFunctions != null && !nextFunctions.IsEmpty)
            {
                VisitFunctionDcls(nextFunctions);
            }

            return _functionNodes;
        }
    }
}