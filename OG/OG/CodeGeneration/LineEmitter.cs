
using System;
using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting.Visitors;



namespace OG.CodeGeneration
{
    public class LineEmitter : CodeEmitterErrorInheritor, IGCodeStringEmitter
    {
        public ICollection<GCodeCommandText> ToCommands { get; set; } = new List<GCodeCommandText>();

        private GCodeCommandText FromPoint { get; set; }


        /// <summary>
        /// Loops through each generated GCodeCommmand object and emits the code.
        /// </summary>
        /// <returns></returns>
        public string Emit()
        {
            return ResultCommand.CommandText;
        }
        
        public void ClearResult()
        {
            ToCommands = new List<GCodeCommandText>();
        }

        public GCodeCommandText ResultCommand { get; set; }


        public LineEmitter(List<SemanticError> errs):base(errs)
        { }

        public void SetupGCodeResult(LineCommandNode node)
        {
            if (node.From is TuplePointNode t)
            {
                FromPoint = CreateLineGCodeCommand(t);
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                return;
            }
            
            foreach (PointReferenceNode pointReferenceNode in node.To)
            {
                if (pointReferenceNode is TuplePointNode tuple)
                {
                    ToCommands.Add(CreateLineGCodeCommand(tuple));
                }
                else
                {
                    SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A point reference was not reduced to Tuple!"){IsFatal = true});
                    return;
                }
            }

            CreateResult();
        }

        private void CreateResult()
        {
            ResultCommand = FromPoint;
            foreach (GCodeCommandText gCodeCommand in ToCommands)
            {
                ResultCommand += gCodeCommand;
            }
        }

        private GCodeCommandText CreateLineGCodeCommand(TuplePointNode node)
        {
            string formattedX ="";
            string formattedY ="";
            if (node.XValue is NumberNode x && node.YValue is NumberNode y)
            {
                formattedX = x.NumberValue.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
                formattedY = y.NumberValue.ToString(FormatStrings.DoubleFixedPoint).Replace(',','.');
            }
            else
            {
                SemanticErrors.Add(new SemanticError(node,"FATAL ERROR: A mathematical expression inside a point was not reduced to number node!"){IsFatal = true});
                return null;

            }
            return new GCodeCommandText($"G01 X{formattedX} Y{formattedY}\n");
        }

      
        
    }
}

