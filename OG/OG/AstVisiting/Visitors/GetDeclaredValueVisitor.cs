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
    public class GetDeclaredValueVisitor:IVisitor
    {
        
        private SymbolTable S = new SymbolTable();
        private List<SemanticError> errors = new List<SemanticError>();
        
        
        public GetDeclaredValueVisitor(Dictionary<string,AstNode> symbolTable)
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

        /// <summary>
        /// anvendes til at sætte en variabel --> på en anden variabel
        /// den slettes når den læses.
        /// </summary>
        string pointingAt
        {
            get
            {
                string temp = _pointingAt;
                _pointingAt = null;
                return temp;
            }
            set
            {
                _pointingAt = value;
            }
        }

        private string _pointingAt = null;
        

        //Visitors
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        public object Visit(ProgramNode node)
        {
        // S.enterScope("Global"); 
            Console.WriteLine("\n\n--- Retrieving Declared values ---");

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
        
        
        //TODO //ENTER--> Exit SCOPE
        //ENTER--> Exit SCOPE
        
        //Todo: ENTER REPEATSCOPE
        public object Visit(NumberIterationNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            // S.enterRepeatScope();
            node.Body.Accept(this);
            // S.exitRepeatScope();
            return new object();
        }

        //Todo: ENTER REPEATSCOPE
        public object Visit(UntilFunctionCallNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            // S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            // S.exitRepeatScope();
            return new object();
        }

        //Todo: ENTER REPEATSCOPE
        public object Visit(UntilNode node)
        { 
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 

            // S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            // S.exitRepeatScope();
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

        
      
        public object Visit(FunctionNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            foreach (var item in node.Parameters)
            {
                item.Accept(this);
            }
            node.Body.Accept(this);
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.Body.Accept(this);
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = _pointingAt;
                if (!S.Add(node.Id.SymboltableAddress, node))
                {
                    throw new Exception("Could not Save in Symboltable");
                }
            }
            // node.Id.Accept(this);
             
            return new object();
        }

        
        public object Visit(NumberDeclarationNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = _pointingAt;
                if (!S.Add(node.Id.SymboltableAddress, node))
                {
                    throw new Exception("Could not Save in Symboltable");
                }
            }
            node.Id.Accept(this);
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedExpression.Accept(this);
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = _pointingAt;
                if (!S.Add(node.Id.SymboltableAddress, node))
                {
                    throw new Exception("Could not Save in Symboltable");
                }
            }
            node.Id.Accept(this);
            
            return new object();
        }
        

        public object Visit(BoolAssignmentNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = pointingAt;
                S.Add(node.Id.SymboltableAddress, node);
            }

            return new object();
        }

//TODO: check lige det her igennem
        public object Visit(FunctionCallAssignNode node)
        {
                //For at nulstille pointingAt
                node.Id.Accept(this);
                node.FunctionName.Accept(this);
                node.Id.PointingAt = node.FunctionName.PointingAt;
                
                var declaredNode = (FunctionNode) node.FunctionName.DeclaredValue;// S.GetElementById(node.FunctionName.Value);
                for (int i = 0 ; i< node.Parameters.Count ; i++)
                {
                    node.Parameters[i].Accept(this);                    
                    node.Parameters[i].ParameterId = declaredNode.Parameters[i].IdNode;
                }
                
                if (_pointingAt != node.Id.PointingAt)
                {
                    node.Id.PointingAt = pointingAt;
                    S.Add(node.Id.SymboltableAddress, node);
                }
                
                return new object();
        }

        public object Visit(IdAssignNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = pointingAt;
                S.Add(node.Id.SymboltableAddress, node);
            }
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = pointingAt;
                S.Add(node.Id.SymboltableAddress, node);
            }            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            node.AssignedValue.Accept(this);
            if (_pointingAt != node.Id.PointingAt)
            {
                node.Id.PointingAt = pointingAt;
                S.Add(node.Id.SymboltableAddress, node);
            }           
            return new object();
        }

        
        //TODO: Find en måde at tilgå .x og .y
        public object Visit(PropertyAssignmentNode node)
        {
            //For at nulstille pointingAt
            node.Id.Accept(this);
            Console.WriteLine(((PointDeclarationNode)node.Id.DeclaredValue).AssignedExpression.Value);
            
            node.assignedValue.Accept(this);
            Console.WriteLine(node.assignedValue);
            
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            node.IdNode.Accept(this);
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

        public object Visit(DrawCommandNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            //TODO: måske bør man lave symboltable opslaget her .
            S.GetElementBySymbolTableAddress(node.Id.PointingAt); 
            node.Id.Accept(this);
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
        
        public object Visit(BoolExprIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.Id.Accept(this);
            return new object();

        }

        // TODO Måske crasher denne
        public object Visit(BoolNode node)
        {
            node.Accept(this);
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
            node.FunctionName.Accept(this);
            return new object();
        }

        //Todo: RESET PARAMCOUNT 
        public object Visit(FunctionCallNode node)
        {
            // Console.Write($"VisitFunctionCallNode  Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.FunctionName.Accept(this);
            
            //Checking parameters
            var declaredNode= (FunctionNode) S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                // Console.WriteLine("testing param");
                node.Parameters[i].Accept(this);
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
            node.ParameterId.Accept(this);
           
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
            var declaredNode= (FunctionNode) S.GetElementById(node.FunctionName.Value);
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                // Console.WriteLine("testing param");
                node.Parameters[i].Accept(this);
                if (declaredNode.Parameters[i].CompileTimeType != node.Parameters[i].CompileTimeType)
                {
                    errors.Add(new SemanticError(node.Parameters[i],
                        $"{node.FunctionName.Value}(Param#:{i}),  does not match type:{declaredNode.Parameters[i].CompileTimeType} in function declaration"));
                }
                   
            }
            S.resetParameterCount();
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
            else
            {
                node.CompileTimeType = "number";
            }
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
            else
            {
                node.CompileTimeType = "number";
            }
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
            node.AssignedValueId.Accept(this);

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
            if (node.LHS.CompileTimeType != "number" && node.RHS.CompileTimeType == "number")
            {
                errors.Add(new SemanticError(node, $"VisitMultiplicationNode: {node.Value} LHS RHS does not match type: Number:   TypeMismatch"));
            }
            else
            {
                node.CompileTimeType = "number";
            }
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
            else
            {
                node.CompileTimeType = "number";
            }
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
            else
            {
                node.CompileTimeType = "number";
            }
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
            node.FunctionName.Accept(this);
            foreach (var item in node.Parameters)
            {
                item.Accept(this);
            }
            node.Body.Accept(this);
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString());
            node.AssignedValue.Accept(this);
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            // Console.WriteLine("!!!PointRefference 522");
            node.Accept(this);
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

            return new object();
        }

        public object Visit(FalseNode node)
        {
            // Console.Write($"Scope {S.GetCurrentScope()} | ");
            // Console.WriteLine(node.ToString()); 
            node.CompileTimeType = "bool";
            return new object();
        }

        //TODO: konverter DeclaredValue så jeg kan få dens Id.pointingAt adresse ud.Jeg ved ikke om mit krumspring her flytter mig tættere
        public object Visit(IdNode node)
        {
            if (_pointingAt != node.PointingAt)
            {
                node.DeclaredValue = S.GetElementBySymbolTableAddress(node.SymboltableAddress);
                _pointingAt = node.PointingAt;
                node.DeclaredValue.Accept(this);
            }

            Console.WriteLine("\n#####This is stored: "+ node.DeclaredValue+" At Addr:"+node.SymboltableAddress);
           
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


   

