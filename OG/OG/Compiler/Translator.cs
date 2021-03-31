﻿using System;
using OG.AST;

namespace OG.Compiler
{
    /// <summary>
    /// Takes a decorated AST from the TypeChecker and gives an Intermediate Representation.
    /// Is responsible for converting the AST to a unified standard, which executable code can be generated from.
    /// </summary>
    public class Translator<T>
    {
        public T Node { get; set; }
        
        // public IntermediateRepresentation IR {get; set;}
        public Translator(T astNode)
        {
            Node = astNode;
            // IR = DoSomethingWith(Node);
        }
    }
}