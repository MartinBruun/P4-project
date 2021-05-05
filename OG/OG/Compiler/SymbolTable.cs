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
        private int parameterCount = 0;
        private string currentScopeName = "0";

        public SymbolTable()
        {
            stack.Push("0");
        }
        
        /// <summary>
        /// The list of elements in the symboltable.
        /// </summary>
        public Dictionary<string, AstNode> Elements = new Dictionary<string,AstNode>();

        public void Accept(IVisitor visitor, AstNode visitable, string bodyId)
        {
           
            enterScope(bodyId);
            visitable.Accept(visitor);
            exitScope(bodyId);
        }
        
        
        /// <summary>
        /// Must be called when a scope is entered
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

        public void increaseParameterCount()
        {
            parameterCount++;
        }

        public void resetParameterCount()
        {
            parameterCount = 0;
        }
        
        /// <summary>
        /// Tilføjer et ID med tilhørende type i symboltable
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool Add(string id, string type, AstNode node)
        {
            Console.WriteLine($"pCount {parameterCount} adding {id} to symtbl, {node}");
            try
            {
                
                node.CompileTimeType = type;
                Elements.Add(currentScopeName+"_"+id, node);
                if ( parameterCount != 0)
                {
                    Elements.Add(currentScopeName+"_"+$"Param{parameterCount}",node);
                } 
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
            return Elements[stack.Peek()].CompileTimeType;
        }
        
        /// <summary>
        /// Returnerer navnet på det nuværende scope
        /// </summary>
        /// <returns></returns>
        public string GetCurrentScope()
        {
            return stack.Peek();
        }

        public string GetSymboltableAddressInCurrentScope(string id)
        {
            return GetCurrentScope() + $"_{id}";
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
            string IdInScope = parameterCount == 0 ? currentScopeName + "_" + id : currentScopeName+"_"+$"Param{parameterCount}" ;
            
                try
                {
                    Console.Write($"\nChecking {IdInScope}");
                    var result = Elements[IdInScope].CompileTimeType;
                    Console.WriteLine($": found {result}");
                    return result;

                }
                catch { }

                
                Stack<string> stackCopy1 = new Stack<string>(stack.ToArray());
                Stack<string> stackCopy = new Stack<string>(stackCopy1.ToArray());
                // Console.Write($"\nChecking {stackCopy.Peek()+ "_" + id}\n");
               //Alle containing scopes gennemløbes
               while (stackCopy.Count > 0)
                {
                    try
                    {
                        string name = stackCopy.Pop() + "_" + id;
                        Console.Write($"\n--nextScope {name}");
                        var result = Elements[name].CompileTimeType;
                        Console.WriteLine($": found {result}");
                        return result;
                    }
                    catch
                    {
                    }
                }
            //TODO: Lav en ordentlig exception type
            // return "!Not Found!";
            Console.Write($"\n--{id} has not been declared");
            throw new Exception($"After having checked the local scopes it turns out that the {id} is not in symboltable");
        }
        
        public string GetScopeAddressFor(string id)
        {
            string IdInScope = parameterCount == 0 ? currentScopeName + "_" + id : currentScopeName+"_"+$"Param{parameterCount}" ;
            
            try
            {
                Console.Write($"\nChecking {IdInScope}");
                var result = Elements[IdInScope].CompileTimeType;
                Console.WriteLine($": found {IdInScope}");
                return IdInScope;

            }
            catch { }

                
            Stack<string> stackCopy1 = new Stack<string>(stack.ToArray());
            Stack<string> stackCopy = new Stack<string>(stackCopy1.ToArray());
            // Console.Write($"\nChecking {stackCopy.Peek()+ "_" + id}\n");
            //Alle containing scopes gennemløbes
            while (stackCopy.Count > 0)
            {
                try
                {
                    string name = stackCopy.Pop() + "_" + id;
                    Console.Write($"\n--nextScope {name}");
                    var result = Elements[name].CompileTimeType;
                    Console.WriteLine($": found {name}");
                    return name;
                }
                catch
                {
                }
            }
            //TODO: Lav en ordentlig exception type
            // return "!Not Found!";
            Console.Write($"\n--{id} has not been declared");
            throw new Exception($"After having checked the local scopes it turns out that the {id} is not in symboltable");
        }
        
        
        public AstNode GetElementById(string id)
        {
            string IdInScope = currentScopeName + "_" + id;
            
            try
            {
                Console.Write($"\nChecking {currentScopeName + "_" + id}");
                var result = Elements[IdInScope];
                Console.WriteLine($": found {result}");
                return result;

            }
            catch { }

                
            Stack<string> stackCopy1 = new Stack<string>(stack.ToArray());
            Stack<string> stackCopy = new Stack<string>(stackCopy1.ToArray());
            // Console.Write($"\nChecking {stackCopy.Peek()+ "_" + id}\n");
            //Alle containing scopes gennemløbes
            while (stackCopy.Count > 0)
            {
                try
                {
                    string name = stackCopy.Pop() + "_" + id;
                    Console.Write($"\n--nextScope {name}");
                    var result = Elements[name];
                    Console.WriteLine($": found {result}");
                    return result;
                }
                catch
                {
                }
            }
            //TODO: Lav en ordentlig exception type
            // return "!Not Found!";
            Console.Write($"\n--{id} has not been declared");
            throw new Exception($"After having checked the local scopes it turns out that the {id} is not in symboltable");
        }
    }
}