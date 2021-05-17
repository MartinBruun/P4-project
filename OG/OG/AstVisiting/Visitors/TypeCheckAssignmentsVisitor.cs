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
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        public object Visit(ProgramNode node)
        {   S.enterScope("Global"); 
            Console.WriteLine("\n\n--- TypeChecking ---\n\n");

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
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        public object Visit(FunctionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            foreach (var item in node.Parameters)
            {
                item.Accept(this);
            }
            node.Body.Accept(this);
            node.Id.Accept(this);
            node.ReturnValue?.Accept(this);
            if (node.ReturnValue != null && node.ReturnValue.CompileTimeType != node.Id.CompileTimeType)
            {
                errors.Add(new SemanticError(node,"return type mismatch: " + node.Id + "   " + node.ReturnValue));
            }
            
            S.exitScope(node.Id.Value);
            return new object();
        }
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        public object Visit(ShapeNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);

            return new object();
        }
        
        
        //Todo: ENTER REPEATSCOPE
        public object Visit(NumberIterationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            S.enterRepeatScope();
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        //Todo: ENTER REPEATSCOPE
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

        //Todo: ENTER REPEATSCOPE
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
            node.Id.Accept(this);//SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value));
            node.AssignedExpression.Accept(this);
            node.CompileTimeType = "bool";
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
            node.Id.Accept(this);//SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedExpression.Accept(this);
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.Id.Accept(this); //= S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedExpression.Accept(this);
            return new object();
        }
        

        public object Visit(BoolExprIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
           
                node.Id.Accept(this);
                node.CompileTimeType = "bool";
                if (node.Id.CompileTimeType != "bool")
                {
                    errors.Add(new SemanticError(node, $"visitBoolExprNode: {node.Id.Value} is not declared as bool: Typemismatch!"));
                }
                
            return new object();
        }

        // public object Visit(StatementNode node)
        // {
        //     // Console.Write($"Scope {S.GetCurrentScope()} | ");
        //     // Console.WriteLine(node.ToString());
        //
        //     node.Accept(this);
        //     // Console.Write("StatementN\n");
        //     return new object();
        // }
        
        
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
            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedValue.Accept(this);
            node.CompileTimeType = "bool";
            return new object();
        }

        //Todo: RESET PARAMCOUNT

        public object Visit(FunctionCallAssignNode node)
        {
            // Console.Write($"\n!!!!!FunctionCallAssignment Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine($"id:{node.Id.Value}--FuncName: {node.FunctionName.Value}");

            node.Id.Accept(this);
            node.FunctionName.Accept(this);

            if (node.Id.CompileTimeType != node.FunctionName.CompileTimeType)
            {
                errors.Add(new SemanticError(node, $"visitFunctionCallAssignment:{node.Id.Value}:{node.Id.CompileTimeType} does not match type of function {node.FunctionName.Value}:{node.FunctionName.CompileTimeType}"));
            }

            var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
            }

            node.CompileTimeType = node.Id.CompileTimeType;
            S.resetParameterCount();
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
                node.Id.Accept(this);
                node.AssignedValue.Accept(this);
              
                if (node.Id.CompileTimeType != node.AssignedValue.CompileTimeType)
                {
                    errors.Add(new SemanticError(node, $"visitIdAssignNode:{node.Id.Value}:{node.Id.CompileTimeType } does not match type of  AssignedValue:{node.AssignedValue.Value}:{node.AssignedValue.CompileTimeType} "));
                }

                node.CompileTimeType = node.Id.CompileTimeType;


            }catch
            {
                errors.Add(new SemanticError(node, $"VisitIDAssignNode:{node.Id.Value} or AssignedValue has not been declared "));
            }

            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedValue.SymboltableAddress = S.GetSymboltableAddressFor(node.AssignedValue.Value);
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
            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedValue.Accept(this);
            node.CompileTimeType = "number";
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
            node.Id.Accept(this);// = S.GetSymboltableAddressFor(node.Id.Value);
            node.AssignedValue.Accept(this);
            node.CompileTimeType = "point";
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            // Console.WriteLine("propertyAssignment: "+ node.Id.Value);
            // Console.WriteLine("propertyAssignment: "+ node.coordinateValueNode.Property);
            // Console.WriteLine("propertyAssignment: "+ node.assignedValue);
           
            node.Id.Accept(this);
            
            node.assignedValue.Accept(this);
            if (node.assignedValue.CompileTimeType != "number")
            {
                errors.Add(new SemanticError(node, $"VisitPropertyAssignmentNode: {node.assignedValue.Value} is not of type number : Typemismatch! "));
            }
            
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            node.IdNode.Accept(this);
            return new object();
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
            if (node.Id.CompileTimeType != "shape")
            {
                errors.Add(new SemanticError(node, $"{node.Id.Value} is not a shape"));
            }
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
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(BoolNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: overvej om der skal påtegnes noget her
            node.CompileTimeType = "bool";
            return new object();
        }

       
        public object Visit(EqualsComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(NegationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: overvej om der skal gøres noget her
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.CompileTimeType = "bool";
            node.FunctionName.Accept(this);
            if (node.FunctionName.CompileTimeType != "bool")
            {
                errors.Add(new SemanticError(node, $"VisitBoolFunctionCallNode: {node.FunctionName.Value} is not of type bool : Typemismatch! "));
            }
            var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
            }
           
            return new object();
        }

        //Todo: RESET PARAMCOUNT 
        public object Visit(FunctionCallNode node)
        {
            // Console.Write($"VisitFunctionCallNode  Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.FunctionName.Accept(this);
            
            //Checking parameters
            //TODO: her kan FunctionName.Declared...anvendes
            var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
            }
            S.resetParameterCount();
            return new object();
        }
        //Todo: INCREASE PARAMCOUNT 
        public object Visit(FunctionCallParameterNode node)
        {
            S.increaseParameterCount();
            node.CompileTimeType = S.CheckDeclaredTypeOf(node.ParameterId.Value);
            // Console.Write($"VisitFunctionCallParameterNode  Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            return new object();
        }

        //Todo: RESET PARAMCOUNT 
        public object Visit(MathFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.FunctionName.Accept(this);
            if (node.FunctionName.CompileTimeType != "number")
            {
                errors.Add(new SemanticError(node, $"{node.FunctionName}: is not of type number: typeMismatch"));
            }
            //Checking parameters
            var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                //node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
            }
            S.resetParameterCount();
            node.CompileTimeType = "number";
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            // Console.Write($"VisitParameterNode   Scope {S.GetCurrentScope()} | ");

            if (node.Expression != null)
            {
                node.Expression.Accept(this);
                node.CompileTimeType = node.Expression.CompileTimeType;
            }
            else
            {
                node.ParameterId.Accept(this);
                node.CompileTimeType = node.ParameterId.CompileTimeType;
                switch (node.CompileTimeType)
                {
                    case "number":
                        node.Expression = ((NumberDeclarationNode) node.ParameterId.DeclaredValue).AssignedExpression;
                        break;
                    case "point":
                        node.Expression = ((PointDeclarationNode) node.ParameterId.DeclaredValue).AssignedExpression;
                        break;
                    case "bool":
                        node.Expression = ((BoolDeclarationNode) node.ParameterId.DeclaredValue).AssignedExpression;
                        break;
                }
            }
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
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitAdditionNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
           node.CompileTimeType = "number";
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
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitDivisionNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            node.CompileTimeType = "number";
            return new object();
        }



        public object Visit(MathIdNode node)
        {
             // Console.Write($"Scope {S.GetCurrentScope()} | ");
             // Console.WriteLine(node.ToString());
             
            
            node.AssignedValueId.Accept(this);
            if (node.AssignedValueId.CompileTimeType != "number")
            {
                errors.Add(new SemanticError(node, $"VisitMathIdNode:  {node.AssignedValueId.Value} is not a number: TypeMismatch"));
            }

            node.CompileTimeType = "number";
            return new object();
        }

        public object Visit(MultiplicationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());

            node.LHS.Accept(this);
            node.RHS.Accept(this);
            if (node.LHS.CompileTimeType != "number" || node.RHS.CompileTimeType != "number")
            {
                errors.Add(new SemanticError(node, $"VisitMultiplicationNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            node.CompileTimeType = "number";
      
            return new object();
        }

        public object Visit(PowerNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitPowerNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            node.CompileTimeType = "number";

            return new object();
        }

        public object Visit(SubtractionNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.LHS.Accept(this);
            node.RHS.Accept(this);
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitSubtractionNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            node.CompileTimeType = "number";
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            // Console.WriteLine("!!!PointFuncCall 503");
            node.FunctionName.Accept(this);
            if (node.FunctionName.CompileTimeType != "point")
            {
                errors.Add(new SemanticError(node, $"{node.FunctionName}: is not of type number: typeMismatch"));
            }
            //Checking parameters
            var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
                //node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
            }
            S.resetParameterCount();
            node.CompileTimeType = "point";
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            node.AssignedValue.Accept(this);
            if (node.AssignedValue.CompileTimeType == "point")
            {
                node.CompileTimeType = "point";
            }
            else
            {
                errors.Add(new SemanticError(node, $"VisitPointReferenceIdNode: {node.AssignedValue.Value} is not a pointRefference : TypeMismatch"));
            }
            node.CompileTimeType = "point";
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
            if (node.XValue.CompileTimeType != node.YValue.CompileTimeType)
            {
                errors.Add(new SemanticError(node, $"{node.ToString()}: XYValue does not match type number: Typemismatch"));
            }
            node.CompileTimeType = "point";
            return new object();
        }

        public object Visit(FalseNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.CompileTimeType = "bool";
            return new object();
        }

        public object Visit(IdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            
            node.CompileTimeType = S.CheckDeclaredTypeOf(node.Value);
            node.DeclaredValue = S.GetElementById(node.Value);
            node.SymboltableAddress = S.GetSymboltableAddressFor(node.Value);
                
            if (node.SymboltableAddress == null)
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
            node.CompileTimeType = "number";
            return new object();
        }

        public object Visit(TrueNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.CompileTimeType = "bool";
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
            node.CompileTimeType = "number";
            //TODO Jeg er i tvivl om jeg må / kan sætte denne til number???
            return new object();
        }
    }

}


   

