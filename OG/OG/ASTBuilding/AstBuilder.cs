using System;
using System.Collections.Generic;
// using OG.ASTBuilding.MachineSettings;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;

namespace OG.ASTBuilding
{
    public class AstBuilder : TopNodeVisitor<ProgramNode>
    {
        private readonly DrawNodeListBuilder _drawNodeListBuilder;
        private readonly FunctionNodeListBuilder _functionNodeListBuilder;
        private readonly MachineSettingNodeExtractor _settingsNodeExtractor;
        private readonly ShapeNodeListBuilderExtractor _shapeNodeListBuilderExtractor;

        public AstBuilder() : base("program")
        {
            _shapeNodeListBuilderExtractor = new ShapeNodeListBuilderExtractor(SemanticErrors);
            _drawNodeListBuilder = new DrawNodeListBuilder(SemanticErrors);
            _functionNodeListBuilder= new FunctionNodeListBuilder(SemanticErrors);
            _settingsNodeExtractor = new MachineSettingNodeExtractor(SemanticErrors);
        }
        
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            MachineSettingNode machineSettingNode = null;
            List<DrawCommandNode> drawCommands = null;
            List<FunctionNode> functionNodes = null;
            List<ShapeNode> shapeNodes = null;
            
            

            if (context.settings != null)
            {
                //"  Visiting machine settings..."
                machineSettingNode = _settingsNodeExtractor.VisitMachineSettings(context.settings);
            }

            
            if (context.drawFunction != null)
            {
                //"  Visiting draw function..."
                drawCommands = _drawNodeListBuilder.VisitDraw(context.drawFunction);
            }
            if (context.functionsDeclarations != null)
            {
                //"  Visiting functions..."
                functionNodes = _functionNodeListBuilder.VisitFunctionDcls(context.functionsDeclarations);
            }

            if (context.shapeDeclarations != null)
            {
                //"  Visiting shapes..."
                shapeNodes = _shapeNodeListBuilderExtractor.VisitShapeDcls(context.shapeDeclarations);
            }

            return new ProgramNode(new DrawNode(drawCommands), functionNodes, shapeNodes, machineSettingNode);

        }

        public AstBuilder(string topNodeRuleText) : base(topNodeRuleText)
        {
        }
    }
}