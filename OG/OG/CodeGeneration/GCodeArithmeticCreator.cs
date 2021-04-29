using System;
using System.Collections.Generic;
using System.Linq;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.CodeGeneration
{
    public class GCodeArithmeticCreator : IGCodeStringEmitter, CodeGeneration.IMathNodeVisitor
    {
        private bool IsLhs = true;
        private string _secondVariable = string.Empty;
        private string _thirdVariable = string.Empty;
        private GCodeCommandText _lhsCommandText;
        private GCodeCommandText _rhsCommandText;
            
            
        public ICollection<IGCodeCommand> GCodeCommands { get; set; }

        public IEnumerable<IGCodeCommand> GetGCodeCommands()
        {
           return GCodeCommands.Reverse();
        }
        
        public string Emit()
        {
            throw new NotImplementedException();
        }


        public object Visit(AdditionNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(NumberNode node)
        {
            if (IsLhs)
            {
                _lhsCommandText += new GCodeCommandText(node.NumberValue.ToString());
            }
            else
            {
                _rhsCommandText += new GCodeCommandText(node.NumberValue.ToString() + "\n");
            }
            IsLhs = !IsLhs;

            

            return null;
        }

        public object Visit(DivisionNode node)
        {
            GCodeCommandText res = new GCodeCommandText("#1 =");
            node.LHS.Accept(this);
            node.RHS.Accept(this);



        
            
            
            
            
            _lhsCommandText = null;
            _rhsCommandText = null;
            GCodeCommands.Add(res);
            return null;
        }

        public object Visit(InfixMathNode node)
        {
            throw new NotImplementedException();
            _lhsCommandText = null;
            _rhsCommandText = null;
        }

        public object Visit(MathIdNode node)
        {
            throw new NotImplementedException();
            _lhsCommandText = null;
            _rhsCommandText = null;
        }



        public object Visit(MultiplicationNode node)
        {
            throw new NotImplementedException();
            _lhsCommandText = null;
            _rhsCommandText = null;
        }

        public object Visit(PowerNode node)
        {
            throw new NotImplementedException();
            _lhsCommandText = null;
            _rhsCommandText = null;
        }

        public object Visit(SubtractionNode node)
        {
            
            throw new NotImplementedException();
            _lhsCommandText = null;
            _rhsCommandText = null;
        }

        public object Visit(MathFunctionCallNode node)
        {
            throw new NotImplementedException();
        }

        public object Visit(CoordinateXyValueNode node)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMathNodeVisitor
    {
        public Object Visit(AdditionNode node);
        public Object Visit(NumberNode node);
        public Object Visit(DivisionNode node);
        public Object Visit(MathIdNode node);
        public Object Visit(MultiplicationNode node);
        public Object Visit(PowerNode node);
        public Object Visit(SubtractionNode node);
        public Object Visit(MathFunctionCallNode node);
        public Object Visit(CoordinateXyValueNode node);
    }
}