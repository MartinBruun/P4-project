using System;
using System.Reflection;
using Antlr4.Runtime.Tree;
using OG.AST;

namespace OG.Compiler
{
    /// <summary>
    /// Creates a ParseTree from the OGParser and converts it into a decorated AST.
    /// Is responsible for the semantic analysis of the source file.
    /// </summary>
    public class TypeChecker<Node, Visitor> where Visitor : OGBaseVisitor<Node>,ISemanticErrorable, new()
    {
        public OGParser OGParser { get; set; }
        internal Visitor ProgramVisitor { get; set; }
        public IParseTree ParseTree { get; set; }
        public Node AST { get; set; }

        public TypeChecker(ParserContainer parser, string astTopNode="program")
        {
            OGParser = parser.OGParser;
            ProgramVisitor = new Visitor();
            if (astTopNode != "program") throw new NotImplementedException(); // The generics have been created, just need reflection
            ParseTree = OGParser.program(); // ADD reflection, so the rule isnt hardcoded to "program" but can be other rules. Needs careful handling.
            AST = CreateAST(astTopNode);
        }
        
        /// <summary>
        /// Method which creates the AST for the given topNode, defaulting to "program" as seen in the constructor.
        /// </summary>
        /// <param name="astTopNode">The CFG rule being chosen to generate an AST from</param>
        /// <returns></returns>
        private Node CreateAST(string astTopNode)
        {
            Node ast = ProgramVisitor.Visit(ParseTree);
            if (ProgramVisitor.SemanticErrors != null)
            {
                Console.WriteLine("\nSEMANTIC ERRORS DETECTED");
                foreach (SemanticError error in ProgramVisitor.SemanticErrors)
                {
                    Console.WriteLine(error);
                }
            }
            return ast;
        }
    }
}