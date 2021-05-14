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

namespace OG.AstVisiting.Visitors.ExpressionReduction
{
    public class ExpressionReducerVisitor : IVisitor, IErrorable
    {
        public readonly SymbolTable SymbolTable = new SymbolTable();
        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }

        private readonly MathReducerVisitor _mathReducer;
        private readonly PointReducerVisitor _pointReducer;


        public ExpressionReducerVisitor(Dictionary<string, AstNode> symTab, List<SemanticError> errs)
        {
            SemanticErrors = errs;
            SymbolTable.Elements = symTab;
            _mathReducer = new MathReducerVisitor(SymbolTable.Elements, errs);
            _pointReducer = new PointReducerVisitor(SymbolTable.Elements, errs,_mathReducer);
        }

        public object Visit(BoolAssignmentNode node)
        {
            return node;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public object Visit(FunctionCallAssignNode node)
        {
            switch (node.Id.CompileTimeType)
            {
                case "number":
                    MathFunctionCallNode mfc = new MathFunctionCallNode(node.FunctionName.Value, node.FunctionName, node.Parameters);
                    MathAssignmentNode n = new MathAssignmentNode(node.Id, mfc);
                    n.CompileTimeType = node.CompileTimeType;
                    n.Accept(_mathReducer);
                    return node;
                case "bool":
                    return node;

                case "point":
                    PointFunctionCallNode pfc = new PointFunctionCallNode(node.FunctionName.Value, node.FunctionName, node.Parameters);
                    PointAssignmentNode pa = new PointAssignmentNode(node.Id, pfc);
                    pa.CompileTimeType = node.CompileTimeType;
                    pa.Accept(_pointReducer);
                    return node;
                default:
                    SemanticErrors.Add(new SemanticError(node, "Function call type could not be determined.")
                        {IsFatal = true});
                    return node;
            }
        }

        public object Visit(IdAssignNode node)
        {
            switch (node.Id.CompileTimeType)
            {
                case"number":
                    MathIdNode mid = new MathIdNode(node.AssignedValue.Value, node.AssignedValue);
                    MathAssignmentNode n = new MathAssignmentNode(node.Id, mid);
                    n.CompileTimeType = node.CompileTimeType;
                    n.Accept(_mathReducer);
                    return node;
                case"bool":
                    return node;
                   
                case"point":
                    PointReferenceIdNode pid = new PointReferenceIdNode(node.AssignedValue.Value, node.AssignedValue);
                    PointAssignmentNode p = new PointAssignmentNode(node.Id, pid);
                    p.CompileTimeType = node.CompileTimeType;
                    p.Accept(_pointReducer);
                    return node;
                default:
                    SemanticErrors.Add(new SemanticError(node, "Function call type could not be determined."){IsFatal =  true});
                    return node;
            }

        }

        public object Visit(MathAssignmentNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(PointAssignmentNode node)
        {
            return node.Accept(_pointReducer);
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
            node.Angle = (NumberNode) node.Angle.Accept(_mathReducer);
            node.From = (TuplePointNode) node.From.Accept(_pointReducer);
            for (int i = 0; i < node.To.Count; i++)
            {
                node.To[i] =(TuplePointNode) node.To[i].Accept(_pointReducer);
            }

            return node;
        }

        public object Visit(DrawCommandNode node)
        {
            AstNode shape = SymbolTable.GetElementBySymbolTableAddress(node.Id.SymboltableAddress);
            shape.Accept(this);
            return node;
        }

        public object Visit(LineCommandNode node)
        {
            node.From = (TuplePointNode) node.From.Accept(_pointReducer);
            for (int i = 0; i < node.To.Count; i++)
            {
                node.To[i] = (TuplePointNode) node.To[i].Accept(this);
            }
            return node;
        }

        public object Visit(NumberIterationNode node)
        {
            node.Iterations.Accept(_mathReducer);
            node.Body.Accept(this);
            return node;
        }

        public object Visit(UntilFunctionCallNode node)
        {
            return node;
        }

        public object Visit(UntilNode node)
        {
            node.Body.Accept(this);
            return node;
        }

        public object Visit(BoolDeclarationNode node)
        {
            return node;
        }

        public object Visit(NumberDeclarationNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(PointDeclarationNode node)
        {
            
            return node.Accept(_pointReducer);
        }

        public object Visit(BoolExprIdNode node)
        {
            return node;
        }

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

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Visit(FunctionCallNode node)
        {
            switch (node.CompileTimeType)
            {
                case"number":
                    MathFunctionCallNode n = new MathFunctionCallNode(node.Value, node.FunctionName, node.Parameters);
                    n.CompileTimeType = node.CompileTimeType;
                    n.Accept(_mathReducer);
                    SymbolTable.Add(node.FunctionName.SymboltableAddress, n);
                    return node;
                case"bool":
                    /*
                    BoolFunctionCallNode b = new BoolFunctionCallNode(node.Value, node.FunctionName, node.Parameters);
                    b.CompileTimeType = node.CompileTimeType;
                    _symbolTable.Add(node.FunctionName.SymboltableAddress, b);
                    */
                    return node;
                case"point":

                    PointFunctionCallNode p = new PointFunctionCallNode(node.Value, node.FunctionName, node.Parameters);
                    p.CompileTimeType = node.CompileTimeType;
                    p.Accept(_pointReducer);
                    SymbolTable.Add(node.FunctionName.SymboltableAddress, p);
                    return node;
                    default:
                        SemanticErrors.Add(new SemanticError(node, "Function call type could not be determined."){IsFatal =  true});
                        return node;
            }
        }

        public object Visit(FunctionCallParameterNode node)
        {
            node.FunctionCallNode.Accept(this);
            return node;
        }

        public object Visit(MathFunctionCallNode node)
        {
            return node.Accept(_mathReducer);
        }

        ///TODO
        public object Visit(ParameterNode node)
        {
            return node;
        }

        public object Visit(FunctionNode node)
        {
            node.Body.Accept(this);
            node.ReturnValue.Accept(this);
            return node.ReturnValue;
        }

        public object Visit(AdditionNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(DivisionNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(MathIdNode node)
        {
            return node.Accept(_mathReducer);

        }

        public object Visit(MultiplicationNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(PowerNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(SubtractionNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(PointFunctionCallNode node)
        {
            return node.Accept(_pointReducer);
        }

        public object Visit(PointReferenceIdNode node)
        {
            return node.Accept(_pointReducer);
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
            return node.Accept(_pointReducer);
        }

        public object Visit(FalseNode node)
        {
            return node;
        }

        public object Visit(IdNode node)
        {
            DeclarationNode dcl =(DeclarationNode) SymbolTable.GetElementBySymbolTableAddress(node.SymboltableAddress);
            return dcl.AssignedExpression.Accept(this);
        }

        public object Visit(NumberNode node)
        {
            return node.Accept(_mathReducer);
        }

        public object Visit(TrueNode node)
        {
            return node;
        }

        public object Visit(SizePropertyNode node)
        {
            node.XMax.Accept(_mathReducer);
            node.YMax.Accept(_mathReducer);
            node.ZMax.Accept(_mathReducer);
            node.XMin.Accept(_mathReducer);
            node.YMin.Accept(_mathReducer);
            node.ZMin.Accept(_mathReducer);
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
            foreach (DrawCommandNode nodeDrawCommand in node.drawCommands)
            {
                nodeDrawCommand.Accept(this);
            }

            return node;
        }

        public object Visit(ProgramNode node)
        {
            foreach (MachineSettingNode nodeMachineSettingNode in node.MachineSettingNodes)
            {
                nodeMachineSettingNode.Accept(this);
            }

            node.drawNode.Accept(this);
            
            return node;
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