using System.Collections.Generic;
using System.Xml.Serialization;
using Antlr4.Runtime.Atn;
using OG.AST.MachineSettings;

namespace OG.AST
{
    public class OGProgramAST
     { 
         public Dictionary<string, MachineSettingNode> MachineSettings { get; set; }
         public List<ShapeNode> DrawElements { get; set; }
         public List<FunctionDeclarationNode> FunctionDcls { get; set; }
         public List<ShapeDCLNode> ShapeDcls { get; set; }

         public OGProgramAST()
         {
             MachineSettings = new Dictionary<string, MachineSettingNode>();
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
    
    public abstract class DeclarationNode: ASTNode
        { 
           public ASTNode LHS;
           public ASTNode RHS;
        }

    public class ShapeDCLNode : ShapeNode
         {
             public string id;
             public string body;
         }

    public class BoolianDCLNode: DeclarationNode
         {
             
         }

    public class NumberDCLNode: DeclarationNode
         {
             
         }
         
    public class PointDCLNode: DeclarationNode
         {
             
         }

         
         //__________________________________//ASSIGN
         
         
         public abstract class AssignmentNode
         {
             public ASTNode LHS;
             public ASTNode RHS;
             
         }

         public class VariableAssignmentNode:AssignmentNode
         {
             
         }

         public class ProppertyAssignmentNode:AssignmentNode
         {
             
         }

         public class IdAssignmentNode:AssignmentNode
         {
             
         }

         public class BoolAssignmentNode:AssignmentNode
         {
             
         }

         public class NumberAssignmentNode:AssignmentNode
         {
             
         }

         public class PointAssignmentNode:AssignmentNode
         {
             
         }

         public class StartPointAssignmentNode:AssignmentNode
         {
             
         }

         public class EndPointAssignmentNode:AssignmentNode
         {
             
         }
         
         //_____________________________________________//REFF
         
         
         public abstract class ReferenceNode
         {
             public ASTNode get;
         }

         public class pointReferenceNode:ReferenceNode
         {
             
         }

         public class StartPointReferenceNode:ReferenceNode
         {
             
         }

         public class EndPointReferenceNode : ReferenceNode
         {
             
         }
         
         public class CoordinateXYValueNode: ReferenceNode{
         
         }

         public class ShapeNode : ReferenceNode
         {
             public string id;
             
         }
         
         //_____________________________________//

         
         
         public abstract class ExpressionNode
        {
            
        }

         public class MathExpressionNode : ExpressionNode
        {
            
        }

         public class TermNode
        {
            
        }

         public class FactorNode
        {
            
        }

         public class AtomNode
        {
            
        }

         public class BoolExpressionNode: ExpressionNode
        {
            
        }

         public class NumberTupleNode
        {
            public int x;
            public int y;
            
        }

         public class IfNode : ExpressionNode
        {
            
        }

         public class ThenNode: ExpressionNode
        {
        }

//________________________________________________//COMMANDS

    public abstract class CommandNode
        {
            
        }

    public class movementCommandNode : CommandNode
        {
            
        }

    public class LineCommandNode : CommandNode
        {
            
        }

    public class CurveCommandNode : CommandNode
        {
            
        }

    public class FromCommandNode : CommandNode
        {
            
        }
    public class ToCommandNode : CommandNode
        {
            
        }

    public class DrawCommandNode : CommandNode
        {
            
        }
        
//______________________________________//



    public abstract class IterationCommandNode
    {
            
    }

    public class NumberedIterationNode : IterationCommandNode
    {
        
    }

    public class UntilIterationNode : IterationCommandNode
    {
        
    }
    

    //________________________________//FUNCTIONS
     
    public abstract class FunctionNode
        {
            
        }

    public class FunctionDeclarationNode : FunctionNode
        {
            
        }

    public class ReturnFunctionDCLNode:FunctionNode
        {
            
        }

    public class TypeWordNode
        {
            
        }

    public class voidFunctionDCLNode:FunctionNode
        {
            
        }

    public class ParameterDeclarationsNode
        {
            
        }

    public class ParametersNode
        {
            
        }

    public class FunctionCallNode
        {
            
        }

    public class ParameterListNode
        {
            
        }

    public class ReturnStatementNode
        {
            
        }
        

       //__________________________//Simple

       public class NumberNode
       {
           
       }

       public class BoolianValueNode
       {
           
       }
       

       public class COMMENTNode
       {
           
       }

       public class PlusNode
       {
           
       }

       public class MinusNode
       {
           
       }

       public class TimesNode
       {
           
       }

       public class DivideNode
       {
           
       }

       public class PowerNode
       {
           
       }

       public class AndNode
       {
           
       }

       public class OrNode
       {
           
       }

       public class NotNode
       {
           
       }

       public class GreaterThanNode
       {
           
       }

       public class LessThanNode
       {
           
       }

       public class EqualNode
       {
           
       }
       
       public class ID: ASTNode
        {
            
        }
        
        public class OpenScopeNode{
        
        }
        
        public class CloseScopeNode{
        
        }

        public class MachineSetting
        {
            public WorkareaNode workarea;
            
        }

        public class WorkareaNode
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

        public class SizeNode
        {
            
        }
        
        
        
    }
