using System.Collections.Generic;
using OG.ASTBuilding;

namespace OG.CodeGeneration
{
    public abstract class CodeEmitterErrorInheritor : ISemanticErrorable
    {
        public CodeEmitterErrorInheritor(List<SemanticError> errs)
        {
            SemanticErrors = errs;
        }
        public List<SemanticError> SemanticErrors { get; set; }
        public string TopNode { get; set; }
    }
}