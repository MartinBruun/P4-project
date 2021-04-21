using System;
using System.Collections;

using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.AstVisiting.Visitors
{
    public class SymbolTable
    {
        private Stack<string> stack = new Stack<string>();

        private int level = 0;
        private int repeatLevel = 0;
        private string currentScopeName = "0";

        public SymbolTable()
        {
            stack.Push("0");
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
            repeatLevel = 0;
            stack.Pop();
            currentScopeName = stack.Peek();
        }
        

        public void enterRepeatScope()
        {
           string id = "repeat"+repeatLevel;
           repeatLevel++;
           level++;
           currentScopeName = level+"_"+ stack.Peek()+"_"+id;
           stack.Push(currentScopeName);
        }
        public void exitRepeatScope()
        {
            level--;
            stack.Pop();
            currentScopeName = stack.Peek();
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

        public string GetCurrentType()
        {
            return Elements[stack.Peek()];
        }
        
        public string GetCurrentScope()
        {
            return stack.Peek();
        }
        
        public string CheckDeclaredTypeOf(string id)
        {
            string IdInScope = currentScopeName + "_" + id;
            
                try
                {
                    return Elements[IdInScope];
                }
                catch { }

                
                Stack<string> stackCopy = new Stack<string>(stack.ToArray());
                Console.Write($"Checking {stackCopy.Pop()}");

               while (stackCopy.Count > 0)
                {
                    
                    try
                    {
                        string name = stackCopy.Pop() + "_" + id;
                        Console.Write($"Checking {name}");
                        return Elements[name];
                    }
                    catch
                    {
                    }
                }
            
            throw new Exception($"{id} is not in symboltable");
            return "Not ok";
        }
    }
}