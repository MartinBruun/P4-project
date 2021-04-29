using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.CodeGeneration
{
    public class LineEmitterNotifierVisitor : ILineCommandNodeVisitor, IGCodeStringEmitterNotifier
    {
        
        private GCodeLinearMovementCommandCreator GCodeLineCreator { get; } = new GCodeLinearMovementCommandCreator();
        private GCodeArithmeticCreator GCodeMathCommandCreator { get; } = new GCodeArithmeticCreator();
        
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
        public LineEmitterNotifierVisitor()
        {
            
        }

        public void Visit(IdNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PointFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(PointReferenceIdNode node)
        {
            throw new NotImplementedException();
        }

        public void Visit(IPointReferenceNode node)
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
            MathNode x = node.XValue;
        }

        public void Visit(LineCommandNode node)
        {
            //TODO We need to end up with just two booleans or at least mathematics operations
        }
    }
}