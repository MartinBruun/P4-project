using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
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
using OG.Compiler;

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
        {   
             S.enterScope("Global");
                            
            foreach (var item in node.FunctionDcls)
            {
                if (S.Add(item.Id.Value, item.ReturnType, item))
                {
                    item.Id.SymboltableAddress = S.GetSymboltableAddressInCurrentScope(item.Id.Value);
                    S.Add(item.Id.SymboltableAddress, item);
                }
                else
                {
                    errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+ item.Id.Value} Already exists in SymbolTable visitProgram"));
                }
                
                item.Accept(this);
            }
            
            foreach (var item in node.ShapeDcls)
            {
                if (S.Add(item.Id.Value, "shape",item))
                {
                    item.Id.SymboltableAddress = S.GetSymboltableAddressInCurrentScope(item.Id.Value);
                    S.Add(item.Id.SymboltableAddress, item);
                }
                else
                {
                    errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+item.Id.Value} Already exists in SymbolTable visitProgram"));
                }
                item.Accept(this);

            }
            S.exitScope("Global");
            
            return new object();
        }

        public object Visit(FunctionNode node)
        {
            

            S.enterScope(node.Id.Value);
            foreach (ParameterTypeNode param in node.Parameters)
            {
                param.Accept(this);
            }
            S.resetParameterCount();
            node.Body.Accept(this);


            if (node.ReturnValue != null)
            {
                node.ReturnValue.CompileTimeType = S.CheckDeclaredTypeOf(node.ReturnValue.Value);
                node?.ReturnValue?.Accept(this);

                DeclarationNode dcl = null;
                switch (node.CompileTimeType)
                {
                    case "number":
                        dcl = new NumberDeclarationNode(new IdNode("return"), node.ReturnValue);
                        break;
                    case"bool":
                        dcl = new BoolDeclarationNode(new IdNode("return"), node.ReturnValue);
                        break;

                    case"point":
                        dcl = new PointDeclarationNode(new IdNode("return"), node.ReturnValue);
                        break;
                }

                S.Add("return", node.ReturnType, dcl);
                dcl.Id.SymboltableAddress = S.GetSymboltableAddressFor("return");
            }
            
            S.exitScope(node.Id.Value);
            
            return new object();
        }
        
        public object Visit(ShapeNode node)
        {
        
            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);

            return new object();
        }
        
        public object Visit(NumberIterationNode node)
        {
            S.enterRepeatScope();
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilFunctionCallNode node)
        {
           

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }

        public object Visit(UntilNode node)
        { 
           

            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            return new object();
        }
        
        public object Visit(BodyNode node)
        {
           

            foreach (var item in node.StatementNodes)
            {
                item.Accept(this);
            }
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {
           
            node.Id.DeclaredValue = node.AssignedExpression;
            if (!S.Add(node.Id.Value, node.DeclaredType.ToString(),node.Id))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.Id.Value} Already exists in SymbolTable VisitDeclaration"));
            }
            node.Accept(this);
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
           

            if (!S.Add(node.Id.Value, "bool",node))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.Id.Value} Already exists in SymbolTable VisitBooldeclaration"));
            }
            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            S.Add(node.Id.SymboltableAddress, node);
            return new object();
        }

        

        public object Visit(NumberDeclarationNode node)
        {
            

            //Adds address in sym_tab
            if (!S.Add(node.Id.Value, "number",node))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.Id.Value} Already exists in SymbolTable VisitNumberDeclarationNode"));
            }

            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            S.Add(node.Id.SymboltableAddress, node);
            
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
           

            if (!S.Add(node.Id.Value, "point",node))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.Id.Value} Already exists in SymbolTable VisitPointDeclarationNode"));
            }
            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            S.Add(node.Id.SymboltableAddress, node);
            return new object();
        }

        public object Visit(BoolExprIdNode node)
        {
            node.Id.SymboltableAddress = S.GetSymboltableAddressFor(node.Id.Value);
            return new object();
        }
        

        public object Visit(StatementNode node)
        {
           

            node.Accept(this);
            return new object();
        }
        
        
       public object Visit(AssignmentNode node)
        {
            return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
           
            return new object();
        }

        public object Visit(FunctionCallAssignNode node)
        {
           
            return new object();
        }

        public object Visit(IdAssignNode node)
        {
            
           
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
           
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            
            node.Id.Accept(this);
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            
            string type;
            switch (node.ParameterType)
            {
                case ParameterTypeNodeExtractor.IOgTyped.OgType.Bool:
                    type = "bool";
                    break;
                case ParameterTypeNodeExtractor.IOgTyped.OgType.Number:
                    type = "number";
                    break;
                case ParameterTypeNodeExtractor.IOgTyped.OgType.Point:
                    type = "point";
                    break;
                default:
                    type = "Not set";
                    break;
            }

            S.increaseParameterCount();
            
            node.IdNode.CompileTimeType = type;
            if (!(S.Add(node.IdNode.Value, type,node)))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.IdNode.Value} Already exists in SymbolTable VistiParameterTypeNode"));
            }
            node.IdNode.SymboltableAddress = S.GetSymboltableAddressFor(node.IdNode.Value);
            
            //TODO: kan måske undværes
            //add node again now with its symboltableAddress included, may be redundant , it seems that node is stored in symboltable as a refferencetype!!!!!!!
            S.Add(node.IdNode.SymboltableAddress, node);

            return new object();
        }


        public object Visit(CommandNode node)
        {
            

            node.Accept(this);
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
           

            return new object();
        }

        public object Visit(DrawCommandNode node)
        {
           
            return new object();
        }

        public object Visit(IterationNode node)
        { 
           

           node.Body.Accept(this);
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
           

            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
           
            return new object();
        }
        

        public object Visit(AndComparerNode node)
        {
           
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
           
            return new object();
        }

        public object Visit(BoolNode node)
        {
           
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
           
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
           
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
           
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
           
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
           
            return new object();
        }

        public object Visit(NegationNode node)
        {
           
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
           
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
           
            return new object();
        }

        public object Visit(FunctionCallNode node)
        {
           

            return new object();
        }

        public object Visit(FunctionCallParameterNode node)
        {
           
            node.FunctionCallNode.Accept(this);
            
            return new object();
        }

        public object Visit(IFunctionCallNode node)
        {
            //TODO: !! UD den bruges vist ikke

           
            return new object();
        }

        public object Visit(MathFunctionCallNode node)
        {
            //TODO: overvej om vi skal kalde params og id her !!
           
            return new object();
        }

        public object Visit(ParameterNode node)
        {
            
            //TODO: BEMÆRK AT TYPEN ER SAT TIL PARAM!!!!!!DET SKAL ÆNDRES
            if (!(S.Add(node.ParameterId.Value, "param",node)))
            {
                errors.Add(new SemanticError(node,$"{S.GetCurrentScope()+"_"+node.ParameterId.Value} Already exists in SymbolTable VisitParameterNode"));
            }
            //TODO: det er ike sikkert at denne del behøves
            node.ParameterId.Accept(this);
           
            return new object();
        }

        
//Anvendes ikke
        public object Visit(IFunctionNode node)
        {
           
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            return new object();
        }

        public object Visit(DivisionNode node)
        {
           
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
           
            return new object();
        }

        public object Visit(MathIdNode node)
        {

            node.AssignedValueId.SymboltableAddress = S.GetSymboltableAddressFor(node.AssignedValueId.Value);
            return new object();
        }
        
        

      
        public object Visit(MultiplicationNode node)
        {
           
            return new object();
        }

        public object Visit(PowerNode node)
        {
           
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
           
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
           
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
           
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
            node.AssignedValue.SymboltableAddress = S.GetSymboltableAddressFor(node.AssignedValue.Value);
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
           
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {
           
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
           
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
           
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
           
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
            
            return new object();
        }

        public object Visit(FalseNode node)
        {
           
            return new object();
        }

        public object Visit(IdNode node)
        {
           
            return new object();
        }

        public object Visit(NumberNode node)
        {
           
            return new object();
        }

        public object Visit(TrueNode node)
        {
           
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
           
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
           
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
           
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
           
            return new object();
        }

        public object Visit(AstNode node)
        {
           
            return new object();
        }

        object IVisitor.Visit(DrawNode node)
        {
           
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
           
            return new object();
        }

        

        

        public object Visit(CoordinateXyValueNode node)
        {
           
            return new object();
        }
    }

}