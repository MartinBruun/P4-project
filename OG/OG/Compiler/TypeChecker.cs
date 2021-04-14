﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding;

namespace OG.Compiler
{
    /// <summary>
    /// Creates a ParseTree from the OGParser and converts it into a decorated AST (N).
    /// Is responsible for the semantic analysis of the source file.
    /// </summary>
    /// <typeparam name="TNode">Generic "Node" type, which the TypeChecker creates</typeparam>
    /// <typeparam name="TVisitor">Generic "Visitor" type, showing what visitor is needed to traverse the Node</typeparam>
    public class TypeChecker<TNode, TVisitor> where TVisitor : OGBaseVisitor<TNode>,ISemanticErrorable, new()
    {
        public OGParser OGParser { get; set; }
        internal TVisitor Visitor { get; set; }
        public IParseTree ParseTree { get; set; }
        public TNode AST { get; set; }

        public TypeChecker(OGParser ogParser)
        {
            OGParser = ogParser;
            Visitor = new TVisitor();
            ParseTree = CreateTopNodeParseTree();
            AST = CreateAST();
        }

        /// <summary>
        /// Method which creates a ParseTree depending on the chosen Visitor for the TypeChecker.
        /// </summary>
        /// <returns>A ParseTree depending on the visitor (ie. "ProgramVisitor" should call "OGParser.program()")</returns>
        /// <exception cref="NullReferenceException">Exception thrown, if the Visitor.TopNode is set to a wrong method name</exception>
        private IParseTree CreateTopNodeParseTree()
        {
            try
            {
                IParseTree parseTree =
                    (IParseTree) OGParser.GetType().GetMethod(Visitor.TopNode).Invoke(OGParser, null);
                return parseTree;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException(
                    $"TypeChecker.CreateTopNodeParseTree tries to access method ({Visitor.TopNode}) which does not exist.\n" +
                    $"Check if the TopNode in the Visitor {Visitor.GetType()} is spelled correctly as in the OG.g4 file.");
            }
        }
        
        /// <summary>
        /// Method which creates the AST for the given topNode
        /// </summary>
        /// <param name="astTopNode">The CFG rule being chosen to generate an AST from</param>
        /// <returns></returns>
        private TNode CreateAST()
        {
            TNode ast = Visitor.Visit(ParseTree);
            
            if (Visitor.SemanticErrors.Count != 0)
            {
                Console.WriteLine("\nSEMANTIC ERRORS DETECTED");
                for (int i=0; i < Visitor.SemanticErrors.Count; i++)
                {
                    Console.WriteLine($"{i+1}.\n{Visitor.SemanticErrors[i]}");
                }
                
                Console.WriteLine("");
            }
            
            return ast;
        }
    }
}