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
        private SymbolTable S = new SymbolTable();
        private List<SemanticError> errors = new List<SemanticError>();
        void PrintSymbolTable()
        {
            foreach (var item in S.Elements)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        
        //Mark: Getters
        public Dictionary<string, string> GetSymbolTable()
        {
            return S.Elements;
        }

        public List<SemanticError> getErrors()
        {
            return errors;
        }
        
        
        
        
        //Visitors
        public object Visit(ProgramNode node)
        {   S.enterScope("Global");
            Console.WriteLine("\n---Creating SymbolTable---");
                            
                // ProgramStartElementNaming();
                foreach (var item in node.FunctionDcls)
                    {
                        if (!S.Add(item.Id.Value, item.ReturnType))
                        {
                            errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
                        }
                        item.Accept(this);
                        // ProgramFunctionListElementNaming(item);
                    }
                
                    foreach (var item in node.ShapeDcls)
                    {
                        if (!S.Add(item.Id.Value, "shape"))
                        {
                            errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
                        }
                        // ProgramShapeListElementNaming(item);
                        item.Accept(this);

                    }
            S.exitScope("Global");
            Console.WriteLine("\n---SYMBOLTABLE:---");
            Console.WriteLine($"Reached S.GetCurrentScope() {S.GetCurrentScope()} on stack\n");
            PrintSymbolTable();
            Console.WriteLine("\n---Bad declarations---");
            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }
            return new object();
        }

        public object Visit(FunctionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);

            return new object();
        }
        
        public object Visit(NumberIterationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilNode node)
        { 
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            // Console.Write("***UntilNode"+stack.Peek()+"***");
            return new object();
        }
        
        public object Visit(BodyNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());

            if (!S.Add(node.Id.Value, node.DeclaredType.ToString()))
            {
                errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
            }
            node.Accept(this);
            Console.Write("ADeclarationN\n");
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());
            Console.WriteLine(node.ToString());

            if (!S.Add(node.Id.Value, "bool"))
            {
                errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
            }
            
            return new object();
        }

        

        public object Visit(NumberDeclarationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());

            if (!S.Add(node.Id.Value, "number"))
            {
                errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
            }
            Console.Write("NumberN\n"); 
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());

            if (!S.Add(node.Id.Value, "point"))
            {
                errors.Add(new SemanticError(node,"Already exists in SymbolTable"));
            }
           

            return new object();
        }

        public object Visit(StatementNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());

            node.Accept(this);
            Console.Write("StatementN\n");
            return new object();
        }
        
        
       //Unused Visitors
       public object Visit(AssignmentNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
           return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(CommandNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());

            node.Accept(this);
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            return new object();
        }

        public object Visit(DrawCommandNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IterationNode node)
        { 
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

           node.Body.Accept(this);
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }
        

        public object Visit(AndComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(BoolNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(NegationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            // Console.Write(node.ParamType);
            //  node.ParameterId.Accept(this);
            //  node.Expression.Accept(this);
            // Console.Write(","); 
            return new object();
        }

        
//Anvendes ikke
        public object Visit(IFunctionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

           // node.LHS.Accept(this);
           // Console.Write("+");
           // node.RHS.Accept(this);
           return new object();
        }

        public object Visit(DivisionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathIdNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            // Console.Write(node.Value); 
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PowerNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 

            // Console.Write("(");
            // node.XValue.Accept(this);
            // node.YValue.Accept(this);
            // Console.WriteLine(")");
            return new object();
        }

        public object Visit(FalseNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IdNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(NumberNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(TrueNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(AstNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        object IVisitor.Visit(DrawNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }

        

        

        public object Visit(CoordinateXyValueNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString()); 
            return new object();
        }
    }

}