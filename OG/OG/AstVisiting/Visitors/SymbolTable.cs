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

        /// <summary>
        /// Skal kaldes når et  scope entres
        /// 
        /// </summary>
        public void enterScope(string id)
        {
            level++;
            currentScopeName = level+"_"+ stack.Peek()+"_"+id;
            stack.Push(currentScopeName);
        }

        /// <summary>
        /// Skal kaldes når et scope exites
        /// 
        /// </summary>
        public void exitScope(string id)
        {
            level--;
            repeatLevel = 0;
            stack.Pop();
            currentScopeName = stack.Peek();
        }
        

        /// <summary>
        /// Skal kaldes når et repeat scope entres
        /// fordi repeatscopes er navnløse.
        /// </summary>
        public void enterRepeatScope()
        {
           string id = "repeat"+repeatLevel;
           repeatLevel++;
           level++;
           currentScopeName = level+"_"+ stack.Peek()+"_"+id;
           stack.Push(currentScopeName);
        }
        
        /// <summary>
        /// Skal kaldes når et repeat scope exites
        /// fordi repeatscopes er navnløse.
        /// </summary>
        public void exitRepeatScope()
        {
            level--;
            stack.Pop();
            currentScopeName = stack.Peek();
        }
        
        
        /// <summary>
        /// Tilføjer et ID med tilhørende type i symboltable
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returnerer typen på det sidst tilføjede ID
        /// </summary>
        /// <returns></returns>
        public string GetCurrentType()
        {
            return Elements[stack.Peek()];
        }
        
        /// <summary>
        /// Returnerer navnet på det nuværende scope
        /// </summary>
        /// <returns></returns>
        public string GetCurrentScope()
        {
            return stack.Peek();
        }
        
        /// <summary>
        /// Checker typen på et declareret id, hvis id'et ikke findes i current scope
        /// så kigges i containing scopes.
        /// ligger id'et heller ikke i Global scope så kastes en exception
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string CheckDeclaredTypeOf(string id)
        {
            string IdInScope = currentScopeName + "_" + id;
            
                try
                {
                    return Elements[IdInScope];
                }
                catch { }

                
                Stack<string> stackCopy = new Stack<string>(stack.ToArray());
                Console.Write($"\nChecking {stackCopy.Peek()}\n");
               //Alle containing scopes gennemløbes
               while (stackCopy.Count > 0)
                {
                    try
                    {
                        string name = stackCopy.Pop() + "_" + id;
                        Console.Write($"\nChecking nextScope {name}\n");
                        return Elements[name];
                    }
                    catch
                    {
                    }
                }
            //TODO: Lav en ordentlig exception type
            throw new Exception($"{id} is not in symboltable");
        }
    }
}