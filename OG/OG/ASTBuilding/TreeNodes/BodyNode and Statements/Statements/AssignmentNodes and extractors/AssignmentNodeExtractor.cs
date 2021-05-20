using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using CoordinateXyValueNode = OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors.CoordinateXyValueNode;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors
{
    public class AssignmentNodeExtractor : AstBuilderErrorInheritor<AssignmentNode>
    {
        private readonly MathNodeExtractor _mathNodeExtractor;
        private readonly BoolNodeExtractor _boolNodeExtractor;
        private readonly PointReferenceNodeExtractor _pointReferenceNodeExtractor;


        public AssignmentNodeExtractor(List<SemanticError> errs) : base(errs)
        {
            _mathNodeExtractor = new MathNodeExtractor(errs);
            _boolNodeExtractor = new BoolNodeExtractor(errs);
            _pointReferenceNodeExtractor = new PointReferenceNodeExtractor(errs);
        }
        
        
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
                //Console.WriteLine(ResultNode);
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
                    //TODO: jeg tror der er noget galt her, det er som om jeg får FunctionName på begge ide'er
                    OGParser.FunctionCallAssignContext functionCallContext = ((OGParser.FunctionCallAssignContext) context);
                    FunctionCallNode x = new FunctionCallNodeExtractor(SemanticErrors).VisitFunctionCall(functionCallContext.funcCall);
                    IdNode id = new IdNode(functionCallContext.id.Text);
                    
                    return new FunctionCallAssignNode(id,x.FunctionName, x.Parameters) {
                        Line =context.Start.Line,
                        Column = context.Start.Column
                    };


                }
                catch (InvalidCastException )
                {
 
                }
                
                try
                {
                    OGParser.IdAssignContext idAssignContext = (OGParser.IdAssignContext) context;
                    return ExtractAssignmentNode(idAssignContext);
                    
                }
                catch (InvalidCastException )
                {
                }

                try
                {
                    OGParser.BoolAssignContext boolAssignContext = (OGParser.BoolAssignContext) context;
                    return ExtractAssignmentNode(boolAssignContext);
                }
                catch (InvalidCastException)
                {
                }

                try
                {
                    OGParser.NumberAssignContext numberAssignContext = (OGParser.NumberAssignContext) context;
                    return ExtractAssignmentNode(numberAssignContext);
                }
                catch (InvalidCastException )
                {
                }

                OGParser.PointAssignContext pointAssignContext = (OGParser.PointAssignContext) context;
                return ExtractAssignmentNode(pointAssignContext);
            }
            catch (InvalidCastException)
            {
                SemanticErrors.Add(new SemanticError(context.Start.Line, context.Start.Column,"Could not convert VariableAssignmentContext into " +
                                                   "IdAssignContext,boolAssignContext, NumberAssignContext, or PointAssignContext " + context.GetText())
                {
                    IsFatal = true
                });

                return null;
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
                CoordinateXyValueNode xyValue =
                    new CoordinateXyValueNode(new IdNode(propAssign.xyVal.id.Text), propAssign.xyVal.xy.Text);
                return new PropertyAssignmentNode(xyValue, mathNode) {
                    Line =propAssign.Start.Line,
                    Column = propAssign.Start.Column
                };
            }


            throw new AstNodeCreationException("Invalid propertyAssignment");

        }
        public IdAssignNode ExtractAssignmentNode(OGParser.IdAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.Text;
            //Console.Write("\t\tCreating IDAssignmentNode from expression {0} = {1}.", id, value);
            
            return new IdAssignNode(new IdNode(id),new IdNode(value)) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };
        }
        public BoolAssignmentNode ExtractAssignmentNode(OGParser.BoolAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            OGParser.BoolExpressionContext boolExprContext = context.value;
            return new BoolAssignmentNode(new IdNode(id), _boolNodeExtractor.ExtractBoolNode(boolExprContext)) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };

        }
        
        public MathAssignmentNode ExtractAssignmentNode(OGParser.NumberAssignContext context)
        {
            string id = context.id.Text;
            string value = context.value.GetText();
            //Console.Write("\t\tCreating NumberAssignmentNode from expression {0} = {1}.", id, value);

            MathNode mathNode = _mathNodeExtractor.ExtractMathNode(context.value);
            return new MathAssignmentNode(new IdNode(id), mathNode) {
                Line =context.Start.Line,
                Column = context.Start.Column
            };

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
                return new PointAssignmentNode(id, pointRefNode) {
                    Line =context.Start.Line,
                    Column = context.Start.Column
                };
            } else  if (endPointAssignmentContext != null && !endPointAssignmentContext.IsEmpty)
            {

                PointReferenceNode value = _pointReferenceNodeExtractor.VisitPointReference(endPointAssignmentContext.value);
                string id = endPointAssignmentContext.id.id.Text;
                return new PointAssignmentNode(new IdNode(id), value) {
                    Line =context.Start.Line,
                    Column = context.Start.Column
                };
            } else if (startPointAssignment != null && !startPointAssignment.IsEmpty)
            {
                PointReferenceNode value = _pointReferenceNodeExtractor.VisitPointReference(startPointAssignment.value);
                string id = startPointAssignment.id.id.Text;
                return new PointAssignmentNode(new IdNode(id), value) {
                    Line =context.Start.Line,
                    Column = context.Start.Column
                };
            }
            else
            {
                throw new AstNodeCreationException("PointAssignmentContext contained neither " +
                                                   "PointReferenceContext, EndpointAssignmentContext or" +
                                                   " StartPointAssigmentContext");
                ;
            }
            

        }
        
        
    }

   
}