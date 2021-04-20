using System;
using System.Collections.Generic;
using System.Linq;
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
    public class TypeCheckAssignmentsVisitor
    {
        private SymbolTable S = new SymbolTable();
        private Dictionary<string, string> _symbolTable;
        private List<SemanticError> errors = new List<SemanticError>();
        private Dictionary<string, string> symTable = new Dictionary<string, string>();
        private Stack<string> stack = new Stack<string>();
        private int repeatNumber = 0;
        private int level = 0;
        private Stack<string> TypeStack = new Stack<string>();

        public TypeCheckAssignmentsVisitor(Dictionary<string,string> symbolTable)
        {
            _symbolTable = symbolTable;
        }
//        
//         
//
//      
//         void PrintSymbolTable()
//         {
//             foreach (var item in symTable)
//             {
//                 Console.WriteLine(item.Key + ":" + item.Value);
//             }
//         }
//         
//         //Mark: Getters
//         public Dictionary<string, string> GetSymbolTable()
//         {
//             return symTable;
//         }
//
//         public List<SemanticError> getErrors()
//         {
//             return errors;
//         }
//         
//         //Mark:Add
//         void Add(string key, string value)
//         {
//             try
//             {
//                 symTable.Add(stack.Peek()+"_"+key, value);
//                 Console.WriteLine(stack.Peek()+"_"+key+":"+value);
//             }
//             catch (Exception e)
//             {
//                 errors.Add(new SemanticError(0, 0, stack.Peek()+"_"+key+":"+e.Message));
//                 Console.WriteLine(e.Message);
//             }
//         }
//
//         //Mark:Naming Functions
//         public string GetCurrentStackElement()
//         {
//             return stack.Peek();
//         }
//         
//         public void ProgramStartElementNaming()
//         {
//             stack.Push(""+level);
//         }
//         
//         public void ProgramFunctionListElementNaming(FunctionNode item)
//         {
//             stack.Push(stack.Peek() + "_" + item.Id.Value);
//                 item.Accept(this);
//                 stack.Pop();
//         }
//         public void ProgramShapeListElementNaming(ShapeNode item)
//         {
//             stack.Push(stack.Peek() + "_" + item.Id.Value);
//             item.Accept(this);
//             stack.Pop();
//         }
//         
//         
//         public void RepetitionElementNaming(BodyNode body)
//         {
//             stack.Push(stack.Peek()+"_rep"+repeatNumber);
//             repeatNumber++;
//             body.Accept(this);
//             stack.Pop();
//         }
//
//         public void BodyElementNaming(BodyNode body)
//         {
//             level++;
//             stack.Push(level+"_"+stack.Peek());
//             foreach (var item in body.StatementNodes)
//             {
//                 item.Accept(this);
//             }
//             level--;
//             stack.Pop();
//             
//         }
//
//         bool compareType()
//         {
//            return TypeStack.Pop()  == TypeStack.Pop();
//         }
//
//         
//         
//         public object Visit(ProgramNode node)
//         {
//             Console.WriteLine("\n***TypeChecking SymbolTable***");
//             ProgramStartElementNaming();
//                 foreach (var item in node.FunctionDcls)
//                     {
//                         
//                         ProgramFunctionListElementNaming(item);
//                         // Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//                     }
//                 
//                     foreach (var item in node.ShapeDcls)
//                     {
//                         ProgramShapeListElementNaming(item);
//                         // Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//                     }
//                     
//             Console.WriteLine($"Reached level {stack.Pop()} on stack\n ERRORS:");
//             foreach (var item in errors)
//             {
//                 Console.WriteLine(item);
//             }
//             return new object();
//         }
//
//         public object Visit(FunctionNode node)
//         {
//             
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             node.Body.Accept(this);
//             repeatNumber = 0;
//             return new object();
//         }
//         
//         public object Visit(ShapeNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             node.Body.Accept(this);
//             repeatNumber = 0;
//             return new object();
//         }
//         
//         public object Visit(NumberIterationNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             RepetitionElementNaming(node.Body);
//             return new object();
//         }
//
//         public object Visit(UntilFunctionCallNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             RepetitionElementNaming(node.Body);
//             return new object();
//         }
//
//         public object Visit(UntilNode node)
//         { 
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             RepetitionElementNaming(node.Body);
//             return new object();
//         }
//         
//         public object Visit(BodyNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             BodyElementNaming(node);
//             return new object();
//         }
//
//         
//         public object Visit(DeclarationNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             node.Accept(this);
//             return new object();
//         }
//         
//         public object Visit(BoolDeclarationNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             TypeStack.Push("bool");
//             node.AssignedExpression.Accept(this);
//             if (compareType())
//             {
//                 Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.AssignedExpression.Value);
//             }
//             else
//             {
//                 errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//             }
//             return new object();
//         }
//
//         
//
//         public object Visit(NumberDeclarationNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             TypeStack.Push("number");
//             node.AssignedExpression.Accept(this);
//             if (compareType())
//             {
//                 Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.AssignedExpression.Value);
//             }
//             else
//             {
//                 errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//             }
//             return new object();
//         }
//
//         public object Visit(PointDeclarationNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             TypeStack.Push("bool");
//             node.AssignedExpression.Accept(this);
//             if (compareType())
//             {
//                 Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.AssignedExpression.Value);
//             }
//             else
//             {
//                 errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//             }
//             return new object();
//         }
//
//         public object Visit(StatementNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             node.Accept(this);
//             return new object();
//         }
//         
//         
//        //Unused Visitors
//        public object Visit(AssignmentNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//            node.Accept(this);
//             return new object();
//         }
//
//         public object Visit(BoolAssignmentNode node)
//         {
//             TypeStack.Push("bool");
//             node.AssignedValue.Accept(this);
//             if (compareType())
//             {
//                 Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.AssignedValue.Value);
//             }
//             else
//             {
//                 errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//             }
//             
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(FunctionCallAssignNode node)
//         {                   
//             Console.WriteLine("Function call Assignment!!!!!!!");
//             Console.WriteLine(_symbolTable[GetCurrentStackElement() + "_" + node.Id.Value]);
//             
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             TypeStack.Push(_symbolTable[GetCurrentStackElement() + "_"+node.Id.Value]);
//             TypeStack.Push(_symbolTable[GetCurrentStackElement() + "_" + node.FunctionName]);
//            
//             if (compareType())
//             {
//                 Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.FunctionName.Value);
//             }
//             else
//             {
//                 errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//             }           return new object();
//         }
//
//         public object Visit(IdAssignNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//            TypeStack.Push(_symbolTable[GetCurrentStackElement() + "_"+node.Id.Value]);
//            TypeStack.Push(_symbolTable[GetCurrentStackElement() + "_" + node.AssignedValue]);
//            if (compareType())
//            {
//                Console.WriteLine("declaration type match!"+ node.Id.Value+"="+node.AssignedValue.Value);
//            }
//            else
//            {
//                errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//            }  
//            return new object();
//         }
//
//         public object Visit(MathAssignmentNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//            TypeStack.Push(_symbolTable[GetCurrentStackElement() + "_"+node.Id.Value]);
//            TypeStack.Push("number");
//            if (compareType())
//            {
//                Console.WriteLine("declaration type match!"+ node.Id.Value+"="+"?");
//            }
//            else
//            {
//                errors.Add(new SemanticError(0, 0, "declaration type mismatch"+node.ToString()));
//            } 
//            return new object();
//         }
//
//         public object Visit(PointAssignmentNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(PropertyAssignmentNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());             
//             return new object();
//         }
//
//         public object Visit(CommandNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());
//             node.Accept(this);
//             return new object();
//         }
//
//         public object Visit(CurveCommandNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType());  
//             return new object();
//         }
//
//         public object Visit(DrawCommandNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(IterationNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(LineCommandNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MovementCommandNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//         
//
//         public object Visit(AndComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(BoolComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(BoolNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(BoolTerminalNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(EqualsComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(GreaterThanComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(LessThanComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MathComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(NegationNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(OrComparerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(BoolFunctionCallNode node)
//         {
//             string name = "0_" + node.FunctionName.Value;
//             TypeStack.Push("bool");
//             // Console.WriteLine("*****"+ name.Substring(name.IndexOf("0")) + "_" + node.FunctionName.Value);
//             return new object();
//         }
//
//         public object Visit(FunctionCallNode node)
//         {
//             node.Accept(this);
//             return new object();
//         }
//
//         public object Visit(FunctionCallParameterNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(IFunctionCallNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MathFunctionCallNode node)
//         {
//             string name = "0_" + node.FunctionName.Value;
//             TypeStack.Push(_symbolTable[name]);
//             // Console.WriteLine("*****"+ name.Substring(name.IndexOf("0")) + "_" + node.FunctionName.Value);
//             // currentRetrievedType = _symbolTable[name];
//             return new object();
//         }
//         public object Visit(PointFunctionCallNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             string name = "0_" + node.FunctionName.Value;
//             TypeStack.Push(_symbolTable[name]);
//             
//             return new object();
//         }
//
//         public object Visit(ParameterNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         
// //Anvendes ikke
//         public object Visit(IFunctionNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(AdditionNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//            return new object();
//         }
//
//         public object Visit(DivisionNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(InfixMathNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MathIdNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MathNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MultiplicationNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(PowerNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(SubtractionNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(TerminalMathNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//
//
//         public object Visit(PointReferenceIdNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(PointReferenceNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ShapeEndPointNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ShapePointReference node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ShapePointRefNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ShapeStartPointNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(TuplePointNode node)
//         {
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(FalseNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(IdNode node)
//         {
//             TypeStack.Push(_symbolTable[GetCurrentStackElement()+"_"+node.Value]);
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(NumberNode node)
//         {
//             TypeStack.Push("number");
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(TrueNode node)
//         {
//             TypeStack.Push("bool");
//             Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(MachineSettingNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ModificationPropertyNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(SizePropertyNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(WorkAreaSettingNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(AstNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(DrawNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }
//
//         public object Visit(ExpressionNode node)
//         {
//            Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//            node.Accept(this); 
//            return new object();
//         }
//         
//         
//         
//         
//         
//         public object Visit(CoordinateXyValueNode node)
//         {
//           Console.WriteLine(GetCurrentStackElement()+" --"+node.GetType()); 
//             return new object();
//         }

    }

}

