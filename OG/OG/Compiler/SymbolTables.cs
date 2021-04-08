﻿using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;

namespace OG.Compiler
{
    public class SymbolTables
    {
        private static Dictionary<IDNode, AstNode> GlobalTable { get; set; }
    }
}