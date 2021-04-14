using System.Collections.Generic;
using OG.ASTBuilding;

namespace OG
{
    public interface IErrorable
    {
        List<SemanticError> SemanticErrors { get; set; }
    }
}