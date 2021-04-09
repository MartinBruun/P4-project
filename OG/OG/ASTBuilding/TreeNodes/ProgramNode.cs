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
         public Dictionary<string, MachineSettingNode> MachineSettings { get; set; }
         public DrawNode drawNode;
         public List<FunctionNode> FunctionDcls { get; set; }
         public List<ShapeNode> ShapeDcls { get; set; }

         public ProgramNode(DrawNode draw, List<FunctionNode> functions, List<ShapeNode> shapes)
         {
             MachineSettings = new Dictionary<string, MachineSettingNode>();
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
