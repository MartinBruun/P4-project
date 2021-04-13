using System;
using System.Collections.Generic;
using OG.ASTBuilding.Functions;

namespace OG.AST.Functions
{
    /// <summary>
    /// Visits a single function declaration and builds a FunctionNode from it by building a BodyNode, IdNode, and setting return type of the node. Global symbol table for functions is checked for duplicate values.
    /// </summary>
    public class FunctionNodeListBuilder : OGBaseVisitor<List<FunctionNode>>
    {
   
        private readonly FunctionNodeExtractor _functionNodeExtractor = new FunctionNodeExtractor();
        private readonly List<FunctionNode>    _functionNodes = new List<FunctionNode>();

        public override List<FunctionNode> VisitFunctionDcls(OGParser.FunctionDclsContext context)
        {
            OGParser.FunctionDclContext  current       = context.functionDcl();
            OGParser.FunctionDclsContext nextFunctions = context.functionDcls();
            //If current is valid
            if (current != null && !current.IsEmpty)
            {
                Console.WriteLine("\nFunction found. Detecting return type... ");
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