using System.Collections.Generic;
using System.Drawing;
using OG.AST;
using OG.AST.Terminals;

namespace OG.AST.MachineSettings
{
    public class SizePropertyNode : ModificationPropertyNode
    {
        public NumberNode<int> XMin { get; set; }
        public NumberNode<int> XMax { get; set; }
        public NumberNode<int> YMin { get; set; }
        public NumberNode<int> YMax { get; set; }
        public NumberNode<int> ZMin { get; set; }
        public NumberNode<int> ZMax { get; set; }

        private void Initialize(
            NumberNode<int> xmin, NumberNode<int> xmax, 
            NumberNode<int> ymin, NumberNode<int> ymax, 
            NumberNode<int> zmin, NumberNode<int> zmax)
        {
            XMin = xmin;
            XMax = xmax;
            YMin = ymin;
            YMax = ymax;
            ZMin = zmin;
            ZMax = zmax;
        }
        
        public SizePropertyNode()
        {
            Initialize(
                new NumberNode<int>(0), new NumberNode<int>(100), 
                new NumberNode<int>(0), new NumberNode<int>(100), 
                new NumberNode<int>(0), new NumberNode<int>(100)
                );
        }

        public SizePropertyNode(
            NumberNode<int> xmin, NumberNode<int> xmax, 
            NumberNode<int> ymin, NumberNode<int> ymax)
        {
            Initialize(xmin, xmax, ymin, ymax, new NumberNode<int>(0), new NumberNode<int>(100));
        }

        public override string ToString()
        {
            return $"    SizeProperty with XMin={XMin}, XMax={XMax},YMin={YMin},YMax={YMax},ZMin={ZMin},ZMax={ZMax}\n";
        }
    }
}