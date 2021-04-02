using System;
using System.Reflection;
using Antlr4.Runtime.Tree;
using OG.AST;

namespace OG.Compiler
{
    /// <summary>
    /// Creates a ParseTree from the OGParser and converts it into a decorated AST (N).
    /// Is responsible for the semantic analysis of the source file.
    /// </summary>
    /// <typeparam name="N">Generic "Node" type, which the TypeChecker creates</typeparam>
    /// <typeparam name="V">Generic "Visitor" type, showing what visitor is needed to traverse the Node</typeparam>
    public class TypeChecker<N, V> where V : OGBaseVisitor<N>,ISemanticErrorable, new()
    {
        public OGParser OGParser { get; set; }
        internal V Visitor { get; set; }
        public IParseTree ParseTree { get; set; }
        public N AST { get; set; }

        public TypeChecker(OGParser ogParser)
        {
            OGParser = ogParser;
            Visitor = new V();
            // OGParser.REFLECTION(Visitor.TopNode); Should give "program" if ProgramVisitor or "machineSettings" if MachineVisitor.
            ParseTree = OGParser.program(); // ADD reflection, so the rule isnt hardcoded to "program" but can be other rules. Needs careful handling.
            AST = CreateAST();
        }
        
        /// <summary>
        /// Method which creates the AST for the given topNode
        /// </summary>
        /// <param name="astTopNode">The CFG rule being chosen to generate an AST from</param>
        /// <returns></returns>
        private N CreateAST()
        {
            N ast = Visitor.Visit(ParseTree);
            
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