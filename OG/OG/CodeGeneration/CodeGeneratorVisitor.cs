using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using OG.AstVisiting.Visitors.ExpressionReduction;

namespace OG.CodeGeneration
{
    /// <summary>
    /// The class responsible for converting an AST into executable G-code.
    /// </summary>
    public class CodeGeneratorVisitor : IVisitor, IGCodeStringEmitter
    {
        private readonly SymbolTable _symbolTable = new SymbolTable();
        private readonly List<SemanticError> _errors;

        private readonly LineEmitter _lineEmitter = null;
        private readonly CurveEmitter _curveEmitter = null;
        private ExpressionReducerVisitor _reducer = null;
        private List<IGCodeCommand> _gCodeCommands = new List<IGCodeCommand>();
        public event CodeGenerationNotification CodeGenerationNotification;
        public GCodeCommandText ResultCommand { get; private set; } = null;
        
        public CodeGeneratorVisitor(Dictionary<string, AstNode> symbolTable, List<SemanticError> errors,  ExpressionReducerVisitor reducer)
        {
            _symbolTable.Elements = symbolTable;
            _errors = errors;
            _lineEmitter = new LineEmitter( _errors);
            _curveEmitter = new CurveEmitter( _errors);
            _reducer = reducer;
        }

        public string Emit()
        {
            string result = "";
            foreach (IGCodeCommand gCodeCommand in _gCodeCommands)
            {
                result += gCodeCommand.CreateGCodeTextCommand();
            }
            
            CodeGenerationNotification?.Invoke(result);
            return result;
        }

        public void ClearResult()
        {
            _gCodeCommands = new List<IGCodeCommand>();
        }
        
        public object Visit(BoolAssignmentNode node)
        {
            return node;
        }

        public object Visit(FunctionCallAssignNode node)
        {
            return node;
        }

        public object Visit(IdAssignNode node)
        {
            return node;
        }

        public object Visit(MathAssignmentNode node)
        {
            return node;
        }

        public object Visit(PointAssignmentNode node)
        {
            return node;
        }

        public object Visit(PropertyAssignmentNode node)
        {
            return node;
        }

        public object Visit(ParameterTypeNode node)
        {
            return node;
        }

        public object Visit(CurveCommandNode node)
        {
            _curveEmitter.SetupGCodeResult(node);
           _gCodeCommands.Add(_curveEmitter.ResultCommand);
           _curveEmitter.ClearResult();
            return node;
        }

        public object Visit(DrawCommandNode node)
        {
            // ShapeNode shape = (ShapeNode) _symbolTable.GetElementBySymbolTableAddress(node.Id.SymboltableAddress);
            // shape.Accept(this);
           node.Id.DeclaredValue.Accept(this);
            return node;
        }

        public object Visit(LineCommandNode node)
        {
            _lineEmitter.SetupGCodeResult(node);
            _gCodeCommands.Add(_lineEmitter.ResultCommand);
            _lineEmitter.ClearResult();
            return node;
        }

        public object Visit(NumberIterationNode node)
        {
            node.Body.Accept(this);
            return node;
        }

        public object Visit(UntilFunctionCallNode node)
        {
            return node;
        }

        public object Visit(UntilNode node)
        {
            return node;
        }

        public object Visit(BoolDeclarationNode node)
        {
            return node;
        }

        public object Visit(NumberDeclarationNode node)
        {
            return node;
        }

        public object Visit(PointDeclarationNode node)
        {
            return node;
        }

        public object Visit(BoolExprIdNode node)
        {
            return node;
        }

        public object Visit(BodyNode node)
        {
            foreach (StatementNode nodeStatementNode in node.StatementNodes)
            {
               nodeStatementNode.Accept(_reducer);////
               nodeStatementNode.Accept(this);
            }
            return node;
        }

        public object Visit(AndComparerNode node)
        {
            return node;
        }

        public object Visit(BoolNode node)
        {
            return node;
        }

        public object Visit(EqualsComparerNode node)
        {
            return node;
        }

        public object Visit(GreaterThanComparerNode node)
        {
            return node;
        }

        public object Visit(LessThanComparerNode node)
        {
            return node;
        }

        public object Visit(NegationNode node)
        {
            return node;
        }

        public object Visit(OrComparerNode node)
        {
            return node;
        }

        public object Visit(BoolFunctionCallNode node)
        {
            return node;
        }

        public object Visit(FunctionCallNode node)
        {
            return node;
        }

        public object Visit(FunctionCallParameterNode node)
        {
            return node;
        }

        public object Visit(MathFunctionCallNode node)
        {
            return node;
        }

        public object Visit(ParameterNode node)
        {
            return node;
        }

        public object Visit(FunctionNode node)
        {
            return node;
        }

        public object Visit(AdditionNode node)
        {
            return node;
        }

        public object Visit(DivisionNode node)
        {
            return node;
        }

        public object Visit(MathIdNode node)
        {
            return node;
        }

        public object Visit(MultiplicationNode node)
        {
            return node;
        }

        public object Visit(PowerNode node)
        {
            return node;
        }

        public object Visit(SubtractionNode node)
        {
            return node;
        }

        public object Visit(PointFunctionCallNode node)
        {
            return node;
        }

        public object Visit(PointReferenceIdNode node)
        {
            return node;
        }

        public object Visit(ShapeEndPointNode node)
        {
            return node;
        }

        public object Visit(ShapePointRefNode node)
        {
            return node;
        }

        public object Visit(ShapeStartPointNode node)
        {
            return node;
        }

        public object Visit(TuplePointNode node)
        {
            return node;
        }

        public object Visit(FalseNode node)
        {
            return node;
        }

        public object Visit(IdNode node)
        {
            return node;
        }

        public object Visit(NumberNode node)
        {
            return node;
        }

        public object Visit(TrueNode node)
        {
            return node;
        }

        public object Visit(SizePropertyNode node)
        {
            return node;
        }

        public object Visit(WorkAreaSettingNode node)
        {
            return node;
        }

        public object Visit(AstNode node)
        {
            return node;
        }

        public object Visit(DrawNode node)
        {
            foreach (DrawCommandNode nodeDrawCommand in node.drawCommands)
            {
                nodeDrawCommand.Accept(this);
            }

            return node;
        }

        public object Visit(ProgramNode node)
        {
            return node.drawNode.Accept(this);
        }

        public object Visit(ShapeNode node)
        {
            return node.Body.Accept(this);
        }

        public object Visit(CoordinateXyValueNode node)
        {
            return node;
        }


    }

}