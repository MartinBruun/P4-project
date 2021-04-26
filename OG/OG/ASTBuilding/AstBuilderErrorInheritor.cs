using System.Collections.Generic;

namespace OG.ASTBuilding
{ 
    public abstract class AstBuilderErrorInheritor<NodeType>: OGBaseVisitor<NodeType>, IErrorable
    {
        
        /// <summary>
        /// Current errors can be used to append found errors to the list passed as argument. 
        /// </summary>
        /// <param name="currentErrors"></param>
        public List<SemanticError> SemanticErrors { get; set; }

        public AstBuilderErrorInheritor(List<SemanticError> errs)
        {
            SemanticErrors = errs;
        }
    }
}