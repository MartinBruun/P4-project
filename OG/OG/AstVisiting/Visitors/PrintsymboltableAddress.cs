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

namespace OG.AstVisiting.Visitors
{
    public class PrintsymboltableAddress:IVisitor
    {
        
        private List<SemanticError> errors = new List<SemanticError>();
        
        
         public PrintsymboltableAddress()
        {
          
        }

        public List<SemanticError> GetErrors()
        {
            return errors;
        }

        
        
        //Visitors
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        public object Visit(ProgramNode node)
        {Console.WriteLine("-->"+node);
        // S.enterScope("Global"); 
        Console.Write("\n\n---Printing symboltableAddress---\n");
            foreach (var item in node.MachineSettingNodes)
            {
                item.Accept(this);
            }
            
                node.drawNode.Accept(this);
            
                foreach (var item in node.FunctionDcls)
                    {
                        item.Accept(this);
                    }
                
                    foreach (var item in node.ShapeDcls)
                    {
                        item.Accept(this);
                    }
        //    S.exitScope("Global");
            
            
            foreach (var item in errors)
            {
            }
            return new object();
        }
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        
        //Todo: ENTER REPEATSCOPE
        public object Visit(NumberIterationNode node)
        {Console.WriteLine("-->"+node);

            // S.enterRepeatScope();
            node.Body.Accept(this);
            // S.exitRepeatScope();
            return new object();
        }

        //Todo: ENTER REPEATSCOPE
        public object Visit(UntilFunctionCallNode node)
        {Console.WriteLine("-->"+node);
            

            // S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            // S.exitRepeatScope();
            return new object();
        }

        //Todo: ENTER REPEATSCOPE
        public object Visit(UntilNode node)
        {Console.WriteLine("-->"+node); 
            

            // S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            // S.exitRepeatScope();
            return new object();
        }
        
        public object Visit(BodyNode node)
        {            Console.WriteLine("Visit(Body node)");
           

            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {Console.WriteLine("-->"+node);
            
            node.Accept(this);
            return new object();
        }
        public object Visit(FunctionNode node)
        {
            
            Console.WriteLine("Visit(FunctionNode node)");
            

            // S.enterScope(node.Id.Value);
            foreach (var item in node.Parameters)
            {
                item.Accept(this);
            }
            node.Body.Accept(this);
            // S.exitScope(node.Id.Value);
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {Console.WriteLine("-->"+node);
            node.Id.Accept(this);
            node.Body.Accept(this);
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            Console.WriteLine("Visit(BoolDeclaration node)");


            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);

            
            return new object();
        }

        
        public object Visit(NumberDeclarationNode node)
        {            Console.WriteLine("Visit(NumberDeclaration node)");
           
            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.WriteLine("Visit(PointDeclaration node)");
           
            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);
            
            return new object();
        }
        

        public object Visit(BoolAssignmentNode node)
        {Console.WriteLine("-->"+node);
            
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            
            return new object();
        }


        public object Visit(FunctionCallAssignNode node)
        {
            Console.WriteLine("Visit(FunctionCallAssign node)");

            
                node.Id.Accept(this);
                node.FunctionName.Accept(this);
                node.Id.PointingAt = node.FunctionName.PointingAt;
                
                var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
                for (int i = 0 ; i< node.Parameters.Count ; i++)
                {
                    node.Parameters[i].Accept(this);                    
                    node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                }
                return new object();
        }

        public object Visit(IdAssignNode node)
        {
            Console.WriteLine("Visit(IdAssign node)");

            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            node.Id.PointingAt = node.AssignedValue.PointingAt;
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {Console.WriteLine("-->"+node);
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);

            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {Console.WriteLine("-->"+node);
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            //TODO: fix this AssignedValue must be converted to IdNode
            // node.Id.PointingAt = node.AssignedValue.PointingAt;
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {            
            Console.WriteLine("Visit(PropertyAssignment node)");

            node.Id.Accept(this);
            
            node.assignedValue.Accept(this);

            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            Console.WriteLine("Visit(ParameterType node)");
            node.IdNode.Accept(this);
            return new object();
        }

        
        public object Visit(CurveCommandNode node)
        {Console.WriteLine("-->"+node);
            node.Angle.Accept(this);
            node.From.Accept(this);
            foreach (var item in node.To)
            {
                item.Accept(this);
            }

            return new object();
        }
        
        public object Visit(LineCommandNode node)
        {Console.WriteLine("-->"+node);
            node.From.Accept(this);
            foreach (var item in node.To)
            {
                item.Accept(this);
            }

            return new object();
        }

        public object Visit(DrawCommandNode node)
        {Console.WriteLine("-->"+node);
            //TODO: måske bør man lave symboltable opslaget her .
            node.Id.Accept(this);
            
            return new object();
        }
        
        public object Visit(AndComparerNode node)
        {Console.WriteLine("-->"+node);
            
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {Console.WriteLine("-->"+node);
           
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }
        
        public object Visit(BoolExprIdNode node)
        {Console.WriteLine("-->"+node);
            
            node.Id.Accept(this);
            return new object();

        }

        // TODO Måske crasher denne
        public object Visit(BoolNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {Console.WriteLine("-->"+node);
            
            node.Accept(this);
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {Console.WriteLine("-->"+node);
            
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(MathComparerNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(NegationNode node)
        {Console.WriteLine("-->"+node);
            //TODO: overvej om der skal gøres noget her
            return new object();
        }

        public object Visit(OrComparerNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {Console.WriteLine("-->"+node);
            node.FunctionName.Accept(this);
            return new object();
        }

        //Todo: RESET PARAMCOUNT 
        public object Visit(FunctionCallNode node)
        {Console.WriteLine("-->"+node);
            node.FunctionName.Accept(this);
            
            //Checking parameters
            var declaredNode= (FunctionNode) node.FunctionName.DeclaredValue;
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
            }
            //S.resetParameterCount();
            return new object();
        }
        //Todo: INCREASE PARAMCOUNT 
        public object Visit(FunctionCallParameterNode node)
        {Console.WriteLine("-->"+node);
            node.ParameterId.Accept(this);
           
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {Console.WriteLine("-->"+node);
            return new object();
        }

        //Todo: RESET PARAMCOUNT 
        public object Visit(MathFunctionCallNode node)
        {Console.WriteLine("-->"+node);
            node.FunctionName.Accept(this);
            var declaredNode= (FunctionNode)node.FunctionName.DeclaredValue;
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                declaredNode.Parameters[i].IdNode.Accept(this);
                   
            }
            return new object();
        }

        public object Visit(ParameterNode node)
        { Console.WriteLine("Visit(Parameter node)");
            

            if (node.Expression != null)
            {
                node.Expression.Accept(this);
                node.CompileTimeType = node.Expression.CompileTimeType;
            }
            else
            {
                node.ParameterId.Accept(this);
                node.CompileTimeType = node.ParameterId.CompileTimeType;
            }
            return new object();
        }

        
//Anvendes ikke
        public object Visit(IFunctionNode node)
        {Console.WriteLine("-->"+node);
            
            return new object();
        }

        public object Visit(AdditionNode node)
        {    Console.WriteLine("Visit(Addition node)");
           
            node.LHS.Accept(this);
            node.RHS.Accept(this);
           
           return new object();
        }

        public object Visit(DivisionNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitDivisionNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            else
            {
                node.CompileTimeType = "number";
            }
            return new object();
        }

        public object Visit(InfixMathNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);

            return new object();
        }

        public object Visit(MathIdNode node)
        {   Console.WriteLine("Visit(MathId node)");
            node.AssignedValueId.Accept(this);

            return "number";
        }

        public object Visit(MathNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            
            return new object();
        }

        public object Visit(PowerNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
           
            return new object();
        }

        public object Visit(SubtractionNode node)
        {Console.WriteLine("-->"+node);
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {Console.WriteLine("-->"+node);
            node.FunctionName.Accept(this);
            foreach (var item in node.Parameters)
            {
                item.Accept(this);
            }
            node.Body.Accept(this);
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {Console.WriteLine("-->"+node);
            node.AssignedValue.Accept(this);
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {Console.WriteLine("-->"+node);
           
            node.Accept(this);
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {Console.WriteLine("-->"+node);
           
            node.Accept(this);

            return new object();
        }

        public object Visit(ShapePointReference node)
        {Console.WriteLine("-->"+node);
           
            node.Accept(this);
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {Console.WriteLine("-->"+node);
            
            node.ShapeNameId.Accept(this);

            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {Console.WriteLine("-->"+node);
            
            node.ShapeName.Accept(this);
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
            Console.WriteLine("Visit(TuplePoint node)");
           
            node.XValue.Accept(this);
            node.YValue.Accept(this);
            if (node.XValue.CompileTimeType != node.YValue.CompileTimeType)
            {
                errors.Add(new SemanticError(node, $"{node.ToString()}: XYValue does not match type number: Typemismatch"));
            }

            return new object();
        }

        public object Visit(FalseNode node)
        {Console.WriteLine("-->"+node);
            
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.WriteLine("Visit(IdNode node)");
            
            Console.WriteLine($"{node.Value} : SymbTAddr: { node.SymboltableAddress}   ----> pointingAt:  {node.PointingAt}\n");

            return new object();
        }

        public object Visit(NumberNode node)
        {Console.WriteLine("-->"+node);
            
            node.CompileTimeType = "number";
            return new object();
        }

        public object Visit(TrueNode node)
        {Console.WriteLine("-->"+node);
            
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {Console.WriteLine("-->"+node);
            node.XMax.Accept(this);
            node.YMax.Accept(this);
            node.XMin.Accept(this);
            node.YMin.Accept(this);
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {Console.WriteLine("-->"+node);
            node.SizeProperty.Accept(this);
            return new object();
        }

        public object Visit(AstNode node)
        {Console.WriteLine("-->"+node);
            return new object();
        }
        object IVisitor.Visit(DrawNode node)
        {Console.WriteLine("-->"+node);
            foreach (var item in node.drawCommands)
            {
                item.Id.Accept(this);
            }
            return new object();
        }

        public object Visit(ExpressionNode node)
        {Console.WriteLine("-->"+node);
            node.Accept(this);
            return new object();
        }
        

        public object Visit(CoordinateXyValueNode node)
        {Console.WriteLine("-->"+node);
            node.CompileTimeType = "number";
            //TODO Jeg er i tvivl om jeg må / kan sætte denne til number???
            return new object();
        }
    }

}

