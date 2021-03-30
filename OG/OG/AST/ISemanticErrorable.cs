using System.Collections.Generic;

namespace OG.AST
{
    public interface ISemanticErrorable
    {
        List<SemanticError> SemanticErrors { get; set;}
    }
}