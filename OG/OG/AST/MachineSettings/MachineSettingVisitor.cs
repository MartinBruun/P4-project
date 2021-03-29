using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG;
using OG.AST;
using OG.AST.MathExpression;
using OG.AST.Terminals;


namespace OG.AST.MachineSettings
{
    public class MachineSettingVisitor : OGBaseVisitor<ASTNode>
    {
        private MachineNode MachineNode { get; set; }
        private MathExpressionVisitor MathExpressionVisitor { get; }
        
        public MachineSettingVisitor()
        {
            MathExpressionVisitor = new MathExpressionVisitor();
        }
        
        public override ASTNode VisitMachineSettings([NotNull] OGParser.MachineSettingsContext context)
        {
            MachineNode = new MachineNode();

            VisitChildren(context);
            
            return MachineNode;
        }

        public override ASTNode VisitNoMachineSettings([NotNull] OGParser.NoMachineSettingsContext context)
        {
            return VisitChildren(context);
        }

        public override ASTNode VisitMachineModifiers([NotNull] OGParser.MachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override ASTNode VisitEndOfMachineModifiers([NotNull] OGParser.EndOfMachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override ASTNode VisitWorkAreaModifier([NotNull] OGParser.WorkAreaModifierContext context)
        {
            MachineNode.WorkArea = new WorkAreaModificationNode();
            return VisitChildren(context);
        }

        public override ASTNode VisitWorkAreaModifierProperties(
            [NotNull] OGParser.WorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override ASTNode VisitEndOfWorkAreaModifierProperties(
            [NotNull] OGParser.EndOfWorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override ASTNode VisitSizeProperty([NotNull] OGParser.SizePropertyContext context)
        {
            NumberNode<int> xMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables().xmin);
            NumberNode<int> xMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables().xmax);
            NumberNode<int> yMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables().ymin);
            NumberNode<int> yMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables().ymax);
            
            SizePropertyNode sizeProperty = new SizePropertyNode(xMin,xMax,yMin,yMax);
            MachineNode.WorkArea.SizeProperty = sizeProperty;
            return VisitChildren(context);
        }

        public override ASTNode VisitWorkAreaVariables([NotNull] OGParser.WorkAreaVariablesContext context)
        {
            return VisitChildren(context);
        }

    }   
}