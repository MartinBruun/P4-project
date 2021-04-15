using System;
using System.Collections.Generic;
using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;

namespace OG.ASTBuilding
{
    public class AstBuilder : TopNodeVisitor<ProgramNode>
    {
        private readonly DrawNodeListBuilder _drawNodeListBuilder = new DrawNodeListBuilder();
        private readonly FunctionNodeListBuilder _functionNodeListBuilder = new FunctionNodeListBuilder();
        private readonly MachineSettingNodeExtractor _settingsNodeExtractor = new MachineSettingNodeExtractor();
        private readonly ShapeNodeListBuilderExtractor _shapeNodeListBuilderExtractor = new ShapeNodeListBuilderExtractor();

        public AstBuilder() : base("program")
        {
            
        }
        
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            MachineSettingNode machineSettingNode = null;
            List<DrawCommandNode> drawCommands = null;
            List<FunctionNode> functionNodes = null;
            List<ShapeNode> shapeNodes = null;
            
            
            
            if (context.settings != null)
            {
                Console.WriteLine("Visiting machine settings...");
                machineSettingNode = _settingsNodeExtractor.VisitProg(context);
                Console.WriteLine(machineSettingNode);
            }

            
            if (context.drawFunction != null)
            {
                Console.WriteLine("Visiting draw function...");
                drawCommands = _drawNodeListBuilder.VisitDraw(context.drawFunction);
            }
            if (context.functionsDeclarations != null)
            {
                Console.WriteLine("\nVisiting functions...");
                functionNodes = _functionNodeListBuilder.VisitFunctionDcls(context.functionsDeclarations);
            }

            if (context.shapeDeclarations != null)
            {
                Console.WriteLine("Visiting shapes...");
                shapeNodes = _shapeNodeListBuilderExtractor.VisitShapeDcls(context.shapeDeclarations);
            }

            return new ProgramNode(new DrawNode(drawCommands), functionNodes, shapeNodes, machineSettingNode);

        }

        public AstBuilder(string topNodeRuleText) : base(topNodeRuleText)
        {
        }
    }
}