// using OG.ASTBuilding.MachineSettings;

using System.Drawing;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.WorkAreaNodes
{
    public class SizePropertyNode : WorkAreaSettingNode
    {
        public MathNode XMin { get; set; }
        public MathNode XMax { get; set; }
        public MathNode YMin { get; set; }
        public MathNode YMax { get; set; }
        public MathNode ZMin { get; set; }
        public MathNode ZMax { get; set; }

        private void Initialize(
            MathNode xmin, MathNode xmax, 
            MathNode ymin, MathNode ymax, 
            MathNode zmin, MathNode zmax)
        {
            XMin = xmin;
            XMax = xmax;
            YMin = ymin;
            YMax = ymax;
            ZMin = zmin;
            ZMax = zmax;
        }
        
        public SizePropertyNode(
            MathNode xmin, MathNode xmax, 
            MathNode ymin, MathNode ymax)
        {
            Initialize(xmin, xmax, ymin, ymax, new NumberNode(0), new NumberNode(100));
        }
        public SizePropertyNode(SizePropertyNode node) : base(node)
        {
            Initialize(node.XMin,node.XMax,node.YMin,node.YMax,node.ZMin,node.ZMax);
        }

        public override string ToString()
        {
            return $"SizeProperty with XMin={XMin}, XMax={XMax},YMin={YMin},YMax={YMax},ZMin={ZMin},ZMax={ZMax}";
        }
        
        public override object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}