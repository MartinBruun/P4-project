using System.Collections.Generic;
using OG.AST;
using OG.AST.Terminals;

namespace OG.Compiler
{
    public class SymbolTables
    {
        private static Dictionary<IDNode, ASTNode> GlobalTable { get; set; }
    }
}