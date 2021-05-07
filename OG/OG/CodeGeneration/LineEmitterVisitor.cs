using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

using OG.ASTBuilding;
using OG.ASTBuilding.MathExpression;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

using System.Linq;
using OG.ASTBuilding;
using OG.ASTBuilding.MathExpression;
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
        
        public void Visit(LineCommandNode node)
        {
            
            node.From.Accept(FromPointContainer);
            foreach (PointReferenceNode pointReferenceNode in node.To)
            {
                pointReferenceNode.Accept(ToPointGCodeCreater);
                ToCommands.Add(ToPointGCodeCreater.ResultCommand);
            }
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