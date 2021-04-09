using System;
using Antlr4.Runtime.Tree;
using OG.ASTBuilding;

namespace OG
{
    public class SemanticsContainer<TVisitor, TNode>
        where TVisitor : OGBaseVisitor<TNode>, ISemanticErrorable, IUnnecessarySettingsErrorable, new()
    {
        /// <summary>
        /// Parser used to create parse tree from a start rule.
        /// </summary>
        private OGParser OGParser { get; set; }
        
        /// <summary>
        /// Parse tree visitor used to go through parse tree and create AST nodes
        /// </summary>
        private TVisitor ParseTreeVisitor { get; set; }
        
        /// <summary>
        /// Parse tree to traverse. 
        /// </summary>
        private IParseTree ParseTree { get; set; }

        public TNode AST { get; private set; }

        public SemanticsContainer(OGParser parser)
        {
            OGParser = parser;
            ParseTreeVisitor = new TVisitor();
            ParseTree = CreateStartNode();
            AST = buildAST();
        }

        private TNode buildAST()
        {
            TNode ast = ParseTreeVisitor.Visit(ParseTree);
            
            if (ParseTreeVisitor.SemanticErrors.Count != 0)
            {
                Console.WriteLine("\nGLOBAL NAME COLLISIONS DETECTED");
                for (int i=0; i < ParseTreeVisitor.SemanticErrors.Count; i++)
                {
                    Console.WriteLine($"{i+1}.\n{ParseTreeVisitor.SemanticErrors[i]}");
                }
                
                Console.WriteLine("");
            }

            return AST;
        }
        
        private IParseTree CreateStartNode()
        {
            try
            {
                IParseTree parseTree =
                    (IParseTree) OGParser.GetType().GetMethod(ParseTreeVisitor.TopNode).Invoke(OGParser, null);
                return parseTree;
            }
            catch(NullReferenceException nullError)
            {
                throw new NullReferenceException(
                    $"TypeChecker.CreateTopNodeParseTree tries to access method ({ParseTreeVisitor.TopNode}) which does not exist.\n" +
                    $"Check if the TopNode in the Visitor {ParseTreeVisitor.GetType()} is spelled correctly as in the OG.g4 file.");
            }
        }
    }
}