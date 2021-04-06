using System.Collections.Generic;
using System.Xml.Serialization;
using Antlr4.Runtime.Atn;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding
{
    public class ProgramNode : ASTNode
     { 
         public Dictionary<string, MachineSettingNode> MachineSettings { get; set; }
         public List<DrawNode> DrawElements { get; set; }
         public List<FunctionNode> FunctionDcls { get; set; }
         public List<ShapeNode> ShapeDcls { get; set; }

         public ProgramNode()
         {
             MachineSettings = new Dictionary<string, MachineSettingNode>();
             DrawElements    = new List<DrawNode>();
             FunctionDcls    = new List<FunctionNode>();
             ShapeDcls       = new List<ShapeNode>();
         }
     }
}
