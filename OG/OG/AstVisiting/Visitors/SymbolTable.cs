using System;
using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.AstVisiting.Visitors
{
    public class SymbolTable
    {
        private Stack<string> stack = new Stack<string>();

        private int level = 0;
        private string currentScopeName = "0_";

        public SymbolTable()
        {
            stack.Push("0_");
        }
        public class SymbolTableItem
        {
            public string scopeName;
            public string type;
            
        }
        public Dictionary<string, string> Elements = new Dictionary<string, string>();

        public void enterScope(string id)
        {
            level++;
            currentScopeName = level+"_"+ stack.Peek()+"_"+id;
            stack.Push(currentScopeName);
        }

        public void exitScope(string id)
        {
            level--;
            currentScopeName = stack.Pop();
        }

        public string checkType(string id)
        {
            string variableId = currentScopeName + "_" + id;
            return Elements[variableId];
        }

        public bool Add(string id, string type)
        {
            try
            {
                Elements.Add(currentScopeName+"_"+id, type);
                return true;
            }
            catch (Exception e)
            {
                //Create semantic error
                return false;
            }
           
        }
    }
}