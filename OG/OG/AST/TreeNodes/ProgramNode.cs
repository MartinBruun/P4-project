using System.Collections.Generic;
using System.Xml.Serialization;
using Antlr4.Runtime.Atn;
using OG.AST.MachineSettings;
using OG.AST.Draw;
using OG.AST.Functions;
using OG.AST.Shapes;

namespace OG.AST
{
    public class ProgramNode : ASTNode
     { 
         public Dictionary<string, MachineSettingNode> MachineSettings { get; set; }
         public List<ShapeNode> DrawElements { get; set; }
         public List<FunctionDeclarationNode> FunctionDcls { get; set; }
         public List<ShapeDeclarationNode> ShapeDcls { get; set; }

         public ProgramNode()
         {
             MachineSettings = new Dictionary<string, MachineSettingNode>();
             DrawElements    = new List<ShapeNode>();
             FunctionDcls    = new List<FunctionDeclarationNode>();
             ShapeDcls       = new List<ShapeDeclarationNode>();
         }
     }
}
