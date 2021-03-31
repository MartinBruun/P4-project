using System;
using System.Collections.Generic;
using OG.AST;
using OG.AST.MachineSettings;
using OG.AST.Draw;
using OG.AST.Functions;
using OG.AST.Shapes;

namespace OG.AST

{
    public class ProgramVisitor:OGBaseVisitor<ProgramNode>, ISemanticErrorable
    {
        public ProgramVisitor()
        {
            
        }
        public ProgramVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }
        public List<SemanticError> SemanticErrors { get; set; } = new List<SemanticError>();
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            ProgramNode programAST = new ProgramNode();
            if (context.settings != null)
            {
                Console.WriteLine("machinesettings:  " + context.settings.GetText());
                programAST.MachineSettings = new MachineSettingVisitor().VisitMachineSettings(context.settings);
                Console.WriteLine(programAST.MachineSettings["WorkArea"]);
            }
            else
            {
                // Is technically a syntax error, and can therefore be omitted.
                // Token idToken = context.ID().getToken();
                SemanticError error = new SemanticError();
                error.Msg = "No Machine settings defined";
                SemanticErrors.Add(error);
            }

            if (context.drawFunction!= null)
            { 
                Console.WriteLine(context.drawFunction.GetText());
                programAST.DrawElements = new DrawVisitor().VisitDraw(context.drawFunction);
            }
            else
            {
                // Is technically a syntax error if this happens, so can be omitted (since the parser should have found it).
                SemanticError error = new SemanticError();
                error.Msg = "No Draw defined";
                SemanticErrors.Add(error);
            }
            
            
            if (context.functionsDeclarations!= null)
            {
                Console.WriteLine(context.functionsDeclarations.GetText());
                programAST.FunctionDcls = new FunctionVisitor().VisitFunctionDcls(context.functionsDeclarations);
            }
            
            
            if (context.shapeDeclarations!= null)
            {
                Console.WriteLine(context.shapeDeclarations.GetText());
                programAST.ShapeDcls = new ShapesVisitor().VisitShapeDcls(context.shapeDeclarations);
            }



            foreach (ShapeNode shape in programAST.DrawElements) //Jeg ved ikke om dette er muligt jeg ønsker at sammenligne shape og shapeDCL udfra id
            {
                if (programAST.ShapeDcls.Exists(sdcl => sdcl.ID == shape.ID )) // Override Equals method of IDNode
                {
                    SemanticError error = new SemanticError();
                    error.Msg = "shape:" + shape + " has not been declared";
                    SemanticErrors.Add(error);                
                }
            }
            SemanticError err = new SemanticError();
            err.Msg = "This is a test of semantic errors in visit program";
            SemanticErrors.Add(err);
            
            return programAST;

            return VisitChildren(context); // Stod der før, men tænker da vi skal returnere vores ProgramAST?
            return base.VisitProg(context);//lad os lige se hvilken return vi skal bruge
        }

      

        
    }
}