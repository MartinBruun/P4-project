using System.Collections.Generic;
using OG.AST;

namespace OG
{
    public interface IErrorable
    {
        List<SemanticError> SemanticErrors { get; set;}
    }
}