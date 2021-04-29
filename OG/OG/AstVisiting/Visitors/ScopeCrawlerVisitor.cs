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
    public class ScopeCrawlerVisitor:IVisitor
    {
        private SymbolTable S = new SymbolTable();
        private List<SemanticError> errors = new List<SemanticError>();

        

        public ScopeCrawlerVisitor(Dictionary<string,AstNode> symbolTable)
        {
            S.Elements = symbolTable;
        }

        
        void PrintSymbolTable()
        {
            foreach (var item in S.Elements)
            {
                Console.WriteLine(item);
            }
        }
        
        
        public Dictionary<string, AstNode> GetSymbolTable()
        {
            return S.Elements;
        }

        public List<SemanticError> GetErrors()
        {
            return errors;
        }
        
        
        //TODO NOTE
        
        public object Visit(ProgramNode node)
        {
         S.enterScope("Global"); 
            Console.WriteLine("\n\n--- ScopeCrawlerVisitor ---");

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
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
        //TODO NOTE
        public object Visit(FunctionNode node)
        {
            
            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
        //TODO NOTE
        public object Visit(ShapeNode node)
        {
            S.enterScope(node.Id.Value);
            node.Body.Accept(this);
            S.exitScope(node.Id.Value);

Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
        //TODO NOTE
        public object Visit(NumberIterationNode node)
        {
            S.enterRepeatScope();
            node.Body.Accept(this);
            S.exitRepeatScope();
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        //TODO NOTE
        public object Visit(UntilFunctionCallNode node)
        {
            
            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        //TODO NOTE
        public object Visit(UntilNode node)
        { 
            S.enterRepeatScope();
            node.Predicate.Accept(this);
            node.Body.Accept(this);
            S.exitRepeatScope();
            
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        //TODO NOTE
        public object Visit(FunctionCallNode node)
        {
            
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                
                node.Parameters[i].Accept(this);
            }
            S.resetParameterCount();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
         
        //TODO NOTE
        public object Visit(FunctionCallParameterNode node)
        {
            S.increaseParameterCount();
            
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        //TODO NOTE
        public object Visit(FunctionCallAssignNode node)
        {
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                    
                node.Parameters[i].Accept(this);
                      
            }
            S.resetParameterCount();
               
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
        //TODO NOTE
        public object Visit(MathFunctionCallNode node)
        {
            
            for (int i = 0 ; i< node.Parameters.Count ; i++)
            {
                node.Parameters[i].Accept(this);
            }
            S.resetParameterCount();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
        
        
        
        
        
        
        public object Visit(BodyNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        
        public object Visit(DeclarationNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        public object Visit(BoolDeclarationNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        

        public object Visit(NumberDeclarationNode node)
        {
            
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PointDeclarationNode node)
        {
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        

        public object Visit(BoolExprIdNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();

        }

        public object Visit(StatementNode node)
        {
            
            

            node.Accept(this);
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        
        
       
       public object Visit(AssignmentNode node)
        {
            
             
            node.Accept(this);
           return new object();
        }

        public object Visit(BoolAssignmentNode node)
        {
           
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        
        

        public object Visit(IdAssignNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MathAssignmentNode node)
        {
            
            node.AssignedValue.Accept(this);
           
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PointAssignmentNode node)
        {
            
            node.AssignedValue.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PropertyAssignmentNode node)
        {
            
            
            

Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ParameterTypeNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();

        }

        public object Visit(CommandNode node)
        {
            
            

            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(CurveCommandNode node)
        {
            

Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(DrawCommandNode node)
        {
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(IterationNode node)
        { 
            
           
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(LineCommandNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MovementCommandNode node)
        {
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        

        public object Visit(AndComparerNode node)
        {
            
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(BoolComparerNode node)
        {
            
             
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(BoolNode node)
        {
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(BoolTerminalNode node)
        {
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(EqualsComparerNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(GreaterThanComparerNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(LessThanComparerNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MathComparerNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(NegationNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(OrComparerNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(BoolFunctionCallNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

         
      

        public object Visit(IFunctionCallNode node)
        {
            
             
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

         
       

        public object Visit(ParameterNode node)
        {
            
            
            

            if (node.Expression != null)
            {
                
                
            }
            else
            {
                node.ParameterId.Accept(this);
                
            }
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        

        public object Visit(IFunctionNode node)
        {
            
             
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(AdditionNode node)
        {
            
             
            
            
            
            
            
            
            
            
            
            
           
           
           
           return new object();
        }

        public object Visit(DivisionNode node)
        {
            
            
            
            
            
            
            
            
            
            
            
            
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(InfixMathNode node)
        {
            
             
            
            

Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MathIdNode node)
        {
            
            

        
        
        
        
        
        
        
        
        
        
        
         
        
        
        
        
        
        
        
        
        
        
         
        
             
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MathNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(MultiplicationNode node)
        {
         
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PowerNode node)
        {
         
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(SubtractionNode node)
        {
          
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(TerminalMathNode node)
        {
            
             
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PointFunctionCallNode node)
        {
           
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PointReferenceIdNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(PointReferenceNode node)
        {
            
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ShapeEndPointNode node)
        {
            
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ShapePointReference node)
        {
            
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ShapePointRefNode node)
        {
            
            node.ShapeNameId.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ShapeStartPointNode node)
        {
            node.ShapeName.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(TuplePointNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(FalseNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(IdNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(NumberNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(TrueNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(MachineSettingNode node)
        {
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ModificationPropertyNode node)
        {
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(SizePropertyNode node)
        {
            
            
            node.XMax.Accept(this);
            node.YMax.Accept(this);
            node.XMin.Accept(this);
            node.YMin.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(WorkAreaSettingNode node)
        {
            
            
            node.SizeProperty.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(AstNode node)
        {
            
             
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        object IVisitor.Visit(DrawNode node)
        {
            
            
            foreach (var item in node.drawCommands)
            {
                item.Id.Accept(this);
            }
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        public object Visit(ExpressionNode node)
        {
            
             
            node.Accept(this);
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
        

        public object Visit(CoordinateXyValueNode node)
        {
Console.WriteLine(S.GetCurrentScope());
            return new object();
        }
    }

}


   

