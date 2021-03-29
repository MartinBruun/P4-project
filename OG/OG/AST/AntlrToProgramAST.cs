using System;
using System.Collections.Generic;

namespace OG.gen
{
    public class AntlrToProgramAST:OGBaseVisitor<string>, ISemanticErrorable
    {
        public List<SemanticError> SemanticErrors { get; set; } = new List<SemanticError>();
        public override string VisitProg(OGParser.ProgContext context)
        {
            OGProgram programAST = new OGProgram();
            if (context.machineSettings != null)
            {
                Console.WriteLine("machinesettings:  " + context.machineSettings.GetText());
                // programAST.Machinesettings = new MachineSettingsVisitor().Visit(context.machineSettings);
            }
            else
            {
                // Token idToken = context.ID().getToken();
                SemanticError error = new SemanticError();
                error.Msg = "No Machine settings defined";
                SemanticErrors.Add(error);
            }

            if (context.drawFunction!= null)
            {
                Console.WriteLine(context.drawFunction.GetText());
                
            }
            else
            {
                SemanticError error = new SemanticError();
                error.Msg = "No Draw defined";
                SemanticErrors.Add(error);
            }
            
            
            if (context.functionsDeclarations!= null)
            {
                Console.WriteLine(context.functionsDeclarations.GetText());
            }
            
            
            if (context.shapeDeclarations!= null)
            {
                Console.WriteLine(context.shapeDeclarations.GetText());
            }


            
            foreach (ShapeDCLNode shape in programAST.DrawElements) //Jeg ved ikke om dette er muligt jeg ønsker at sammenligne shape og shapeDCL udfra id
            {
                if (programAST.ShapeDcls.Exists(sdcl => sdcl.id == shape.id ))
                {
                    SemanticError error = new SemanticError();
                    error.Msg = "shape:" + shape + " has not been declared";
                    SemanticErrors.Add(error);                
                }
            }
            SemanticError err = new SemanticError();
            err.Msg = "This is a test of semantic errors in visit program";
            SemanticErrors.Add(err);
            
            return VisitChildren(context) + "\n";

            return base.VisitProg(context);
        }

        public override string VisitShapeDeclarations(OGParser.ShapeDeclarationsContext context)
        {
            return base.VisitShapeDeclarations(context);
        }

        public override string VisitFunctionDeclarations(OGParser.FunctionDeclarationsContext context)
        {
            return base.VisitFunctionDeclarations(context);
        }

        public override string VisitMachineSettings(OGParser.MachineSettingsContext context)
        {
            return base.VisitMachineSettings(context);
        }

        public override string VisitDraw(OGParser.DrawContext context)
        {
            return base.VisitDraw(context);
        }

        
    }
}