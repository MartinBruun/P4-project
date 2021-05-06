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
        private SymbolTable  S = new SymbolTable();


        public PrintsymboltableAddress(Dictionary<string,AstNode>  s)
        {
            S.Elements = s;
        }
        
        public object Visit(ProgramNode node)
        { Console.Write("\n\n---Printing symboltableAddress---");
            foreach (var setting in node.MachineSettingNodes)
            {
                setting.Accept(this);
            }
            
            node.drawNode.Accept(this);
            foreach (var funcDcl in node.FunctionDcls)
            {
                funcDcl.Accept(this);
            }

            foreach (var shapeDcl in node.ShapeDcls)
            {
                shapeDcl.Accept(this);
            }
            
            
                        Console.Write("no ID--:"+node);

                return new object();
        }

        

        public object Visit(DrawNode node)
        {
            Console.Write("draw {");
            foreach (var drawCommand in node.drawCommands)
            {
                drawCommand.Accept(this);
                Console.Write(";");
            }
            Console.Write("}\n");
            
            
            
                    Console.Write("no ID--:"+node);

            
            return new object();
            
        }
        
        public object Visit(DrawCommandNode node)
        {
            node.Id.Accept(this);
            if (node.From != null)
            {
                node.From.Accept(this);
            }

            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }

            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }
        
        public object Visit(FunctionNode node)
        {
            Console.Write("\nfunction ");
            Console.Write(node.ReturnType);
            node.Id.Accept(this);
            Console.Write("(");
            foreach (var param in node.Parameters)
            {
               param.Accept(this);
               if (node.Parameters.LastIndexOf(param) != node.Parameters.Count - 1)
               {
                   Console.Write(", ");
               }
              
            }
            Console.Write(") {\n");
            node.Body.Accept(this);
            Console.Write("}");
            
            if (node.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(BoolExprIdNode node)
        {
            Console.Write(node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();

        }

       

        public object Visit(BodyNode node)
        {
            foreach (var statement in node.StatementNodes)
            {
                statement.Accept(this);
            }
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            Console.Write("\nshape ");
            node.Id.Accept(this);
            Console.Write(" {\n");
            node.Body.Accept(this);
            Console.Write("} ");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }
        
        public object Visit(AssignmentNode node)
        {
            
            Console.Write("Assignment Node: " + node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }

            node.Id.Accept(this);
            return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedValue.Accept(this);
            Console.Write(";\n");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            node.Id.Accept(this);
            Console.Write(" = ");
            node.FunctionName.Accept(this);
            Console.Write("(");
            foreach (var param in node.Parameters)
            {
                param.Expression?.Accept(this);
            }
            Console.Write(")\n");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            Console.Write("ID ASSIGN NODE: ");
            Console.Write(node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedValue.Accept(this);
            Console.Write(";\n");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            Console.Write("PointAssignmentNode: ");
            Console.Write(node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            Console.Write("PropertyAssignmentNode: ");
            Console.Write(node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            Console.Write(node.ParameterType.ToString() + " ");
            node.IdNode.Accept(this);
            
            if (node?.IdNode != null)
            {
            
            Console.Write($"{node.IdNode.Value}:SId:",node.IdNode.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.IdNode.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(CommandNode node)
        {
            Console.Write("Command Node: ");
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            Console.Write(node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

       

        public object Visit(IterationNode node)
        {
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
            Console.Write("line.from");
            node.From.Accept((this));
            foreach (var toCommand in node.To)
            {
                Console.Write(".to");
                toCommand.Accept(this);
            }
            Console.Write(";\n");
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }
        
        public object Visit(PointReferenceNode node)
        {
            node.Accept(this);
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }
        
        public object Visit(TuplePointNode node)
        {
            Console.Write("(");
            node.XValue.Accept(this);
            Console.Write(", ");
            node.YValue.Accept(this);
            Console.Write(")");
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        

        public object Visit(CoordinateXyValueNode node)
        {
            Console.Write(node.Value);
           
                        Console.Write("no ID--:"+node);

            
            return new object();
     
        }

        public object Visit(MovementCommandNode node)
        {
            Console.Write(node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(NumberIterationNode node)
        {
            Console.Write("repeat(");
            node.Iterations.Accept(this);
            Console.Write(")\n");
            node.Body.Accept(this);
            Console.Write("\nrepeat.end\n");
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            Console.Write(node.ToString());
            
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(UntilNode node)
        {
            Console.Write("repeat.until(");
            node.Predicate.Accept(this);
            Console.Write(")\n");
            node.Body.Accept(this);
            Console.Write("repeat.end\n");
            
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(BoolDeclarationNode node)
        {
            Console.Write("bool ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(DeclarationNode node)
        {
            Console.Write("DeclarationNode: ");
            Console.Write(node.ToString());
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(NumberDeclarationNode node)
        {
            Console.Write("number ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.Write("point ");
            node.Id.Accept(this);
            Console.Write(" = ");
            node.AssignedExpression.Accept(this);
            Console.Write(";\n");
            if (node?.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        

        public object Visit(AndComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            Console.Write("BoolComparer: " + node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(BoolNode node)
        {
            Console.Write(node.Value);
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            Console.Write("Terminal node: " + node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(MathComparerNode node)
        {
            Console.Write(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(NegationNode node)
        {
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            node.FunctionName.Accept(this);
            Console.Write("(");
            if (node.Parameters.Count != 0)
            {
                foreach (var param in node.Parameters)
                {
                    param.Accept(this);
                }
            }
            Console.Write(")");
            if (node?.FunctionName != null)
            {
            
            Console.Write($"{node.FunctionName.Value}:SId:",node.FunctionName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
            node.FunctionName.Accept(this);
            Console.Write("(");
            if (node.Parameters.Count != 0)
            {
                foreach (var param in node.Parameters)
                {
                    param.Accept(this);
                }
            }
            Console.Write(");");
            if (node?.FunctionName != null)
            {
            
            Console.Write($"{node.FunctionName.Value}:SId:",node.FunctionName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            Console.Write("FUNCTION CALL NODE WITH PARAMS HER!!!!!!");
            if (node?.ParameterId != null)
            {
            
            Console.Write($"{node.ParameterId.Value}:SId:",node.ParameterId.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ParameterId.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            Console.Write("FUNCTION CALL NODE LINE 313!!!!!!!");
            if (node?.FunctionName != null)
            {
            
            Console.Write($"{node.FunctionName.Value}:SId:",node.FunctionName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            node.FunctionName.Accept(this);
            Console.Write("(");
            foreach (var param in node.Parameters)
            {
                param.Accept(this);
            }
            Console.Write(")");
            if (node?.FunctionName != null)
            {
            
            Console.Write($"{node.FunctionName.Value}:SId:",node.FunctionName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            if (node.Expression != null)
            {
                node.Expression.Accept(this);
            }
            else
            {
                node.ParameterId.Accept(this);
            }
            
            if (node?.ParameterId != null)
            {
            
            Console.Write($"{node.ParameterId.Value}:SId:",node.ParameterId.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ParameterId.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

       

        public object Visit(IFunctionNode node)
        {
            Console.Write("FUNCTION CALL NODE LINE 334!!!!!!!");
            Console.Write(node.ToString());
            if (node.Id != null)
            {
            
            Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(DivisionNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

       

        public object Visit(InfixMathNode node)
        {
            node.Accept(this);
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(MathIdNode node)
        {
            node.AssignedValueId.Accept(this);
            if (node?.AssignedValueId != null)
            {
            
            Console.Write($"{node.AssignedValueId.Value}:SId:",node.AssignedValueId.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.AssignedValueId.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        // public object Visit(MathNode node)
        // {
        //     Console.Write(node.ToString());
        //     if (node?.Id != null)
        //     {
        
        // Console.Write($"{node.Id.Value}:SId:",node.Id.SymboltableAddress);
        //        //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.Id.SymboltableAddress));
        //     }
        //     else
        //     {
        //                 Console.Write("no ID--:"+node);

        //     }
        //     return new object();
        // }

        public object Visit(MultiplicationNode node)
        {
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(PowerNode node)
        {
            Console.Write(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                    Console.Write("no ID--:"+node);

            return new object();
        }

        public object Visit(SubtractionNode node)
        {
            Console.Write(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
            Console.Write(node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
            Console.Write("PointFunctionCallNode: ");
            Console.Write(node.ToString());
            if (node?.FunctionName != null)
            {
            
            Console.Write($"{node.FunctionName.Value}:SId:",node.FunctionName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.FunctionName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            Console.Write("PointReferenceIdNode: ");
            Console.Write(node.ToString());
            if (node?.AssignedValue != null)
            {
            
            Console.Write($"{node.AssignedValue.Value}:SId:",node.AssignedValue.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.AssignedValue.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        

        public object Visit(ShapeEndPointNode node)
        {
            Console.Write(node.ToString());
            if (node?.ShapeName != null)
            {
            
            Console.Write($"{node.ShapeName.Value}:SId:",node.ShapeName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ShapeName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
            Console.Write(node.ToString());
            if (node?.ShapeName != null)
            {
            
            Console.Write($"{node.ShapeName.Value}:SId:",node.ShapeName.SymboltableAddress);
               //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ShapeName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
            Console.Write(node.ToString());
            if (node?.ShapeNameId != null)
            {
            
            Console.Write($"{node.ShapeNameId.Value}:SId:",node.ShapeNameId.SymboltableAddress);
            //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ShapeNameId.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
            Console.Write(node.ToString());
            if (node?.ShapeName != null)
            {
            
            Console.Write($"{node.ShapeName.Value}:SId:",node.ShapeName.SymboltableAddress);
            //Console.Write("---Retrieved the following : "+S.GetElementBySymbolTableAddress(node.ShapeName.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }

            return new object();
        }

        
        public object Visit(FalseNode node)
        {
            Console.Write(node.Value);
                    Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.Write("------Addr: "+ node.SymboltableAddress);
            if (node != null)
            {
            
            Console.Write($"{node.Value}:SId:",node.SymboltableAddress);
            //Console.Write("---Retrieved the following : \n"+S.GetElementBySymbolTableAddress(node.SymboltableAddress));
            }
            else
            {
                        Console.Write("no ID--:"+node);

            }
            return new object();
        }

        public object Visit(NumberNode node)
        {
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(TrueNode node)
        {
            Console.Write(node.Value);
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
            Console.Write(node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
            Console.Write(node.ToString());
           
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            Console.Write(node.ToString());
           
                          Console.Write("no ID--:"+node);

            
            return new object();
        }

        public object Visit(AstNode node)
        {
            Console.Write(node.ToString());
            
                        Console.Write("no ID--:"+node);

            
            return new object();
        }

        

        
}
}