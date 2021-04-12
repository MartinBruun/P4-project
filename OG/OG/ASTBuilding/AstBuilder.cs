using System;
using System.Collections.Generic;
using OG.AST.Functions;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Functions;
using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;

namespace OG.ASTBuilding
{
    public class AstBuilder : OGBaseVisitor<ProgramNode>, ITopNodeable
    {
        private DrawNodeListBuilder _drawNodeListBuilder = new DrawNodeListBuilder();
        private FunctionNodeListBuilder _functionNodeListBuilder = new FunctionNodeListBuilder();
        private MachineSettingNodeExtractor _settingsNodeExtractor = new MachineSettingNodeExtractor();
        public AstBuilder()
        {
           
        }
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            Console.WriteLine("Visiting settings...");
            MachineSettingNode machineSettingNode = _settingsNodeExtractor.VisitProg(context);
            Console.WriteLine(machineSettingNode);

            Console.WriteLine("Visiting draw function...");
            List<DrawCommandNode> drawCommands = _drawNodeListBuilder.VisitDraw(context.drawFunction);
            Console.WriteLine("\nVisiting functions...");
            List<FunctionNode> functionNodes = _functionNodeListBuilder.VisitFunctionDcls(context.functionsDeclarations);
            throw new NotImplementedException("Cannot create shape nodes yet");
            List<ShapeNode> shapeNodes = new List<ShapeNode>();


            DrawNode draw = new DrawNode(drawCommands);
            return null;
        }


        public string TopNode { get; set; } = "program";
    }

   
    
}