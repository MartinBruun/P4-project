using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;

using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
{
    public class MachineSettingNodeExtractor : AstBuilderErrorInheritor<MachineSettingNode>
    {
        
        public override MachineSettingNode VisitMachineSettings(OGParser.MachineSettingsContext context)
        {
            if (context.machineModifications.workAreaModifications.workAreaModificationProperties
                .sizeProperty != null)
            {
                SizePropertyNode size = VisitSizePrpt(context.machineModifications.workAreaModifications
                    .workAreaModificationProperties
                    .sizeProperty);
                WorkAreaSettingNode workAreaSettings = new WorkAreaSettingNode(size);
                return workAreaSettings;
            }
            
            return  new WorkAreaSettingNode()
            {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }
        
        public override SizePropertyNode VisitSizePrpt(
            [NotNull] OGParser.SizePrptContext context)
        {
            MathNodeExtractor mathNodeExtractor = new MathNodeExtractor(SemanticErrors);
            MathNode xMin = mathNodeExtractor.ExtractMathNode(context.workAreaVariables.xmin);
            MathNode xMax = mathNodeExtractor.ExtractMathNode(context.workAreaVariables.xmax);
            MathNode yMin = mathNodeExtractor.ExtractMathNode(context.workAreaVariables.ymin);
            MathNode yMax = mathNodeExtractor.ExtractMathNode(context.workAreaVariables.ymax);


            return new SizePropertyNode(xMin, xMax, yMin, yMax)
            {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }
        

        public MachineSettingNodeExtractor(List<SemanticError> errs) : base(errs)
        {
        }
    }
}