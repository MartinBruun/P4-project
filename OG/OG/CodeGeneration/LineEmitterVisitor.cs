using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.CodeGeneration
{
    public class LineEmitterVisitor : ILineCommandNodeVisitor, IGCodeStringEmitterNotifier
    {
        
        private GCodeLinearMovementCommandCreator GCodeLineCreator { get; } = new GCodeLinearMovementCommandCreator();
        private GCodeArithmeticCreator GCodeMathCommandCreator { get; } = new GCodeArithmeticCreator();
        public double ToolHeight { get; set; } = 100;
        
        public event CodeGenerationNotification CodeGenerationNotification;
        public ICollection<IGCodeCommand> GCodeCommands { get; set; }

        /// <summary>
        /// Loops through each generated GCodeCommmand object and emits the code.
        /// </summary>
        /// <returns></returns>
        public string Emit()
        {
            string result = string.Empty;
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
        public LineEmitterVisitor()
        {
            
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
            throw new NotImplementedException();
        }

        public void Visit(ShapeStartPointNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(TuplePointNode node)
        {
            double xVal = EvaluateMathString(node.XValue.Value);
            double yVal = EvaluateMathString(node.YValue.Value);
            
            GCodeCommands.Add(new GCodeCommand($"G01 X{xVal} Y{yVal}"));
            
        }

        public void Visit(LineCommandNode node)
        {
            node.From.Accept(this);

            foreach (PointReferenceNode toNode in node.To)
            {
                toNode.Accept(this);
            }
        }

        private GCodeCommand SafeMoveto(double fromXValue, double fromYValue)
        {
            return MoveUp() + MoveTo(fromXValue, fromYValue) + MoveDown();
        }
        
        private GCodeCommand MoveTo(double xValue, double yValue)
        {
            return new GCodeCommand($"G1 X{xValue} Y{yValue} Z{ToolHeight} \n");
        }

        public GCodeCommand MoveUp()
        {
            return new GCodeCommand($"G0 Z{ToolHeight + 5} \n" );
        }

        public GCodeCommand MoveDown()
        {
            return new GCodeCommand($"G0 Z{ToolHeight - 5} \n" );
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