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
        public string TopNode { get; set; } = "program";
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
                Program.MachineSettings = MachineSettingVisitor.VisitMachineSettings(context.settings);
            }

            if (context.drawFunction!= null)
            {
                Program.DrawElements = DrawVisitor.VisitDraw(context.drawFunction);
            }

            if (context.functionsDeclarations!= null)
            {
                Program.FunctionDcls = FunctionDeclarationsVisitor.VisitFunctionDcls(context.functionsDeclarations);
            }
            
            if (context.shapeDeclarations!= null)
            {
                Program.ShapeDcls = ShapeDeclarationsVisitor.VisitShapeDcls(context.shapeDeclarations);
                CheckAllShapesDeclared();
            }

            return Program;

            return VisitChildren(context); // Stod der før, men tænker da vi skal returnere vores ProgramAST?
            return base.VisitProg(context);//lad os lige se hvilken return vi skal bruge
        }

        private void CheckAllShapesDeclared()
        {
            foreach (ShapeNode shape in Program.DrawElements) //Jeg ved ikke om dette er muligt jeg ønsker at sammenligne shape og shapeDCL udfra id
            {
                if (Program.ShapeDcls.Exists(sdcl => sdcl.ID == shape.ID )) // Override Equals method of IDNode
                {
                    SemanticErrors.Add(new SemanticError(3,3,$"shape: ({shape}) has not been declared"));                
                }
            }
        }
    }
}