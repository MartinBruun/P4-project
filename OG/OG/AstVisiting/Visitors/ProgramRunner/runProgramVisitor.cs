using System.Collections.Generic;
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
using OG.CodeGeneration;

namespace OG.AstVisiting.Visitors.ProgramRunner
{
    public class runProgramVisitor:IVisitor

    {
        
        private Stack<AstNode> executionList = new Stack<AstNode>();
        ASTNodeCloner cloner = new ASTNodeCloner();
        
        
        public object Visit(ProgramNode node)
        {
            node.drawNode.Accept(this);
            return node;
        }
        
        public object Visit(DrawNode node)
        {
            foreach (var drawCmd in node.drawCommands)
            {
                drawCmd.Accept(this);
            }

            return node;
        }
        
        public object Visit(DrawCommandNode node)
        {
            node.Id.DeclaredValue.Accept(this);
            return node;
        }
        
        
        public object Visit(ShapeNode node)
        {
            node.Body.Accept(this);
            return node;
        }
        
        
        public object Visit(BodyNode node)
        {
            foreach (var statement in node.StatementNodes)
            {
                statement.Accept(this);
            }

            return node;
        }


        #region Assignments
        
        public object Visit(FunctionCallAssignNode node)
        {
            var tempNode = (FunctionCallAssignNode)node.Accept(cloner);
            tempNode.FunctionName.Declaration.Accept(this);
            executionList.Push((FunctionCallAssignNode)node.Accept(cloner));
            node.Id.DeclaredValue = (AstNode)node.FunctionName.DeclaredValue.Accept(this);
            
            return node;
        }
        
        public object Visit(IdAssignNode node)
        {
            var tempNode = (IdAssignNode)node.Accept(cloner);
            tempNode.Id.Declaration.Accept(this);
            tempNode.AssignedValue.Declaration.Accept(this);
            executionList.Push(tempNode);
            
            return node;
        }

        public object Visit(MathAssignmentNode node)
        {
            var tempNode = (MathAssignmentNode)node.Accept(cloner);
            tempNode.Id.Declaration.Accept(this);
            tempNode.AssignedValue.Accept(this);
            executionList.Push(tempNode);
            
            return node;

        }

        public object Visit(PointAssignmentNode node)
        {
            var tempNode = (PointAssignmentNode)node.Accept(cloner);
            tempNode.Id.Declaration.Accept(this);
            tempNode.AssignedValue.Accept(this);
            executionList.Push(tempNode);
            
            return node;
        }

        public object Visit(PropertyAssignmentNode node)
        {
            var tempNode = (PropertyAssignmentNode)node.Accept(cloner);
            tempNode.Id.Declaration.Accept(this);
            tempNode.assignedValue.Accept(this);
            executionList.Push(tempNode);
            
            return node;
            
        }
        
        public object Visit(BoolAssignmentNode node)
        {
            var tempNode = (BoolAssignmentNode)node.Accept(cloner);
            tempNode.Id.Declaration.Accept(this);
            tempNode.AssignedValue.Accept(this);
            executionList.Push(tempNode);
            
            return node;
        }
        
        #endregion

        
        #region Declaations
        
        public object Visit(FunctionNode node)
        {
            var tempnode = (FunctionNode) node.Accept(cloner);
            executionList.Push(tempnode);
            return node;
        }
        public object Visit(BoolDeclarationNode node)
        {
            var tempnode = (BoolDeclarationNode) node.Accept(cloner);
            executionList.Push(tempnode);
            return node;
            
        }

        public object Visit(NumberDeclarationNode node)
        {
            var tempnode = (NumberDeclarationNode) node.Accept(cloner);
            executionList.Push(tempnode);
            return node;
            
        }

        public object Visit(PointDeclarationNode node)
        {
            var tempnode = (PointDeclarationNode) node.Accept(cloner);
            executionList.Push(tempnode);
            return node;
        }
        
        #endregion
        
        
        #region FunctionCalls
        public object Visit(BoolFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }
        
        
        #endregion
        
        

        

       

        public object Visit(ParameterTypeNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(CurveCommandNode node)
        {
            executionList.Push((CurveCommandNode)node.Accept(cloner));
            return node;
            
        }

        

        public object Visit(LineCommandNode node)
        {
            executionList.Push((LineCommandNode)node.Accept(cloner));
            return node;
        }

       
        public object Visit(NumberIterationNode node)
        {
            executionList.Push((NumberIterationNode)node.Accept(cloner));
            return node;
        }
        
        

        public object Visit(UntilFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(UntilNode node)
        {
            throw new System.NotImplementedException();
        }

        

        public object Visit(BoolExprIdNode node)
        {
            throw new System.NotImplementedException();
        }

       

        public object Visit(AndComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(BoolNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(EqualsComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(LessThanComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NegationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(OrComparerNode node)
        {
            throw new System.NotImplementedException();
        }

        
        
        
        
        
        
        

        public object Visit(ParameterNode node)
        {
            throw new System.NotImplementedException();
        }

       

        public object Visit(AdditionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(DivisionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MathIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(MultiplicationNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PowerNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SubtractionNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointFunctionCallNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(PointReferenceIdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeEndPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapePointRefNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(ShapeStartPointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(TuplePointNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(FalseNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(IdNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(NumberNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(TrueNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(SizePropertyNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            throw new System.NotImplementedException();
        }

        public object Visit(AstNode node)
        {
            throw new System.NotImplementedException();
        }

       

        

        public object Visit(CoordinateXyValueNode node)
        {
            throw new System.NotImplementedException();
        }
    }
}