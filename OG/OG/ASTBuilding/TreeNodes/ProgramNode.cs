using System.Collections.Generic;
// using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes
{
    public class ProgramNode : AstStartNode
     {
         public List<MachineSettingNode> MachineSettingNodes { get; set; }
         public DrawNode drawNode;
         public List<FunctionNode> FunctionDcls { get; set; }
         public List<ShapeNode> ShapeDcls { get; set; }

         public ProgramNode(DrawNode draw, List<FunctionNode> functions, List<ShapeNode> shapes, MachineSettingNode setting)
         {
             MachineSettingNodes = new List<MachineSettingNode> {setting};
             drawNode = draw;
             FunctionDcls    = functions;
             ShapeDcls = shapes;
         }
         
         public ProgramNode(DrawNode draw, List<FunctionNode> functions, List<ShapeNode> shapes, List<MachineSettingNode> settings)
         {
             MachineSettingNodes = new List<MachineSettingNode> ();
             MachineSettingNodes.AddRange(settings);
             drawNode = draw;
             FunctionDcls    = functions;
             ShapeDcls = shapes;
         }

         public ProgramNode()
         {
             
         }

       
         public override void Accept(IVisitor visitor)
         {
             visitor.Visit(this);        
         }
     }

    public abstract class AstStartNode : AstNode
    {
    }


}
