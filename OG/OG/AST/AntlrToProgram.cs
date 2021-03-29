using System;
using System.Collections.Generic;

namespace OG.gen
{
    internal class AntlrToProgram: OGBaseVisitor<OGProgram>
    {
        private List<string> variables = new List<string>();
        public override OGProgram VisitProg(OGParser.ProgContext context)
        {
            
            return base.VisitProg(context);
        }

        public override OGProgram VisitShapeDeclarations(OGParser.ShapeDeclarationsContext context)
        {
            return base.VisitShapeDeclarations(context);
        }

        public override OGProgram VisitFunctionDeclarations(OGParser.FunctionDeclarationsContext context)
        {
            return base.VisitFunctionDeclarations(context);
        }

        public override OGProgram VisitMachineSettings(OGParser.MachineSettingsContext context)
        {
            return base.VisitMachineSettings(context);
        }

        public override OGProgram VisitDraw(OGParser.DrawContext context)
        {
            return base.VisitDraw(context);
        }

        public override OGProgram VisitNumber(OGParser.NumberContext context)
        {
            
            Console.WriteLine(context.value.ToString());  
            return base.VisitNumber(context);
        }
        
        
    }
}