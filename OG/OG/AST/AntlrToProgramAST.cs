using System;
using System.Collections.Generic;
using OG.AST;
using OG.AST.MachineSettings;
namespace OG.gen

{
    public class AntlrToProgramAST:OGBaseVisitor<ASTNode>, ISemanticErrorable
    {
        public AntlrToProgramAST(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
        }
        public List<SemanticError> SemanticErrors { get; set; } = new List<SemanticError>();
        public override ASTNode VisitProg(OGParser.ProgContext context)
        {
            OGProgram programAST = new OGProgram();
            if (context.settings != null)
            {
                Console.WriteLine("machinesettings:  " + context.settings.GetText());
                programAST.Machinesettings = new MachineSettingVisitor().VisitMachineSettings(context.settings);
                Console.WriteLine(programAST.Machinesettings["WorkArea"]);
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
            
            return VisitChildren(context) ;

            return base.VisitProg(context);//lad os lige se hvilken return vi skal bruge
        }

      

        
    }
}