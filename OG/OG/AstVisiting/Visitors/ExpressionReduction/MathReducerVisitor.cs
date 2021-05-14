using System;
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
using OG.Compiler;

namespace OG.AstVisiting.Visitors.ExpressionReduction
{
    public class MathReducerVisitor : IVisitor, ISemanticErrorable
    {
        private SymbolTable _symbolTable = new SymbolTable();
        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        private readonly MathArithmeticCalculator _arithmeticPerformer;
        

        public MathReducerVisitor(Dictionary<string, AstNode> symTab, List<SemanticError> errs)
        {
            SemanticErrors = errs;
            _symbolTable.Elements = symTab;
            _arithmeticPerformer = new MathArithmeticCalculator(_symbolTable, errs, this);
        }
        
        public object Visit(BoolAssignmentNode node)
        {
            return node;
        }

        public object Visit(FunctionCallAssignNode node)
        {
            NumberDeclarationNode id = (NumberDeclarationNode) _symbolTable.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress);
            FunctionNode function = (FunctionNode) _symbolTable.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress);
            
            
            
            
            id.AssignedExpression = function.ReturnValue;
            return function;
        }

        public object Visit(IdAssignNode node)
        {
            NumberDeclarationNode numDcl = (NumberDeclarationNode) _symbolTable.GetElementBySymbolTableAddress(node.AssignedValue.SymboltableAddress);
            MathNode mathNode = (MathNode) numDcl.AssignedExpression;

            NumberDeclarationNode numberDeclarationResult = new NumberDeclarationNode(node.Id, mathNode);
            _symbolTable.Add(node.Id.SymboltableAddress, numberDeclarationResult);
            
            return numberDeclarationResult;
        }

        public object Visit(MathAssignmentNode node)
        {
            NumberNode res = node.AssignedValue.Accept(_arithmeticPerformer);

            string lhsSymTabAddress = node.Id.SymboltableAddress;

            _symbolTable.Add(lhsSymTabAddress, res);
            node.AssignedValue = res;

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
            
            if (node.Expression is MathNode mathNode)
            {
                return mathNode.Accept(_arithmeticPerformer);
            }

            return node;
        }

        public object Visit(CurveCommandNode node)
        {
            node.Angle.Accept(this);
            return node;
        }

        public object Visit(DrawCommandNode node)
        {
            return node;
        }

        public object Visit(LineCommandNode node)
        {
            return node;
        }

        public object Visit(NumberIterationNode node)
        {
            return node.Iterations.Accept(_arithmeticPerformer);
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
            MathNode res = (MathNode) node.AssignedExpression;
            node.AssignedExpression = res.Accept(_arithmeticPerformer);
            _symbolTable.Add(node.Id.SymboltableAddress, node.AssignedExpression);
            
            return node.AssignedExpression;
        }

        public object Visit(PointDeclarationNode node)
        {
            return node;
        }

        public object Visit(BoolExprIdNode node)
        {
            return node;
        }

        /// <summary>
        /// TODO Enter Body
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(BodyNode node)
        {
            foreach (StatementNode nodeStatementNode in node.StatementNodes)
            {
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
            string functionCallAddress = node.FunctionName.SymboltableAddress;
            FunctionNode funcDeclaration = (FunctionNode) _symbolTable.GetElementBySymbolTableAddress(functionCallAddress);

            funcDeclaration.Accept(this);

            return funcDeclaration.ReturnValue.Accept(this);
        }
        public object Visit(ParameterNode node)
        {
            return node;
        }

        public object Visit(FunctionNode node)
        {
            return node.Body.Accept(this);
        }

        public object Visit(AdditionNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        public object Visit(DivisionNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }
        
        public object Visit(MathIdNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        public object Visit(MultiplicationNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        public object Visit(PowerNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        public object Visit(SubtractionNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        /// <summary>
        /// Det bliver måske også træls
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
       
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
            //slå op
          
            
            return node;
        }

        public object Visit(NumberNode node)
        {
            return node.Accept(_arithmeticPerformer);
        }

        public object Visit(TrueNode node)
        {
            return node;
        }

        public object Visit(SizePropertyNode node)
        {
            node.XMax = node.XMax.Accept(_arithmeticPerformer);
            node.YMax = node.XMax.Accept(_arithmeticPerformer);
            node.YMin = node.YMin.Accept(_arithmeticPerformer);
            node.XMin = node.XMin.Accept(_arithmeticPerformer);

            return node;
        }

        public object Visit(WorkAreaSettingNode node)
        {
            node.SizeProperty.Accept(this);
            return node;
        }

        public object Visit(AstNode node)
        {
            return node;
        }

        public object Visit(DrawNode node)
        {
            return node;
        }

        public object Visit(ProgramNode node)
        {
            foreach (FunctionNode nodeFunctionDcl in node.FunctionDcls)
            {
                nodeFunctionDcl.Accept(this);
            }

            return node;
        }

        public object Visit(ShapeNode node)
        {
            node.Body.Accept(this);
            return node;
        }

        public object Visit(CoordinateXyValueNode node)
        {
            return node;
        }


    }
}