using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using OG;
using OG.AST;
using OG.AST.MathExpression;
using OG.AST.Terminals;


namespace OG.AST.MachineSettings
{
    public class MachineSettingsVisitor : OGBaseVisitor<Dictionary<string,MachineSettingNode>>, ISemanticErrorable
    {
        public string TopNode { get; set; } = "machineSettings";
        public  List<SemanticError> SemanticErrors { get; set; }
        private Dictionary<string,MachineSettingNode> MachineSettings { get; set; }
        private MathExpressionVisitor MathExpressionVisitor { get; }
        
        public MachineSettingsVisitor()
        {
            SemanticErrors = new List<SemanticError>();
            MathExpressionVisitor = new MathExpressionVisitor(SemanticErrors);
        }
        public MachineSettingsVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
            MathExpressionVisitor = new MathExpressionVisitor(semanticErrors);
        }
        
        public override Dictionary<string,MachineSettingNode> VisitMachineSettings([NotNull] OGParser.MachineSettingsContext context)
        {
            MachineSettings = new Dictionary<string,MachineSettingNode>();

            VisitChildren(context);
            
            return MachineSettings;
        }

        // public override Dictionary<string,MachineSettingNode> VisitNoMachineSettings([NotNull] OGParser.NoMachineSettingsContext context)
        // {
        //     return VisitChildren(context);
        // }

        public override Dictionary<string,MachineSettingNode> VisitMachineModifiers([NotNull] OGParser.MachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitEndOfMachineModifiers([NotNull] OGParser.EndOfMachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitWorkAreaModifier([NotNull] OGParser.WorkAreaModifierContext context)
        {
            // if MachineSettings.Contain(WorkAreaNode) -> Semantic Error!
            MachineSettings["WorkArea"] = new WorkAreaModificationNode();
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitWorkAreaModifierProperties(
            [NotNull] OGParser.WorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitEndOfWorkAreaModifierProperties(
            [NotNull] OGParser.EndOfWorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string, MachineSettingNode> VisitSizeProperty(
            [NotNull] OGParser.SizePropertyContext context)
        {
            WorkAreaModificationNode workNode = (WorkAreaModificationNode) MachineSettings["WorkArea"];
            if (workNode.SizeProperty != null)
            {
                IToken token = context.Start;
                SemanticErrors.Add(new SemanticError(token.Line,token.Column,
                    "WorkArea cant be designated size property more than ones.", context.GetText()));
            }
            
            NumberNode<int> xMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables.xmin);
            NumberNode<int> xMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables.xmax);
            NumberNode<int> yMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables.ymin);
            NumberNode<int> yMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables.ymax);

            SizePropertyNode sizeProperty = new SizePropertyNode(xMin, xMax, yMin, yMax);
            workNode.SizeProperty = sizeProperty;
            return VisitChildren(context);
        }

    }   
}