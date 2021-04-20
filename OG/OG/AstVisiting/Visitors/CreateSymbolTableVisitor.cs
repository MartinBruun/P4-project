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
    /// <summary>
    /// Items are added to symboltable when visiting
    /// a functionDecl in Functiondeclarations
    /// a shapeDecl in ShapeDeclarations 
    /// any Declaration inside a Body 
    /// 
    /// </summary>
    public class CreateSymbolTableVisitor : IVisitor
    {
        
        private List<SemanticError> errors = new List<SemanticError>();
        private Dictionary<string, string> symTable = new Dictionary<string, string>();
        private Stack<string> stack = new Stack<string>();
        private int repeatNumber = 0;
        private int level = 0;

     
        void PrintSymbolTable()
        {
            foreach (var item in symTable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        
        //Mark: Getters
        public Dictionary<string, string> GetSymbolTable()
        {
            return symTable;
        }

        public List<SemanticError> getErrors()
        {
            return errors;
        }
        
        //Mark:Add
        void Add(string key, string value)
        {
            try
            {
                symTable.Add(stack.Peek()+"_"+key, value);
                Console.WriteLine(stack.Peek()+"_"+key+":"+value);
            }
            catch (Exception e)
            {
                errors.Add(new SemanticError(0, 0, stack.Peek()+"_"+key+":"+e.Message));
                Console.WriteLine(e.Message);
            }
        }

        //Mark:Naming Functions
        public string GetCurrentStackElement()
        {
            return stack.Peek();
        }
        
        public void ProgramStartElementNaming()
        {
            stack.Push(""+level);
        }
        
        public void ProgramFunctionListElementNaming(FunctionNode item)
        {
            stack.Push(stack.Peek() + "_" + item.Id.Value);
                item.Accept(this);
                stack.Pop();
        }
        public void ProgramShapeListElementNaming(ShapeNode item)
        {
            stack.Push(stack.Peek() + "_" + item.Id.Value);
            item.Accept(this);
            stack.Pop();
        }
        
        
        public void RepetitionElementNaming(BodyNode body)
        {
            stack.Push(stack.Peek()+"_rep"+repeatNumber);
            repeatNumber++;
            body.Accept(this);
            stack.Pop();
        }

        public void BodyElementNaming(BodyNode body)
        {
            level++;
            stack.Push(level+"_"+stack.Peek());
            foreach (var item in body.StatementNodes)
            {
                item.Accept(this);
            }
            level--;
            stack.Pop();
            
        }
        
        
        //Visitors
        public object Visit(ProgramNode node)
        {
            Console.WriteLine("\n---Creating SymbolTable---");
                            
                ProgramStartElementNaming();
                foreach (var item in node.FunctionDcls)
                    {
                        Add(item.Id.Value, item.ReturnType);
                        ProgramFunctionListElementNaming(item);
                    }
                
                    foreach (var item in node.ShapeDcls)
                    {
                        Add(item.Id.Value, "shape");
                        ProgramShapeListElementNaming(item);
                    }
            
            Console.WriteLine("\n---SYMBOLTABLE:---");
            Console.WriteLine($"Reached level {stack.Pop()} on stack\n");
            PrintSymbolTable();
            return new object();
        }

        public object Visit(FunctionNode node)
        {
            // node.Id.Accept(this);
            node.Body.Accept(this);
            Console.Write("FunctionN\n"); 
            repeatNumber = 0;
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            node.Body.Accept(this);
            repeatNumber = 0;
            return new object();
        }
        
        public object Visit(NumberIterationNode node)
        {
            RepetitionElementNaming(node.Body);
            Console.Write("NumberIterN\n");
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            RepetitionElementNaming(node.Body);
            Console.Write("UntilFuncN\n");
            return new object();
        }

        public object Visit(UntilNode node)
        { 
            RepetitionElementNaming(node.Body);
            Console.Write("UntilN\n"); 

            // Console.Write("***UntilNode"+stack.Peek()+"***");
            return new object();
        }
        
        public object Visit(BodyNode node)
        {
            BodyElementNaming(node);
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {
            node.Accept(this);
            Console.Write("ADeclarationN\n");
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            Add(node.Id.Value, "bool");
            Console.Write("BoolN\n");
            return new object();
        }

        

        public object Visit(NumberDeclarationNode node)
        {
            Add(node.Id.Value, "number");
            // node.AssignedExpression.Accept(this);
            Console.Write("NumberN\n"); 
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Add(node.Id.Value, "point");
            // node.AssignedExpression.Accept(this);
            // Console.Write("p\n"); 

            return new object();
        }

        public object Visit(StatementNode node)
        {
            node.Accept(this);
            Console.Write("StatementN\n");
            return new object();
        }
        
        
       //Unused Visitors
       public object Visit(AssignmentNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            // Console.Write($" level{level}_! "); 
            return new object();
        }

        public object Visit(CommandNode node)
        {
            node.Accept(this);
            // Console.Write($"{level}_!"); 
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            
            return new object();
        }

        public object Visit(DrawCommandNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(IterationNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }
        

        public object Visit(AndComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(BoolNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(NegationNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
            
            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            // Console.Write(node.ParamType);
            //  node.ParameterId.Accept(this);
            //  node.Expression.Accept(this);
            // Console.Write(","); 
            return new object();
        }

        
//Anvendes ikke
        public object Visit(IFunctionNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(AdditionNode node)
        {
           // node.LHS.Accept(this);
           // Console.Write("+");
           // node.RHS.Accept(this);
           return new object();
        }

        public object Visit(DivisionNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MathIdNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MathNode node)
        {
            // Console.Write(node.Value); 
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PowerNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
            // Console.Write("(");
            // node.XValue.Accept(this);
            // node.YValue.Accept(this);
            // Console.WriteLine(")");
            return new object();
        }

        public object Visit(FalseNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(IdNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(NumberNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(TrueNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(AstNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        object IVisitor.Visit(DrawNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        

        

        public object Visit(CoordinateXyValueNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }
    }

}