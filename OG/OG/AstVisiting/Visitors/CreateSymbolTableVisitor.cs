using System;
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
        private Dictionary<string, string> symTable = new Dictionary<string, string>();
        Stack<string> stack = new Stack<string>();
        private int level = 0;

        public Dictionary<string, string> GetSymbolTable()
        {
            return symTable;
        }
        void PrintSymbolTable()
        {
            foreach (var item in symTable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }

        // string Name(string key)
        // {
        //     string _name;
        //     try
        //     {
        //         if (level != 0)
        //         {
        //             return stack.Peek()+"_"+key;
        //         }
        //         return _name=level+"_"+stack.Peek()+"_"+key;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e.Message);
        //     }
        //
        //     return "";
        // }
        void Add(string key, string value)
        {
            try
            {
                // if (level != 0)
                // {
                //     symTable.Add(level+"_"+stack.Peek()+"_"+key, value);
                // }
                symTable.Add(stack.Peek()+"_"+key, value);
                Console.WriteLine(stack.Peek()+"_"+key+":"+value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        
        //Visitors
        object IVisitor.Visit(ProgramNode node)
        {
            Console.WriteLine("\n---Creating SymbolTable---");
            {
                stack.Push(""+level);
                foreach (var item in node.FunctionDcls)
                    {
                        
                        Add(item.Id.Value, item.ReturnType);
                        stack.Push(stack.Peek() + "_" + item.Id.Value);
                        item.Accept(this);
                        stack.Pop();

                    }
                
                    foreach (var item in node.ShapeDcls)
                    {
                        Add(item.Id.Value, "shape");
                        stack.Push(stack.Peek() + "_" + item.Id.Value);
                        item.Accept(this);
                        stack.Pop();

                    }
            }
            Console.WriteLine("\n---SYMBOLTABLE:---");
            Console.WriteLine($"Reached level {stack.Pop()} on stack\n");
            PrintSymbolTable();
            return new object();
        }
        
        public object Visit(BodyNode node)
        {
            level++;
            stack.Push(level+"_"+stack.Peek());
            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }

            level--;
            stack.Pop();
            return new object();
        }

        
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
            // Console.Write("curve.angle(");
            // node.Angle.Accept(this);
            // Console.Write(").from");
            // node.From.Accept(this);
            // foreach (var to in node.To)
            // {
                // Console.Write(".to");
                // to.Accept(this);
            // }
            // Console.WriteLine(); 
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
            // Console.Write("line.from");
            // node.From.Accept(this);
            // foreach (var to in node.To)
            // {
            //     Console.Write(".to");
            //     to.Accept(this);
            // }
            // Console.WriteLine(); 
            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }

        public object Visit(NumberIterationNode node)
        {
            node.Accept(this);
            Console.Write("NumberIterN\n"); 

            // Console.Write("***NumberIteration***");
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            node.Body.Accept(this);
            Console.Write("UntilFuncN\n"); 

            // Console.Write("***UntilFunction***");
            return new object();
        }

        public object Visit(UntilNode node)
        {
            node.Body.Accept(this);
            Console.Write("UntilN\n"); 

            // Console.Write("***UntilNode"+stack.Peek()+"***");
            return new object();
        }

        public object Visit(BoolDeclarationNode node)
        {
            Add(node.Id.Value, "bool");
            Console.Write("BoolN\n"); 

            // node.AssignedExpression.Accept(this);
            return new object();
        }

        public object Visit(DeclarationNode node)
        {
            
            node.Accept(this);
            Console.Write("ADeclarationN\n"); 

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
            // node.FunctionName.Accept(this);
            // foreach (var p in node.Parameters)
            // {
            //     p.Accept(this);
            // }
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

        public object Visit(FunctionNode node)
        {
            node.Id.Accept(this);
            node.Body.Accept(this);
            Console.Write("FunctionN\n"); 

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

        

        public object Visit(ShapeNode node)
        {
            node.Body.Accept(this);
            return new object();
        }

        public object Visit(CoordinateXyValueNode node)
        {
           // Console.Write($"Scope level{level}"); 
            return new object();
        }
    }

}