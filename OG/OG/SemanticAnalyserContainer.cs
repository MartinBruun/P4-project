using OG.ASTBuilding;

namespace OG
{
    /// <summary>
    /// Container performing all semantic analysis of the AST. All decoration of the AST before code generation happens here. 
    /// </summary>
    public class SemanticAnalyserContainer
    {
        //TypeChecker<ProgramNode, ASTBuilderVisitor> typeChecker = new TypeChecker<ProgramNode,ASTBuilderVisitor>(parCon.OGParser);
        public ProgramNode AST { get; private set; }

        public SemanticAnalyserContainer(ProgramNode ast)
        {
            AST = ast;
        }
    }
}