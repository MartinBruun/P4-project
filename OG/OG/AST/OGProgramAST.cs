using System.Collections.Generic;
using System.Xml.Serialization;
using Antlr4.Runtime.Atn;
using OG.AST.MachineSettings;

namespace OG.AST
{
     internal class OGProgramAST
     { 
         public Dictionary<string, MachineSettingNode> Machinesettings { get; set; }
         public List<ShapeNode> DrawElements { get; set; }
         public List<FunctionDeclarationNode> FunctionDcls { get; set; }
         public List<ShapeDCLNode> ShapeDcls { get; set; }

         public OGProgramAST()
         {
             Machinesettings = new Dictionary<string, MachineSettingNode>();
             DrawElements    = new List<ShapeNode>();
             FunctionDcls    = new List<FunctionDeclarationNode>();
             ShapeDcls       = new List<ShapeDCLNode>();
         }

         public void Add(MachineSetting m)
         {
            // Machinesettings.Add(m);
         }

         public void Add(ShapeNode s)
         {
            DrawElements.Add(s);
         }
         public void Add(FunctionDeclarationNode f)
         {
            FunctionDcls.Add(f);
         }
         public void Add(ShapeDCLNode s)
         {
            ShapeDcls.Add(s);
         }
     }
    
        internal abstract class DeclarationNode: ASTNode
        { 
           public ASTNode LHS;
           public ASTNode RHS;
        }

         class ShapeDCLNode : ShapeNode
         {
             public string id;
             public string body;
         }

         class BoolianDCLNode: DeclarationNode
         {
             
         }

         class NumberDCLNode: DeclarationNode
         {
             
         }
         
         class PointDCLNode: DeclarationNode
         {
             
         }

         
         //__________________________________//ASSIGN
         
         
         abstract class AssignmentNode
         {
             public ASTNode LHS;
             public ASTNode RHS;
             
         }

         class VariableAssignmentNode:AssignmentNode
         {
             
         }

         class ProppertyAssignmentNode:AssignmentNode
         {
             
         }

         class IdAssignmentNode:AssignmentNode
         {
             
         }

         class BoolAssignmentNode:AssignmentNode
         {
             
         }

         class NumberAssignmentNode:AssignmentNode
         {
             
         }

         class PointAssignmentNode:AssignmentNode
         {
             
         }

         class StartPointAssignmentNode:AssignmentNode
         {
             
         }

         class EndPointAssignmentNode:AssignmentNode
         {
             
         }
         
         //_____________________________________________//REFF
         
         
         abstract class ReferenceNode
         {
             public ASTNode get;
         }

         class pointReferenceNode:ReferenceNode
         {
             
         }

         class StartPointReferenceNode:ReferenceNode
         {
             
         }

         class EndPointReferenceNode : ReferenceNode
         {
             
         }
         
         class CoordinateXYValueNode: ReferenceNode{
         
         }

         class ShapeNode : ReferenceNode
         {
             public string id;
             
         }
         
         //_____________________________________//

         
         
        abstract class ExpressionNode
        {
            
        }

        class MathExpressionNode : ExpressionNode
        {
            
        }

        class TermNode
        {
            
        }

        class FactorNode
        {
            
        }

        class AtomNode
        {
            
        }

        class BoolExpressionNode: ExpressionNode
        {
            
        }

        class NumberTupleNode
        {
            public int x;
            public int y;
            
        }

        class IfNode : ExpressionNode
        {
            
        }

        class ThenNode: ExpressionNode
        {
        }

//________________________________________________//COMMANDS

        abstract class CommandNode
        {
            
        }

        class movementCommandNode : CommandNode
        {
            
        }

        class LineCommandNode : CommandNode
        {
            
        }

        class CurveCommandNode : CommandNode
        {
            
        }

        class FromCommandNode : CommandNode
        {
            
        }
        class ToCommandNode : CommandNode
        {
            
        }

        class DrawCommandNode : CommandNode
        {
            
        }
        
//______________________________________//



    abstract class IterationCommandNode
    {
            
    }

    class NumberedIterationNode : IterationCommandNode
    {
        
    }

    class UntilIterationNode : IterationCommandNode
    {
        
    }
    

    //________________________________//FUNCTIONS
     
        abstract class FunctionNode
        {
            
        }

        class FunctionDeclarationNode : FunctionNode
        {
            
        }

        class ReturnFunctionDCLNode:FunctionNode
        {
            
        }

        class TypeWordNode
        {
            
        }

        class voidFunctionDCLNode:FunctionNode
        {
            
        }

        class ParameterDeclarationsNode
        {
            
        }

        class ParametersNode
        {
            
        }

        class FunctionCallNode
        {
            
        }

        class ParameterListNode
        {
            
        }

        class ReturnStatementNode
        {
            
        }
        

       //__________________________//Simple

       class NumberNode
       {
           
       }

       class BoolianValueNode
       {
           
       }
       

       class COMMENTNode
       {
           
       }

       class PlusNode
       {
           
       }

       class MinusNode
       {
           
       }

       class TimesNode
       {
           
       }

       class DivideNode
       {
           
       }

       class PowerNode
       {
           
       }

       class AndNode
       {
           
       }

       class OrNode
       {
           
       }

       class NotNode
       {
           
       }

       class GreaterThanNode
       {
           
       }

       class LessThanNode
       {
           
       }

       class EqualNode
       {
           
       }
       
        class ID: ASTNode
        {
            
        }
        
        class OpenScopeNode{
        
        }
        
        class CloseScopeNode{
        
        }

        class MachineSetting
        {
            public WorkareaNode workarea;
            
        }

        class WorkareaNode
        {
            public string Xmin;
            public string Xmax;

            public string Ymin;
            public string Ymax;

            public WorkareaNode(string xmin, string xmax, string ymin, string ymax)
            {
                Xmin = xmin;
                Xmax = xmax;
                Ymin = ymin;
                Ymax = ymax;
            }
        }

        class SizeNode
        {
            
        }
        
        
        
    }
