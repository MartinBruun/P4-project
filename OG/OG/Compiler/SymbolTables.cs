using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.Compiler
{
    public class SymbolTables
    {
        private static Dictionary<IdNode, AstNode> GlobalTable { get; set; }
    }
}