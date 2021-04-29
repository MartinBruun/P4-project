using System;
using System.Runtime.CompilerServices;
using Antlr4.Runtime.Atn;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.PointReferences;

namespace OG.CodeGeneration
{


    public class GCodeLinearMovementCommandCreator
    {
        public double ToolHeight { get; set; } = 100;

        public double FromXValue;
        public double FromYValue;
        
        
        /// <summary>
        /// TODO NEEDS CONSTRUCTOR
        /// </summary>
        /// <param name="xValue"></param>
        /// <param name="yValue"></param>
        /// <returns></returns>
       

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


        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public GCodeCommand CreateCommand()
        {
            GCodeCommand x = SafeMoveto(FromXValue, FromYValue);
            throw new NotImplementedException();
            return null;
        }

        private GCodeCommand SafeMoveto(in double fromXValue, in double fromYValue)
        {
            return MoveUp() + MoveTo(fromXValue, fromYValue) + MoveDown();
        }

       
    }



    
}