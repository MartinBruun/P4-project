using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using Z.Expressions;

namespace OG.CodeGeneration
{
    public class PointReferenceGCodeTextEmitter : CodeEmitterErrorInheritor, IPointReferenceNodeVisitor
    {
        protected SymbolTable _symbolTable;
        public IGCodeCommand ResultCommand { get; protected set; }


        public PointReferenceGCodeTextEmitter(SymbolTable table, List<SemanticError> errs):base(errs)
        {
            _symbolTable = table;
        }
        
        /// <summary>
        /// TODO: Create function call visitor that evaluates function calls.
        /// </summary>
        /// <param name="node"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Visit(PointFunctionCallNode node)
        {
            IEnumerable<ParameterNode> parameters = node.Parameters;
            BodyNode body = node.Body;
        }

        /// <summary>
        /// TODO: Somehow create a point from an ID node
        /// </summary>
        /// <param name="node"></param>
        public void Visit(PointReferenceIdNode node)
        {
            
            //if id is reference to another id, what then?
            //if id is a tuple what then?
            //if id is function call what then?
            
            /*
             * if (node.isTuple){
             *   string[] pair = node.text.remove( '(', ') ).split(.);
             *   what if those strings are function calls??? FÅRK 
             * }
             *
             */
        }

        
        public void Visit(ShapeEndPointNode node)
        {
            throw new NotImplementedException();
            //This is actually how we can find a shape end point
            ShapeNode shape;
            List<StatementNode> statements = shape.Body.StatementNodes;
            statements.Reverse();
            foreach (StatementNode statement in statements.Where(statement => statement.Type == StatementNode.StatementType.CommandNode))
            {
                try
                {
                    CommandNode command = (CommandNode) statement;
                    if (command.TypeOfCommand == CommandNode.CommandType.MovementNode)
                    {
                        MovementCommandNode c = (MovementCommandNode) command;
                        c.To.Last().Accept(this);
                    }
                }
                catch (InvalidCastException e)
                {
                    continue;
                }
            }
        }

        public void Visit(ShapeStartPointNode node)
        {
            throw new NotImplementedException();
            ShapeNode shape; //= _symbolTable.getShape(node.shapename.text).getnode;
            List<StatementNode> statements = shape.Body.StatementNodes;
            foreach (StatementNode statement in statements.Where(statement => statement.Type == StatementNode.StatementType.CommandNode))
            {
                try
                {
                    CommandNode command = (CommandNode) statement;
                    if (command.TypeOfCommand == CommandNode.CommandType.MovementNode)
                    {
                        MovementCommandNode movement = (MovementCommandNode) command;
                        movement.To.First().Accept(this);
                    }
                }
                catch (InvalidCastException e)
                {
                    continue;
                }
            }
        }

     

        public virtual void Visit(TuplePointNode node)
        {
            double xVal = EvaluateMathString(node.XValue.Value);
            double yVal = EvaluateMathString(node.YValue.Value);

            string formattedX = xVal.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            string formattedY = yVal.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            yVal = double.Parse(formattedY);
            xVal = double.Parse(formattedX);

            

            ResultCommand = new GCodeCommandText($"G01 X{formattedX} Y{formattedY}\n");
        }

        protected double EvaluateMathString(string expression) 
        {
            return Eval.Execute<double>(expression);
        }
        
    }
}