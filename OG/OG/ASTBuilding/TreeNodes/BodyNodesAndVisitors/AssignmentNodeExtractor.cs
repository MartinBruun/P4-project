using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using Antlr4.Runtime;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BoolNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.Shapes
{
    public class AssignmentNodeExtractor : OGBaseVisitor<AssignmentNode>
    {

        public MathNodeExtractor _MathExtractor = new MathNodeExtractor();

        /// <summary>
        /// Visits an assignment context and creates an AssignmentNode from it.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AssignmentNode VisitAssignment(OGParser.AssignmentContext context)
        {
            AssignmentNode ResultNode = null;
            OGParser.VariableAssignmentContext variableAssignment = context.variableAssignment();
            OGParser.PropertyAssignmentContext propertyAssignment = context.propertyAssignment();
            
            
            
            //If it is a property assignment, create assignmentNode. If it is property assignment create AssignmentNode.
            if (variableAssignment != null && !variableAssignment.IsEmpty)
            {
                Console.WriteLine("");
                ResultNode = CreateAssignmentNode(variableAssignment);
            }
            //
            else if (propertyAssignment != null && !propertyAssignment.IsEmpty)
            {
                ResultNode = CreateAssignmentNode(propertyAssignment);
            }

            return ResultNode ?? null;
        }
        
        /// <summary>
        /// Visits a statement. If the statement is an assignment, create Assignment Node. Otherwise return null.
        /// </summary>
        /// <param name="currentStatement"></param>
        /// <returns>AssignmentNode or null</returns>
        public override AssignmentNode VisitStmt(OGParser.StmtContext currentStatement)
        {
            OGParser.AssignmentContext currentAssignment = currentStatement.assign;
            //If the current statement is an assignment, extract it and add to Assignments.
            if (currentAssignment != null && !currentAssignment.IsEmpty)
            {
                return VisitAssignment(currentAssignment);
            }

            return null;
        }


       
        private AssignmentNode CreateAssignmentNode(OGParser.VariableAssignmentContext context)
        {
            AssignmentNode result = null;
            try
            {
                OGParser.IdAssignContext idAssignContext = (OGParser.IdAssignContext) context;
                return CreateAssignmentNode(idAssignContext);
            }
            catch (InvalidCastException idCastException)
            {
                try
                {
                    OGParser.BoolAssignContext boolAssignContext = (OGParser.BoolAssignContext) context;
                    return CreateAssignmentNode(boolAssignContext);
                    throw;
                }
                catch (InvalidCastException numberCastException)
                {
                    try
                    {
                        OGParser.NumberAssignContext numberAssignContext = (OGParser.NumberAssignContext) context;
                        return CreateAssignmentNode(numberAssignContext);
                    }
                    catch (InvalidCastException numberAssignException)
                    {
                        try
                        {
                            OGParser.PointAssignContext pointAssignContext = (OGParser.PointAssignContext) context;
                            return CreateAssignmentNode(pointAssignContext);
                        }
                        catch (Exception pointAssignException)
                        {
                            throw new AstNodeCreationException("Could not cast to any variable assignment context." +
                                                               pointAssignException.Message);
                        }
                        
                    }
                }
            }

            throw new Exception("Something went terribly " +
                                "wrong trying to create Assignment Nodes. This created the exception: "
                                + context.GetText() + ".");

        }



        /// <summary>
        /// Creates an AssignmentNode from a property assignment statement.
        /// </summary>
        /// TODO Create MathNodeExtractor
        /// <param name="propAssign"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        private AssignmentNode CreateAssignmentNode(OGParser.PropertyAssignmentContext propAssign)
        {
            if (propAssign == null || propAssign.IsEmpty)
            {
                throw new AstNodeCreationException("Empty assignment context in property assignment.");
            }
            
            //If the math expression exists, create a simple math node containing its expression as string.
            if (propAssign.value != null && !propAssign.IsEmpty)
            {
                OGParser.MathExpressionContext mathExpression = propAssign.value;
                string value = mathExpression.GetText();
                Console.Write("Creating expression node from with text value {0} only",value);
                throw new NotImplementedException("Cannot create specificMathNodes yet.");
                return null;
                //return new PropertyAssignmentNode(new IDNode(propAssign.xyVal.Text),new MathNode(value));
            }


            throw new AstNodeCreationException("Invalid propertyAssignment");

        }
        private IdAssignNode CreateAssignmentNode(OGParser.IdAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.Text;
            Console.Write("\t\tCreating IDAssignmentNode from expression {0} = {1}.", id, value);
            
            return new IdAssignNode(new IDNode(id),new IDNode(value));
        }
        private BoolAssignmentNode CreateAssignmentNode(OGParser.BoolAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            Console.Write("\t\tCreating BoolAssignmentNode from expression {0} = {1}.", id, value);

            return new BoolAssignmentNode(new IDNode(id), new BoolNode(value));
        }
        private MathAssignmentNode CreateAssignmentNode(OGParser.NumberAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            Console.Write("\t\tCreating NumberAssignmentNode from expression {0} = {1}.", id, value);
            throw new NotImplementedException("Cannot create specificMathNodes yet.");

            //return new MathAssignmentNode(new IDNode(id), new MathNode(value));
        }
        
        private PointAssignmentNode CreateAssignmentNode(OGParser.PointAssignContext context)
        {
            return CreateAssignmentNode(context.pointAssignment());
        }

        private PointAssignmentNode CreateAssignmentNode(OGParser.PointAssignmentContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            Console.Write("\t\tCreating PointAssignmentNode from expression {0} = {1}.", id, value);

            return new PointAssignmentNode(new IDNode(id), new PointReferenceNode(value));
        }
    }

    public class MathNodeExtractor : OGBaseVisitor<MathNode>
    {
        public override MathNode VisitSingleTermExpr(OGParser.SingleTermExprContext context)
        {
            OGParser.TermContext termContext = context.child;
            return null;
        }

        public override MathNode VisitInfixAdditionExpr(OGParser.InfixAdditionExprContext context)
        {

            InfixMathNode node = null;
            OGParser.TermContext term = context.lhs;
            OGParser.MathExpressionContext rhsMath = context.rhs;
            OGParser.InfixMultExprContext multiplicationExpr = null;
            OGParser.SingleTermChildContext singleTermExpr = null;
            try
            {
               multiplicationExpr = (OGParser.InfixMultExprContext) term;
               VisitInfixMultExpr(multiplicationExpr);
            }
            catch (InvalidCastException e)
            {
                singleTermExpr = (OGParser.SingleTermChildContext) term;
                VisitSingleTermChild(singleTermExpr);
            }
            catch (SystemException e)
            {
                throw new AstNodeCreationException("Term context is cannot be converted to InfixMultExprContext" +
                                                   " or SingleTermChildContext. " + e.Message);
            }

            
            switch (context.op.Type)
            {
                case OGLexer.Plus_Minus:
                    if (context.op.Text == "+")
                    {
                       //node = new AdditionNode();
                    }
                    else if (context.op.Text == "-")
                    {
                        //node = new SubtractionNode();
                    }
                    
                    break;
                default:
                    throw new NotSupportedException();
            }
            return node;
        }



        public override MathNode VisitSingleTermChild(OGParser.SingleTermChildContext context)
        {

            OGParser.FactorContext factorContext = context.factor();
            OGParser.AtomContext lhsAtom = factorContext.lhs;
            OGParser.FactorContext rhsTerm = factorContext.rhs;
            OGParser.AtomContext singleChild = factorContext.child;
            var parenthesis


            throw new NotImplementedException("Creating MathNodes from SingleTermChildContext not implemented.");
            return null;

        }

        public override MathNode VisitInfixMultExpr(OGParser.InfixMultExprContext context)
        {
            throw new NotImplementedException("Creating MathNodes from InfixMultExprContext not implemented.");

            return base.VisitInfixMultExpr(context);
        }


    }

    public class PointAssignmentNode : AssignmentNode
    { 
        public PointReferenceNode AssignedValue { get; set; }

        public PointAssignmentNode(IDNode id, PointReferenceNode point) : base(id)
        {
            AssignedValue = point;
        }
    }
}