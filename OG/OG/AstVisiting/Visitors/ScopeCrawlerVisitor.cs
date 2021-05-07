using System;
using System.Collections.Generic;
using OG.ASTBuilding;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.AssignmentNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;
using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.DeclarationNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.PointReferences;
using OG.ASTBuilding.TreeNodes.TerminalNodes;
using OG.ASTBuilding.TreeNodes.WorkAreaNodes;

namespace OG.AstVisiting.Visitors
{
    public abstract class ScopeCrawlerVisitor
    {
        private SymbolTable S;
        //private List<SemanticError> errors = new List<SemanticError>();
        
        public ScopeCrawlerVisitor(Dictionary<string, AstNode> symbolTable)
        {
            S.Elements = symbolTable;
        }
        
        
        
        //TODO NOTE
        public object Visit(ProgramNode node, IVisitor externalvisitor)
        {
            S.enterScope("Global");
            Console.WriteLine("\n\n--- ScopeCrawlerVisitor ---");
            this.ActionsOn(node, externalvisitor);
            // foreach (var item in node.MachineSettingNodes)
            // {
            //     item.Accept(this);
            // }
            //
            //     node.drawNode.Accept(this);
            //
            //     foreach (var item in node.FunctionDcls)
            //         {
            //             item.Accept(this);
            //         }
            //     
            //         foreach (var item in node.ShapeDcls)
            //         {
            //             item.Accept(this);
            //         }
            S.exitScope("Global");

            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a ProgramNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(ProgramNode node, IVisitor withVisitor);


        //TODO NOTE
        public object Visit(FunctionNode node, IVisitor externalvisitor)
        {
            S.enterScope(node.Id.Value);
            this.ActionsOn(node, externalvisitor);
            S.exitScope(node.Id.Value);
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a FunctionNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(FunctionNode node, IVisitor withVisitor);



        //TODO NOTE
        public object Visit(ShapeNode node, IVisitor externalvisitor)
        {
            S.enterScope(node.Id.Value);
            this.ActionsOn(node, externalvisitor);
            S.exitScope(node.Id.Value);

            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a ShapeNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(ShapeNode node, IVisitor withVisitor);


        //TODO NOTE
        public object Visit(NumberIterationNode node, IVisitor externalvisitor)
        {
            S.enterRepeatScope();
            this.ActionsOn(node, externalvisitor);
            S.exitRepeatScope();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a NumberIterationNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(NumberIterationNode node, IVisitor withVisitor);

        //TODO NOTE
        public object Visit(UntilFunctionCallNode node, IVisitor externalvisitor)
        {

            S.enterRepeatScope();
            this.ActionsOn(node, externalvisitor);
            S.exitRepeatScope();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a UntilFunctionCallNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(UntilFunctionCallNode node, IVisitor withVisitor);

        //TODO NOTE
        public object Visit(UntilNode node, IVisitor externalvisitor)
        {
            S.enterRepeatScope();
            // node.Predicate.Accept(this);
            // node.Body.Accept(this);
            this.ActionsOn(node, externalvisitor);
            S.exitRepeatScope();

            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a UntilNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(UntilNode node, IVisitor withVisitor);

        //TODO NOTE
        public object Visit(FunctionCallNode node, IVisitor externalvisitor)
        {
            // for (int i = 0 ; i< node.Parameters.Count ; i++)
            // {
            //     node.Parameters[i].Accept(this);
            // }
            this.ActionsOn(node, externalvisitor);

            S.resetParameterCount();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a FunctionCallNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(FunctionCallNode node, IVisitor withVisitor);

        //TODO NOTE
        public object Visit(FunctionCallParameterNode node, IVisitor externalvisitor)
        {
            S.increaseParameterCount();
            this.ActionsOn(node, externalvisitor);
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a FunctionCallParameterNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(FunctionCallParameterNode node, IVisitor withVisitor);

        //TODO NOTE
        public object Visit(FunctionCallAssignNode node, IVisitor externalvisitor)
        {
            // for (int i = 0 ; i< node.Parameters.Count ; i++)
            // {
            //     node.Parameters[i].Accept(this);
            // }
            this.ActionsOn(node, externalvisitor);
            S.resetParameterCount();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a FunctionCallAssignNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(FunctionCallAssignNode node, IVisitor withVisitor);


        //TODO NOTE
        public object Visit(MathFunctionCallNode node, IVisitor externalvisitor)
        {

            // for (int i = 0 ; i< node.Parameters.Count ; i++)
            // {
            //     node.Parameters[i].Accept(this);
            // }
            this.ActionsOn(node, externalvisitor);
            S.resetParameterCount();
            Console.WriteLine(S.GetCurrentScope());
            return new object();
        }

        /// <summary>
        /// Defines the actions to be performed when visiting a MathFunctionCallNode
        /// </summary>
        /// <param name="node"></param>
        /// <param name="withVisitor"></param>
        public abstract void ActionsOn(MathFunctionCallNode node, IVisitor withVisitor);





    }
}


   

