using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using OG.ASTBuilding;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;
using Z.Expressions;

namespace OG.CodeGeneration
{
    public class LineEmitterVisitor : PointReferenceGCodeTextEmitter, ILineCommandNodeVisitor, IGCodeStringEmitterNotifier
    {
        public event CodeGenerationNotification CodeGenerationNotification;
        public ICollection<IGCodeCommand> ToCommands { get; set; } = new List<IGCodeCommand>();

        public PointReferenceGCodeTextEmitter ToPointGCodeCreater { get; }
        private PointReferenceGCodeTextEmitter FromPointContainer { get; set; }


        /// <summary>
        /// Loops through each generated GCodeCommmand object and emits the code.
        /// </summary>
        /// <returns></returns>
        public string Emit()
        {
            
            string result = FromPointContainer.ResultCommand.CreateGCodeTextCommand();
            foreach (IGCodeCommand command in ToCommands)
            {
                try
                {
                    CodeGenerationNotification?.Invoke(command.CreateGCodeTextCommand());
                    result += command.CreateGCodeTextCommand();
                }
                catch (Exception e)
                {
                    SemanticErrors.Add(new SemanticError("Something went wrong emitting G code."));
                }
                
            }

            return result;
        }

        
        public LineEmitterVisitor(SymbolTable symbolTable, List<SemanticError> errs):base(symbolTable, errs)
        {
            FromPointContainer = new PointReferenceGCodeTextEmitter(_symbolTable, SemanticErrors);
            ToPointGCodeCreater = new PointReferenceGCodeTextEmitter(symbolTable, errs);
        }

        public LineEmitterVisitor() : this(null,null)
        {
        }


        public void Visit(LineCommandNode node)
        {
            
            node.From.Accept(FromPointContainer);
            foreach (PointReferenceNode pointReferenceNode in node.To)
            {
                Console.WriteLine(pointReferenceNode.ToString());
                pointReferenceNode.Accept(ToPointGCodeCreater);
                ToCommands.Add(ToPointGCodeCreater.ResultCommand);
            }
        }
    } 
    
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

    /// <summary>
    /// Used to decide double precision formatting
    /// </summary>
    public static class FormatStrings
    {
        public const string DoubleFixedPoint = "0.###################################################################################################################################################################################################################################################################################################################################################";
    }

}