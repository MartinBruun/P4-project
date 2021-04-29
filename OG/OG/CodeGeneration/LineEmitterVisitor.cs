using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;
using OG.AstVisiting.Visitors;

namespace OG.CodeGeneration
{
    public class LineEmitterVisitor : ILineCommandNodeVisitor, IGCodeStringEmitterNotifier
    {
        private SymbolTable _symbolTable;

        private GCodeLinearMovementCommandCreator GCodeLineCreator { get; } = new GCodeLinearMovementCommandCreator();
        //private GCodeArithmeticCreator GCodeMathCommandCreator { get; } = new GCodeArithmeticCreator();
        private double ToolHeight { get; set; } = 100;
        
        public event CodeGenerationNotification CodeGenerationNotification;
        public ICollection<IGCodeCommand> GCodeCommands { get; set; }

        /// <summary>
        /// Loops through each generated GCodeCommmand object and emits the code.
        /// </summary>
        /// <returns></returns>
        public string Emit()
        {
            string result = "(Line command)\n";
            foreach (IGCodeCommand command in GCodeCommands)
            {
                CodeGenerationNotification?.Invoke(command.CreateGCodeTextCommand());
                result += command.CreateGCodeTextCommand();
            }

            return result;
        }

        /// <summary>
        /// TODO - Emitter skal bruge table til at slå op efter ID og values
        /// </summary>
        public LineEmitterVisitor(SymbolTable symbolTable)
        {
            this._symbolTable = symbolTable;
        }



        public void Visit(PointFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PointReferenceIdNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(ShapeEndPointNode node)
        {
            ShapeNode shape; //= _symbolTable.getShape(node.shapename.text).getnode;
            List<StatementNode> statements = shape.Body.StatementNodes;
            statements.Reverse();
            foreach (StatementNode statement in statements)
            {
                if (statement.Type == StatementNode.StatementType.CommandNode)
                {
                    //This is træls
                    try
                    {
                        CommandNode command = (CommandNode) statement;
                        if (command.TypeOfCommand == CommandNode.CommandType.MovementNode)
                        {
                            MovementCommandNode c = (MovementCommandNode) command;
                            c.To.Last().Accept(this);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (InvalidCastException e)
                    {
                        continue;
                    }
                }
            }
        }

        public void Visit(ShapeStartPointNode node)
        {
            ShapeNode shape; //= _symbolTable.getShape(node.shapename.text).getnode;
            List<StatementNode> statements = shape.Body.StatementNodes;
            foreach (StatementNode statement in statements)
            {
                if (statement.Type == StatementNode.StatementType.CommandNode)
                {
                    //This is træls
                    try
                    {
                        CommandNode command = (CommandNode) statement;
                        if (command.TypeOfCommand == CommandNode.CommandType.MovementNode)
                        {
                            MovementCommandNode c = (MovementCommandNode) command;
                            c.To.Last().Accept(this);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (InvalidCastException e)
                    {
                        continue;
                    }
                }
            }
        }

        public void Visit(TuplePointNode node)
        {
            double xVal = EvaluateMathString(node.XValue.Value);
            double yVal = EvaluateMathString(node.YValue.Value);
            
            GCodeCommands.Add(new GCodeCommandTextContainer($"G01 X{xVal} Y{yVal}"));
            
        }

        public void Visit(LineCommandNode node)
        {
            throw new NotImplementedException();
        }


        private GCodeCommandTextContainer SafeMoveto(double fromXValue, double fromYValue)
        {
            return MoveUp() + MoveTo(fromXValue, fromYValue) + MoveDown();
        }
        
        private GCodeCommandTextContainer MoveTo(double xValue, double yValue)
        {
            return new GCodeCommandTextContainer($"G1 X{xValue} Y{yValue} Z{ToolHeight} \n");
        }

        public GCodeCommandTextContainer MoveUp()
        {
            return new GCodeCommandTextContainer($"G0 Z{ToolHeight + 5} \n" );
        }

        public GCodeCommandTextContainer MoveDown()
        {
            return new GCodeCommandTextContainer($"G0 Z{ToolHeight - 5} \n" );
        }

        private  double EvaluateMathString(string expression) 
         {
            DataTable loDataTable = new DataTable();
            DataColumn loDataColumn = new DataColumn("Eval", typeof (double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double) (loDataTable.Rows[0]["Eval"]);
        }

      
    }


}