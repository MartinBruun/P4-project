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
        public ProgramNode Program { get; set; }
        public List<SemanticError> SemanticErrors { get; set; }
        public MachineSettingsVisitor MachineSettingVisitor { get; set; }
        public DrawVisitor DrawVisitor { get; set; }
        public FunctionDeclarationsVisitor FunctionDeclarationsVisitor { get; set; }
        public ShapeDeclarationsVisitor ShapeDeclarationsVisitor { get; set; }
        public ProgramVisitor()
        {
            SemanticErrors = new List<SemanticError>();
            MachineSettingVisitor = new MachineSettingsVisitor(SemanticErrors);
            DrawVisitor = new DrawVisitor(SemanticErrors);
            FunctionDeclarationsVisitor = new FunctionDeclarationsVisitor(SemanticErrors);
            ShapeDeclarationsVisitor = new ShapeDeclarationsVisitor(SemanticErrors);
        }
        public ProgramVisitor(List<SemanticError> semanticErrors)
        {
            SemanticErrors = semanticErrors;
            MachineSettingVisitor = new MachineSettingsVisitor(SemanticErrors);
            DrawVisitor = new DrawVisitor(SemanticErrors);
            FunctionDeclarationsVisitor = new FunctionDeclarationsVisitor(SemanticErrors);
            ShapeDeclarationsVisitor = new ShapeDeclarationsVisitor(SemanticErrors);
        }
        
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            Program = new ProgramNode();
            if (context.settings != null)
            {
                Console.WriteLine("machinesettings context in ProgramVisitor.VisitProg:  " + context.settings.GetText());
                Program.MachineSettings = MachineSettingVisitor.VisitMachineSettings(context.settings);
                Console.WriteLine("\n\nWE ARE HERE\n\n");
                foreach (SemanticError error in this.SemanticErrors)
                {
                    Console.WriteLine("Error:" + error);
                }
            }
            else
            {
                // Is technically a syntax error, and can therefore be omitted.
                // Token idToken = context.ID().getToken();
                SemanticError error = new SemanticError(-8,-8,"No Machine settings defined");
                error.Msg = "No Machine settings defined";
                SemanticErrors.Add(error);
            }

            if (context.drawFunction!= null)
            { 
                Console.WriteLine(context.drawFunction.GetText());
                Program.DrawElements = DrawVisitor.VisitDraw(context.drawFunction);
            }
            else
            {
                // Is technically a syntax error if this happens, so can be omitted (since the parser should have found it).
                SemanticError error = new SemanticError(-6,-6,"No Draw defined");
                error.Msg = "No Draw defined";
                SemanticErrors.Add(error);
            }
            
            
            if (context.functionsDeclarations!= null)
            {
                Console.WriteLine(context.functionsDeclarations.GetText());
                Program.FunctionDcls = FunctionDeclarationsVisitor.VisitFunctionDcls(context.functionsDeclarations);
            }
            
            
            if (context.shapeDeclarations!= null)
            {
                Console.WriteLine(context.shapeDeclarations.GetText());
                Program.ShapeDcls = ShapeDeclarationsVisitor.VisitShapeDcls(context.shapeDeclarations);
            }

            foreach (ShapeNode shape in Program.DrawElements) //Jeg ved ikke om dette er muligt jeg ønsker at sammenligne shape og shapeDCL udfra id
            {
                if (Program.ShapeDcls.Exists(sdcl => sdcl.ID == shape.ID )) // Override Equals method of IDNode
                {
                    SemanticErrors.Add(new SemanticError(3,3,$"shape: ({shape}) has not been declared"));                
                }
            }
            SemanticErrors.Add(new SemanticError(-12,-32,"This is a test of semantic errors in visit program"));
            
            return Program;

            return VisitChildren(context); // Stod der før, men tænker da vi skal returnere vores ProgramAST?
            return base.VisitProg(context);//lad os lige se hvilken return vi skal bruge
        }
    }
}