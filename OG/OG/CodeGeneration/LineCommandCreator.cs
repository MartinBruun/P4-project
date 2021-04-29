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


        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public GCodeCommandTextContainer CreateCommand()
        {
            GCodeCommandTextContainer x = SafeMoveto(FromXValue, FromYValue);
            throw new NotImplementedException();
            return null;
        }

        private GCodeCommandTextContainer SafeMoveto(in double fromXValue, in double fromYValue)
        {
            return MoveUp() + MoveTo(fromXValue, fromYValue) + MoveDown();
        }

       
    }



    
}