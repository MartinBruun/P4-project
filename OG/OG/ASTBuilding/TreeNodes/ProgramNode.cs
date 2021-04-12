using System.Collections.Generic;
using System.Xml.Serialization;
using Antlr4.Runtime.Atn;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding
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
     }

    public abstract class AstStartNode : AstNode
    {
    }
}
