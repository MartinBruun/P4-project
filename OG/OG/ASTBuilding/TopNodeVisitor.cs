using System;
using System.Collections.Generic;
using System.Linq;

namespace OG.ASTBuilding
{
    public abstract class TopNodeVisitor<TNode> : AstBuilderErrorInheritor<TNode>, ITopNodeable
    {
        public TopNodeVisitor(string topNodeRuleText) : base(new List<SemanticError>())
        {
            if (!OGParser.ruleNames.Contains(topNodeRuleText))
            {
                throw new ArgumentException("No such rule name in OGParser ruleNames array");
            }

            TopNode = topNodeRuleText;
        }

        public TopNodeVisitor(): base(new List<SemanticError>())
        {
            if (!OGParser.ruleNames.Contains("program"))
            {
                throw new ArgumentException("No such rule name in OGParser ruleNames array");
            }
            TopNode = "program";
        }


        public string TopNode { get; set; }
    }

}