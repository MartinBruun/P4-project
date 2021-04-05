using System.Collections.Generic;
using System.Drawing;
using OG.AST;
using OG.AST.Terminals;

namespace OG.AST.MachineSettings
{
    public class SizePropertyNode : ModificationPropertyNode
    {
        public NumberNode XMin { get; set; }
        public NumberNode XMax { get; set; }
        public NumberNode YMin { get; set; }
        public NumberNode YMax { get; set; }
        public NumberNode ZMin { get; set; }
        public NumberNode ZMax { get; set; }

        private void Initialize(
            NumberNode xmin, NumberNode xmax, 
            NumberNode ymin, NumberNode ymax, 
            NumberNode zmin, NumberNode zmax)
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
                new NumberNode(0), new NumberNode(100), 
                new NumberNode(0), new NumberNode(100), 
                new NumberNode(0), new NumberNode(100)
                );
        }

        public SizePropertyNode(
            NumberNode xmin, NumberNode xmax, 
            NumberNode ymin, NumberNode ymax)
        {
            Initialize(xmin, xmax, ymin, ymax, new NumberNode(0), new NumberNode(100));
        }

        public override string ToString()
        {
            return $"SizeProperty with XMin={XMin}, XMax={XMax},YMin={YMin},YMax={YMax},ZMin={ZMin},ZMax={ZMax}";
        }
    }
}