// using System;
// using System.Collections.Generic;
// using OG.ASTBuilding.Terminals;
// using OG.ASTBuilding.TreeNodes;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
// using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
// using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
// using OG.ASTBuilding.TreeNodes.FunctionCalls;
// using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
// using OG.ASTBuilding.TreeNodes.PointReferences;
// using OG.ASTBuilding.TreeNodes.TerminalNodes;
// using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
//
// namespace OG.AstVisiting.Visitors
// {
//     public class OG_ASTPretyPrinter:IAllBaseNodeVisitorBundle
//     {
//         //Gem resultatet af visitmetoderne i små eller store AST trees
//         private ProgramNode main;
//          public void Visit(MathFunctionCallNode node)
//          {
//              Console.Write("function number");
//             Visit(node.FunctionName);
//             Console.Write("(");
//
//             foreach (ParameterNode parameterNode in node.Parameters)
//             {
//                 Visit(parameterNode);
//             }
//             Console.Write(")");
//
//         }
//
//         public void Visit(BoolFunctionCallNode node)
//         {
//             Console.Write("function bool");
//             node.FunctionName.Accept(this);
//             Console.Write("(");
//             foreach (ParameterNode parameterNode in node.Parameters)
//             {
//                 parameterNode.Accept(this);
//             }
//             Console.Write(")");  
//         }
//
//         public void Visit(PointFunctionCallNode node)
//         {
//             Console.Write("function point");
//             node.FunctionName.Accept(this);
//             Console.Write("(");
//             foreach (ParameterNode parameterNode in node.Parameters)
//             {
//                 parameterNode.Accept(this);
//             }
//             Console.Write(")");  
//
//         }
//
//         //TODO: HVad er dette????
//         public void Visit(FunctionCallAssignNode node)
//         {
//             Console.Write("function assign???");
//             node.FunctionName.Accept(this);
//             Console.Write("(");
//             foreach (ParameterNode parameterNode in node.Parameters)
//             {
//                 parameterNode.Accept(this);
//             }
//             Console.Write(")");  
//
//         }
//
//         public void Visit(BodyNode node)
//         {
//             throw new NotImplementedException();
//         }
//
//
//         public void Visit(UntilNode node)
//         {
//             Console.Write(node.Predicate.Value);
//             node.Body.Accept(this);
//         }
//
//         public void Visit(FunctionCallParameterNode node)
//         {
//             node.ParameterId.Accept(this);
//             
//         }
//
//         public void Visit(ParameterNode node)
//         {
//             Console.Write(node.ParamType + ":");
//             node.ParameterId.Accept(this);
//         }
//
//         public void Visit(FunctionCallNode node)
//         {
//             node.FunctionName.Accept(this);
//             Console.Write("(");
//             foreach (var p in node.Parameters)
//             {
//                     p.Accept(this);
//             }
//             Console.Write(")");
//
//         }
//
//         public void Visit(BoolDeclarationNode node)
//         {
//             Console.Write("bool ");
//             node.Id.Accept(this);
//             Console.Write("="+node.AssignedExpression.Value);
//
//         }
//
//         public void Visit(NumberDeclarationNode node)
//         {
//             Console.Write("number ");
//             node.Id.Accept(this);
//             Console.Write("="+node.AssignedExpression.Value);
//         }
//
//         public void Visit(PointDeclarationNode node)
//         {
//             Console.Write("point ");                        
//             node.Id.Accept(this);
//             Console.Write("="+node.AssignedExpression.Value);
//         }
//
//         public void Visit(LineCommandNode node)
//         {
//             Console.Write("line.");
//             node.From.Accept(this);
//             foreach (var t in node.To)
//             {
//                 t.Accept(this);
//             }
//             
//         }
//
//         public void Visit(CurveCommandNode node)
//         {
//             Console.Write($"line.angle({node.Angle.Value}).");
//             node.From.Accept(this);                        
//             foreach (var t in node.To)                     
//             {                                              
//                 t.Accept(this);                            
//             }                                              
//         }
//
//         void IUntilFunctionCallVisitor.Visit(UntilFunctionCallNode node)
//         {
//             Console.Write("repeat.until("); 
//             node.Predicate.Accept(this);
//             Console.Write(")");
//             node.Body.Accept(this);
//         }
//
//         public void Visit(NumberIterationNode node)
//         {
//             Console.Write("repeat("+node.Iterations.Value + ")");
//             node.Body.Accept(this);
//         }
//
//         void IIterationNodeVisitorBundleBundle.Visit(BodyNode node)
//         {
//             throw new NotImplementedException();
//         }
//
//         public void Visit(IdNode node)
//         {
//             Console.Write(node.Value);
//         }
//
//         public void Visit(AdditionNode node)
//         {
//             Console.Write(node.LHS +"+"+node.RHS) ;
//             
//         }
//
//         public void Visit(SubtractionNode node)
//         {
//             Console.Write(node.LHS +"-"+node.RHS) ;        }
//
//         public void Visit(MultiplicationNode node)
//         {
//             Console.Write(node.LHS +"*"+node.RHS) ;
//         }
//
//         public void Visit(DivisionNode node)
//         {
//             Console.Write(node.LHS +"/"+node.RHS) ;
//         }
//
//         public void Visit(NumberNode node)
//         {
//             Console.Write(node.NumberValue);
//         }
//
//         public void Visit(MathIdNode node)
//         {
//             node.AssignedValueId.Accept(this);
//         }
//
//         public void Visit(PowerNode node)
//         {
//             Console.Write(node.LHS +"^"+node.RHS) ;
//         }
//
//         public void Visit(LessThanComparerNode node)
//         {
//             Console.Write(node.LHS +"<"+node.RHS) ;
//         }
//
//         public void Visit(GreaterThanComparerNode node)
//         {
//             Console.Write(node.LHS +">"+node.RHS) ;
//         }
//
//         public void Visit(EqualsComparerNode node)
//         {
//             Console.Write(node.LHS +"=="+node.RHS) ;
//         }
//
//         public void Visit(NegationNode node)
//         {
//             Console.Write(node.Value);
//         }
//
//         public void Visit(OrComparerNode node)
//         {
//             Console.Write(node.LHS.Value + "||" + node.RHS.Value);
//         }
//
//         public void Visit(AndComparerNode node)
//         {
//             Console.Write(node.LHS.Value + "&&" + node.RHS.Value);
//         }
//
//         public void Visit(FalseNode node)
//         {
//             Console.Write(" false ");
//         }
//
//         public void Visit(TrueNode node)
//         {
//             Console.Write(" true ");
//         }
//
//         public void Visit(PointReferenceIdNode node)
//         {
//             node.AssignedValue.Accept(this);
//         }
//
//         public void Visit(IPointReferenceNode node)
//         {
//             throw new NotImplementedException();
//         }
//
//         public void Visit(ShapeEndPointNode node)
//         {
//             node.ShapeName.Accept(this);
//             Console.Write( node.Value );
//            
//         }
//
//         public void Visit(ShapeStartPointNode node)
//         {
//             node.ShapeName.Accept(this);   
//             Console.Write( node.Value );           
//         }
//
//         public void Visit(TuplePointNode node)
//         {
//             Console.Write("(" + node.XValue + "," + node.YValue + ")");
//         }
//
//         //Never used
//         public void Visit(DrawCommandNode node)
//         {
//             node.Id.Accept(this);
//             node.From.Accept(this);
//         }
//
//         public void Visit(DrawNode node)
//         {
//             Console.Write("draw{");
//             foreach (var cmd in node.drawCommands)
//             {
//                 if (cmd != null ){
//                     if (cmd.From != null)
//                     {
//                         cmd.Id.Accept(this);
//                         cmd.From.Accept(this);
//                         Console.Write(";");
//
//                     }
//                     else
//                     {
//                         cmd.Id.Accept(this);
//                         Console.Write(";");
//                         
//                     }
//                 }
//             }
//             Console.Write("}\n");
//         }
//
//         public void Visit(CoordinateXyValueNode node)
//         {
//             Console.Write(node.Value);
//         }
//
//         public void Visit(ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode node)
//         {
//             node.Id.Accept(this);
//             Console.Write(node.Property);
//         }
//
//         public void Visit(PropertyAssignmentNode node)
//         {
//             node.Id.Accept(this);
//             node.coordinateValueNode.Accept(this);
//             Console.Write(node.assignedValue.Value);
//         }
//
//         public void Visit(MathAssignmentNode node)
//         {
//             node.Id.Accept(this);
//         }
//
//         public void Visit(BoolAssignmentNode node)
//         {
//             node.Id.Accept(this);
//             Console.Write("="+node.AssignedValue.Value);
//         }
//
//         public void Visit(PointAssignmentNode node)
//         {
//             node.Id.Accept(this);                        
//             Console.Write("="+node.AssignedValue.Value); 
//         }
//
//         // public void Visit(BodyNode node)
//         // {
//         //     Console.Write("{\n");
//         //     foreach (var stmt in node.StatementNodes)
//         //     {
//         //         Console.Write("***FIX THIS STMTS***");
//         //         stmt.Accept(this);
//         //         Console.Write("***F***\n");
//         //     }
//         //
//         //     Console.Write("\n}\n");
//         //
//         // }
//
//         
//
//         public void Visit(ShapeNode node)
//         {
//             node.Id.Accept(this);
//             node.Body.Accept(this);
//         }
//
//         public void Visit(IFunctionNode node)
//         {
//             node.Id.Accept(this);
//             node.Body.Accept(this);
//         }
//
//         public void Visit(FunctionNode node)
//         {
//             Console.Write("function "+ node.ReturnType + " ");
//             node.Id.Accept(this);
//             Console.Write("( )");
//             node.Body.Accept(this);
//         }
//
//         public void Visit(SizePropertyNode node)
//         {
//             Console.Write("Xmin:"+node.XMin.Value + "Xmax:"+node.XMax.Value + "Ymin:"+node.YMin.Value + "Ymax:"+node.YMax.Value);
//         }
//
//         public void Visit(WorkAreaSettingNode node)
//         {
//             node.SizeProperty.Accept(this);
//         }
//
//         public void Visit(IMachineSettingVisitable node)
//         {
//             Console.Write("\nFIXME***** Machine.WorkArea.size = \n");
//             ((WorkAreaSettingNode) node).Accept(this);
//             Console.Write("\nFIXME*****\n");
//
//             // node.Accept(this);
//         }
//
//         public void Visit(ProgramNode node)
//         {
//             Console.Write("THE PROGRAM:\n\n");
//             ProgramNode p;
//             List<MachineSettingNode> m;
//             foreach (var setting in node.MachineSettingNodes)
//             {
//                 Console.Write("Found Setting....UGLY HACK in Visit(IMachineSettingVisitable node) but it works for now  is recursive\n");
//                 setting.Accept(this);
//             }
//
//             DrawNode d;
//             node.drawNode.Accept(this);
//             
//             foreach (var item in node.FunctionDcls)
//             {
//                 item.Accept(this);
//             }
//
//             foreach (ShapeNode shape in node.ShapeDcls)
//             {
//                 shape.Accept(this);
//             }
//            
//         }
//
//         
//     }
// }