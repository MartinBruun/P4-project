using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentExtractor : ErrorInheritorVisitor<AssignmentNode>
    {
        public AssignmentExtractor(List<SemanticError> errs) : base(errs)
        {
        }

        public AssignmentNode Extract(OGParser.AssignmentContext assignment)
        {
            return Visit(assignment);
        }
        public override AssignmentNode VisitAssignment(OGParser.AssignmentContext context)
        {
            AssignmentNode ResultNode = null;
            OGParser.VariableAssignmentContext variableAssignment = context.variableAssignment();
            OGParser.PropertyAssignmentContext propertyAssignment = context.propertyAssignment();
            
            //If it is a property assignment, create assignmentNode. If it is property assignment create AssignmentNode.
            if (variableAssignment != null && !variableAssignment.IsEmpty)
            {
                throw new NotImplementedException("Extracting Assignmentnodes from variableAssignment is not yet implemented");
                //ResultNode = CreateAssignmentNode(variableAssignment);
            }
            //
            else if (propertyAssignment != null && !propertyAssignment.IsEmpty)
            {
                ResultNode = CreateAssignmentNode(propertyAssignment);
            }
            else
            {
                IToken token = context.Start;
                SemanticErrors.Add(new SemanticError(token.Line,token.Column, 
                    "Assignment was neither variable assignment or property assignment! Something went deeply wrong"));
            }
            return base.VisitAssignment(context);
        }



        private AssignmentNode CreateAssignmentNode(OGParser.PropertyAssignmentContext assignmentContext)
        {
            IToken XYReference = assignmentContext.xyVal;
            MathNode mathNode = null;
            
            OGParser.MathExpressionContext mathExpression = assignmentContext.value;
            
            //If the math expression exists, create a simple math node containing its expression as string.
            if (mathExpression != null && !mathExpression.IsEmpty)
            {
                mathNode = new MathNode(mathExpression.GetText());
            }
            else
            {
                SemanticErrors.Add(new SemanticError(XYReference.Line, XYReference.Column,
                    XYReference.Text + "is assigned to empty or empty math expression."));
            }

            return new(new IDNode(XYReference.Text), mathNode);
        }




    }
}