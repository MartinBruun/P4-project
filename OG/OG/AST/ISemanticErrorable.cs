using System.Collections.Generic;

namespace OG.AST
{
    public interface ISemanticErrorable
    {
        public string TopNode { get; set; }
        List<SemanticError> SemanticErrors { get; set;}
    }
}