using System.Collections.Generic;

namespace OG.gen
{
    public interface ISemanticErrorable
    {
        List<SemanticError> SemanticErrors { get; set;}
    }
}