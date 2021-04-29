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
    public class TypeCheckAssignmentsVisitor:IVisitor
    {
        private SymbolTable S = new SymbolTable();
        private List<SemanticError> errors = new List<SemanticError>();

        

        public TypeCheckAssignmentsVisitor(Dictionary<string,AstNode> symbolTable)
        {
            S.Elements = symbolTable;
        }

        
        void PrintSymbolTable()
        {
            foreach (var item in S.Elements)
            {
                // // Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        
        //Mark: Getters
        public Dictionary<string, AstNode> GetSymbolTable()
        {
            return S.Elements;
        }

        public List<SemanticError> GetErrors()
        {
            return errors;
        }
        
        
        
        
        //Visitors
        public object Visit(ProgramNode node)
        {   S.enterScope("Global"); 
            Console.WriteLine("\n--- TypeChecking ---");

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
            S.exitScope("Global");
            
            // Console.WriteLine("\n---TypeChecker:---");
            // Console.WriteLine($"Reached S.GetCurrentScope() {S.GetCurrentScope()} on stack\n");
            PrintSymbolTable();
            // Console.WriteLine("\n---Missing or bad typed declarations---");
            foreach (var item in errors)
            {
                // Console.WriteLine(item);
            }
            return new object();
        }

        public object Visit(FunctionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);

            return new object();
        }
        
        public object Visit(NumberIterationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilNode node)
        { 
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            // // Console.Write("***UntilNode"+stack.Peek()+"***");
            return new object();
        }
        
        public object Visit(BodyNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.Accept(this);
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.AssignedExpression.Accept(this);
            // if (!(node.AssignedExpression.CompileTimeType == "bool"))
            // {
            //     errors.Add(new SemanticError(node , $"VisitBoolDeclNode: {node.Id.Value} Assignment does not match declared type!"));
            // }
            return new object();
        }

        

        public object Visit(NumberDeclarationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            // Console.Write("NumberN\n");
            node.AssignedExpression.Accept(this);
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.AssignedExpression.Accept(this);
            return new object();
        }
        

        public object Visit(BoolExprIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            try
            {
                if (!(S.CheckDeclaredTypeOf(node.Id.Value) == "bool"))
                {
                    errors.Add(new SemanticError(node, $"visitBoolExprNode: {node.Id.Value} is not declared as bool: Typemismatch!"));
                }
            }catch
            {
                errors.Add(new SemanticError(node, $"visitBoolExprNode: {node.Id.Value} Has not been declared: Undeclared"));
            }

            return new object();

        }

        public object Visit(StatementNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());

            node.Accept(this);
            // Console.Write("StatementN\n");
            return new object();
        }
        
        
       //Unused Visitors
       public object Visit(AssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
           return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: Det ser ud til at boolassignment mangler en id
            // try
            // {
            //     if (S.CheckDeclaredTypeOf(node.Id.Value) != "bool")
            //     {
            //         errors.Add(new SemanticError(node, $"visitBoolAssignNode:{node.Id.Value} is not a bool : TypeMismatch! "));
            //     }
            // }catch
            // {
            //     errors.Add(new SemanticError(node, $"visitBoolAssignNode:{node.Id.Value}  has not been declared : Undeclared"));
            // }
            node.AssignedValue.Accept(this);
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
            Console.Write($"\n!!!!!FunctionCallAssignment Scope {S.GetCurrentScope()} | ");
            Console.WriteLine($"id:{node.Id.Value}--FuncName: {node.FunctionName.Value}");
            // try
            // {
                node.Id.Accept(this);
                Console.WriteLine($" CompiletimeType:"+node.Id.CompileTimeType);
                node.FunctionName.Accept(this);
                Console.WriteLine($" CompiletimeType:"+node.Id.CompileTimeType);

                if (node.Id.CompileTimeType != node.FunctionName.CompileTimeType)
                {
                    errors.Add(new SemanticError(node, $"visitFunctionCallAssignment:{node.Id.Value}:{node.Id.CompileTimeType} does not match type of function {node.FunctionName.Value}:{node.FunctionName.CompileTimeType}"));
                }
                //Console.WriteLine($"testing param count: {node.Parameters.Count}{node.Parameters[0].ToString()}");
                var declaredNode= (FunctionNode) S.GetElementById(node.FunctionName.Value);
                for (int i = 0 ; i< node.Parameters.Count ; i++)
                {
                    Console.WriteLine("testing param");
                    node.Parameters[i].Accept(this);
                    if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                    {
                        errors.Add(new SemanticError(node.Parameters[i],
                            $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                    }
                   
                }
                S.resetParameterCount();
                
            // }
            // catch
            // {
            //     node.CompileTimeType = "!Not Found!";
            //     errors.Add(new SemanticError(node, $"VisitIdNode: {node} has not been declared"));
            // }
            
            
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: der bør måske være en id på alle 

            try
            {
                // Console.WriteLine(
                //     "Jakob LHS =" + S.CheckDeclaredTypeOf(node.Id.Value) + "RHS = "+S.CheckDeclaredTypeOf(
                //         node.AssignedValue.Value));
                var LHSType = S.CheckDeclaredTypeOf(node.Id.Value);
                var RHSType = S.CheckDeclaredTypeOf(node.AssignedValue.Value);

                if (LHSType != RHSType)
                {
                    errors.Add(new SemanticError(node, $"visitIdAssignNode:{node.Id.Value}:{LHSType} does not match type of  AssignedValue:{node.AssignedValue.Value}:{RHSType} "));
                }
            }catch
            {
                errors.Add(new SemanticError(node, $"VisitIDAssignNode:{node.Id.Value} or AssignedValue has not been declared "));
            }
            //node.AssignedValue.Accept(this);
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: der bør måske være en id på alle  mathassignments
            //node.Id.Accept(this);
            // try
            // {
            //     if (S.CheckDeclaredTypeOf(node.Id.Value) != "number")
            //     {
            //         errors.Add(new SemanticError(node, $"visitMathAssignmentNode: {node.Id.Value} is not a number : TypeMismatch!"));
            //     }
            // }catch
            // {
            //     errors.Add(new SemanticError(node, $"visitMathAssignmentNode:{node.Id.Value}  has not been declared "));
            // }
            node.AssignedValue.Accept(this);
           
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: der bør måske være en id 
            // try
            // {
            //     if (S.CheckDeclaredTypeOf(node.Id.Value) != "point")
            //     {
            //         errors.Add(new SemanticError(node, $"visitMathAssignmentNode: {node.Id.Value} is not a point : TypeMismatch!"));
            //     }
            // }catch
            // {
            //     errors.Add(new SemanticError(node, $"VisitIDAssignNode:{node.Id.Value} or {node.AssignedValue.Value} has not been declared "));
            // }
            node.AssignedValue.Accept(this);
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            node.assignedValue.Accept(this);
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(CommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());

            node.Accept(this);
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Angle.Accept(this);
            node.From.Accept(this);
            foreach (var item in node.To)
            {
                item.Accept(this);
            }

            return new object();
        }

        public object Visit(DrawCommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: måske bør man lave symboltable opslaget her .
            node.Id.Accept(this);
            return new object();
        }

        public object Visit(IterationNode node)
        { 
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            //TODO:vurder om body skal besøges her.
           //node.Body.Accept(this);
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.From.Accept(this);
            foreach (var item in node.To)
            {
                item.Accept(this);
            }

            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //node.Accept(this);
            return new object();
        }
        

        public object Visit(AndComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: overvej om der skal påtegnes noget her
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.Accept(this);
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(NegationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: overvej om der skal gøres noget her
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            Console.Write($"Scope {S.GetCurrentScope()} | ");
            Console.WriteLine(node.ToString());
            try
            {
                if (S.CheckDeclaredTypeOf(node.FunctionName.Value)!= "bool")
                {
                    errors.Add(new SemanticError(node, $"VisitBoolFunctionCallNode: {node.FunctionName.Value} is not of type bool : Typemismatch! "));
                }
            }catch
            {
                errors.Add(new SemanticError(node, $"VisitBoolFunctionCallNode: {node.FunctionName.Value} has not been declared "));
            }
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
            S.increaseParameterCount();
            S.CheckDeclaredTypeOf(node.ParameterId.Value);
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            string foundType;
            //TODO: gør noget her Jakob, vi skal finde ud af at sætte de lokale param variabler i den kaldte funktion
            if (node.Expression != null)
            {
                
                node.Expression.Accept(this);
            }
            else
            {
                
                node.ParameterId.Accept(this);
            }

            // node.Expression.Accept(this);
            return new object();
        }

        
//Anvendes ikke
        public object Visit(IFunctionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);

           // node.LHS.Accept(this);
           // // Console.Write("+");
           // node.RHS.Accept(this);
           return new object();
        }

        public object Visit(DivisionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            // Console.WriteLine("!!!Infix 449");

            return new object();
        }

        public object Visit(MathIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());

            try
            {
                if (S.CheckDeclaredTypeOf(node.AssignedValueId.Value) != "number")
                {
                    errors.Add(new SemanticError(node, $"VisitMathIdNode: {node.AssignedValueId.Value} is not a number: TypeMismatch"));
                }
            }
            catch 
            {
                errors.Add(new SemanticError(node, $"VisitMathIdNode: {node.AssignedValueId.Value} Has not been declared: Undeclared"));
            }

            return "number";
        }

        public object Visit(MathNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            // // Console.Write(node.Value); 
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(PowerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            // Console.WriteLine("!!!PointFuncCall 503");
            try
            {
                if (S.CheckDeclaredTypeOf(node.FunctionName.Value) != "point")
                {
                    errors.Add(new SemanticError(node, $"VisitPointFunctionCallNode: {node.FunctionName.Value} is not a pointFunction: TypeMismatch"));
                }
            }
            catch 
            {
                errors.Add(new SemanticError(node, $"VisitPointFunctionCallNode: {node.FunctionName.Value} Has not been declared: Undeclared"));
            }
            
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            try
            {
                if (S.CheckDeclaredTypeOf(node.AssignedValue.Value) != "point")
                {
                    errors.Add(new SemanticError(node, $"VisitPointReferenceIdNode: {node.AssignedValue.Value} is not a pointRefference : TypeMismatch"));
                }
            }
            catch 
            {
                errors.Add(new SemanticError(node, $"VisitPointReferenceIdNode: {node.AssignedValue.Value} Has not been declared: Undeclared"));
            }
            
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            // Console.WriteLine("!!!PointRefference 522");
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            // Console.WriteLine("!!!ShapePointEndNode 529");
            node.Accept(this);

            return new object();
        }

        public object Visit(ShapePointReference node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            // Console.WriteLine("!!!ShapePointRefference 536");
            node.Accept(this);
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            // Console.WriteLine("!!!ShapePointRefNode 544");
            node.ShapeNameId.Accept(this);

            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.ShapeName.Accept(this);
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.XValue.Accept(this);
            node.YValue.Accept(this);
            return new object();
        }

        public object Visit(FalseNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            //TODO: gør noget med denne ??
            return new object();
        }

        public object Visit(IdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            try
            {
                node.CompileTimeType = S.CheckDeclaredTypeOf(node.Value);
                // Console.WriteLine("set CompiletimeType on IDNode");
            }
            catch
            {
                node.CompileTimeType = "!Not Found!";
                errors.Add(new SemanticError(node, $"VisitIdNode: {node.Value} has not been declared"));
            }

            return new object();
        }

        public object Visit(NumberNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            return new object();
        }

        public object Visit(TrueNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.XMax.Accept(this);
            node.YMax.Accept(this);
            node.XMin.Accept(this);
            node.YMin.Accept(this);
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.SizeProperty.Accept(this);
            return new object();
        }

        public object Visit(AstNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }
        object IVisitor.Visit(DrawNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            foreach (var item in node.drawCommands)
            {
                item.Id.Accept(this);
            }
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.Accept(this);
            return new object();
        }
        

        public object Visit(CoordinateXyValueNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            //TODO her kunne måske godt lægges et check om den besøgte node er et point.
            return new object();
        }
    }

}


   

