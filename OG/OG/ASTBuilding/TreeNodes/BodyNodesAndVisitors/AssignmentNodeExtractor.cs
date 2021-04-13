using System;
using System.Linq;
using OG.ASTBuilding.Draw;
using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;

namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class AssignmentNodeExtractor : OGBaseVisitor<AssignmentNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
        private readonly BoolNodeExtractor _boolNodeExtractor = new BoolNodeExtractor();
        private readonly PointReferenceNodeExtractor _pointReferenceNodeExtractor = new PointReferenceNodeExtractor();
        

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
                ResultNode = ExtractAssignmentNode(variableAssignment);
            }
            //
            else if (propertyAssignment != null && !propertyAssignment.IsEmpty)
            {
                ResultNode = ExtractAssignmentNode(propertyAssignment);
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
        public AssignmentNode ExtractAssignmentNode(OGParser.VariableAssignmentContext context)
        {
            try
            {
                try
                {
                    OGParser.FunctionCallAssignContext funcCallAssignContext =
                        (OGParser.FunctionCallAssignContext) context;
                    throw new NotImplementedException("Cannot create function call assignments yet.");


                }
                catch (InvalidCastException e)
                {
 
                }
                
                try
                {
                    OGParser.IdAssignContext idAssignContext = (OGParser.IdAssignContext) context;
                    return ExtractAssignmentNode(idAssignContext);
                }
                catch (InvalidCastException idCastException)
                {
                }

                try
                {
                    OGParser.BoolAssignContext boolAssignContext = (OGParser.BoolAssignContext) context;
                    return ExtractAssignmentNode(boolAssignContext);
                }
                catch (InvalidCastException numberCastException)
                {
                }

                try
                {
                    OGParser.NumberAssignContext numberAssignContext = (OGParser.NumberAssignContext) context;
                    return ExtractAssignmentNode(numberAssignContext);
                }
                catch (InvalidCastException numberAssignException)
                {
                }

                OGParser.PointAssignContext pointAssignContext = (OGParser.PointAssignContext) context;
                return ExtractAssignmentNode(pointAssignContext);
            }
            catch (InvalidCastException e)
            {
                throw new AstNodeCreationException("Could not convert VariableAssignmentContext into " +
                                                   "IdAssignContext,boolAssignContext, NumberAssignContext, or PointAssignContext ");
            }


        }
        
        /// <summary>
        /// Creates an AssignmentNode from a property assignment statement.
        /// </summary>
        /// <param name="propAssign"></param>
        /// <returns></returns>
        /// <exception cref="AstNodeCreationException"></exception>
        public AssignmentNode ExtractAssignmentNode(OGParser.PropertyAssignmentContext propAssign)
        {
            if (propAssign == null || propAssign.IsEmpty)
            {
                throw new AstNodeCreationException("Empty assignment context in property assignment.");
            }
            
            //If the math expression exists, create a simple math node containing its expression as string.
            if (propAssign.value != null && !propAssign.IsEmpty)
            {
                OGParser.MathExpressionContext mathExprContext = propAssign.value;
                MathNode mathNode = _mathNodeExtractor.ExtractMathNode(mathExprContext);
                CoordinateXYValueNode xyValue =
                    new CoordinateXYValueNode(new IdNode(propAssign.xyVal.id.Text), propAssign.xyVal.xy.Text);
                return new PropertyAssignmentNode(xyValue, mathNode);
            }


            throw new AstNodeCreationException("Invalid propertyAssignment");

        }
        public IdAssignNode ExtractAssignmentNode(OGParser.IdAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.Text;
            Console.Write("\t\tCreating IDAssignmentNode from expression {0} = {1}.", id, value);
            
            return new IdAssignNode(new IdNode(id),new IdNode(value));
        }
        public BoolAssignmentNode ExtractAssignmentNode(OGParser.BoolAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            OGParser.BoolExpressionContext boolExprContext = context.value;
            return new BoolAssignmentNode(new IdNode(id), _boolNodeExtractor.ExtractBoolNode(boolExprContext));

        }
        
        public MathAssignmentNode ExtractAssignmentNode(OGParser.NumberAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            Console.Write("\t\tCreating NumberAssignmentNode from expression {0} = {1}.", id, value);

            MathNode mathNode = _mathNodeExtractor.ExtractMathNode(context.value);
            return new MathAssignmentNode(new IdNode(id), mathNode);

        }
        
        public PointAssignmentNode ExtractAssignmentNode(OGParser.PointAssignContext context)
        {
            return ExtractAssignmentNode(context.pointAssignment());
        }

        public PointAssignmentNode ExtractAssignmentNode(OGParser.PointAssignmentContext context)
        {
            OGParser.PointReferenceContext pointReferenceContext = context.value;
            OGParser.EndPointAssignmentContext endPointAssignmentContext = context.endPointAssignment();
            OGParser.StartPointAssignmentContext startPointAssignment = context.startPointAssignment();

            if (pointReferenceContext != null && !pointReferenceContext.IsEmpty)
            {
                PointReferenceNode pointRefNode =  _pointReferenceNodeExtractor.VisitPointReference(pointReferenceContext);
                IdNode id = new IdNode(context.id.Text);
                return new PointAssignmentNode(id, pointRefNode);
            } else  if (endPointAssignmentContext != null && !endPointAssignmentContext.IsEmpty)
            {
                throw new NotImplementedException();
            } else if (startPointAssignment != null && !endPointAssignmentContext.IsEmpty)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new AstNodeCreationException("PointAssignmentContext contained neither " +
                                                   "PointReferenceContext, EndpointAssignmentContext or" +
                                                   " StartPointAssigmentContext");
                ;
            }

            return null;
        }

        

        
    }

    public class PointReferenceNodeExtractor : OGBaseVisitor<PointReferenceNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor = new MathNodeExtractor();
        public override PointReferenceNode VisitPointReference(OGParser.PointReferenceContext context)
        {
            if (context.tuple != null)
            {
                MathNode lhs = _mathNodeExtractor.ExtractMathNode(context.tuple.lhs);
                MathNode rhs = _mathNodeExtractor.ExtractMathNode(context.tuple.rhs);
                return new PointReferenceNode(context.GetText(), rhs, lhs);
            }
            else if (context.startPoint != null)
            {
                ShapePointRefNode shapePointRef = new ShapePointRefNode(
                    new IdNode(context.idPoint.Text),
                    ShapePointRefNode.PointTypes.StartPoint);
                return new PointReferenceNode(context.startPoint.GetText(), shapePointRef);
            }
            else if (context.endPoint != null)
            {
                ShapePointRefNode shapePointRef = new ShapePointRefNode(
                    new IdNode(context.idPoint.Text),
                    ShapePointRefNode.PointTypes.Endpoint);
                return new PointReferenceNode(context.endPoint.GetText(), shapePointRef);
            }
            else if (context.idPoint != null)
            {
                IdNode id = new IdNode(context.idPoint.Text);
                return new PointReferenceNode(context.GetText(), id);
            }
            else if (context.funcCall != null)
            {
                FunctionCallNode func = new FunctionCallExtractor().VisitFunctionCall(context.funcCall);
                return new PointReferenceNode(context.GetText(), func);
            }
            else
            {
                throw new AstNodeCreationException($"Node at {context.GetText()} could not be created at VisitPointReference.");
            }
        }
    }
}