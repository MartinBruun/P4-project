using System;
using System.Collections.Generic;
using OG.AST;
using OG.AST.MachineSettings;
using OG.AST.Draw;
using OG.AST.Functions;
using OG.AST.Shapes;

namespace OG.AST
{
    public class AstBuilderVisitor :OGBaseVisitor<ProgramNode>, IGlobalNameCollissionErrorable, IUnnecessarySettingsErrorable
    {
        public string TopNode { get; set; } = "program";
        private ProgramNode Program { get; set; }
        public List<SemanticError> SemanticErrors { get; set; } = new List<SemanticError>();
        private MachineSettingsVisitor MachineSettingVisitor { get; set; }
        private DrawVisitor DrawVisitor { get; set; }
        private FunctionDeclarationsVisitor FunctionDeclarationsVisitor { get; set; }
        private ShapeDeclarationsVisitor ShapeDeclarationsVisitor { get; set; }

        
        public AstBuilderVisitor()
        {
            MachineSettingVisitor       = new MachineSettingsVisitor(SemanticErrors);
            DrawVisitor                 = new DrawVisitor(SemanticErrors);
            FunctionDeclarationsVisitor = new FunctionDeclarationsVisitor(SemanticErrors);
            ShapeDeclarationsVisitor    = new ShapeDeclarationsVisitor(SemanticErrors);
        }
        public AstBuilderVisitor(List<SemanticError> astBuilderSemanticErrors)
        {
            SemanticErrors              = astBuilderSemanticErrors;
            MachineSettingVisitor       = new MachineSettingsVisitor(SemanticErrors);
            DrawVisitor                 = new DrawVisitor(SemanticErrors);
            FunctionDeclarationsVisitor = new FunctionDeclarationsVisitor(SemanticErrors);
            ShapeDeclarationsVisitor    = new ShapeDeclarationsVisitor(SemanticErrors);
        }
        
        public override ProgramNode VisitProg(OGParser.ProgContext context)
        {
            Program = new ProgramNode();
            if (context.settings != null)
            {
                Program.MachineSettings = MachineSettingVisitor.VisitMachineSettings(context.settings);
            }

            if (context.drawFunction != null)
            {
                //Program.DrawElements = DrawVisitor.VisitDraw(context.drawFunction);
            }

            if (context.functionsDeclarations!= null)
            {
                Program.FunctionDcls = FunctionDeclarationsVisitor.VisitFunctionDcls(context.functionsDeclarations);
            }
            
            if (context.shapeDeclarations!= null)
            {
                Program.ShapeDcls = ShapeDeclarationsVisitor.VisitShapeDcls(context.shapeDeclarations);
            }
            
            
            
            return Program;
        }

        /*
        private void CheckAllUsedShapes()
        {
            
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

        private void CheckShapesNotInfinitelyRecursive()
        {
            
        }
        */


        public GlobalTableHandler handler { get; set; }
    }
}