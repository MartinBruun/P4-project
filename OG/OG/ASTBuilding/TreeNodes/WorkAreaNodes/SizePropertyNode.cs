using System.Collections.Generic;
using System.Drawing;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;

namespace OG.ASTBuilding.MachineSettings
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

        public override string ToString()
        {
            return $"SizeProperty with XMin={XMin}, XMax={XMax},YMin={YMin},YMax={YMax},ZMin={ZMin},ZMax={ZMax}";
        }
    }
}