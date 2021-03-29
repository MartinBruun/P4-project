using System.Collections.Generic;
using OG.AST;

namespace OG.AST.MachineSettings
{
    public class MachineNode : ASTNode
    {
        public WorkAreaModificationNode WorkArea { get; set; }

        public MachineNode()
        {
            WorkArea = null;
        }

        public override string ToString()
        {
            return "Machine Node with Modifiers:\n" + WorkArea.ToString();
        }
    }
}