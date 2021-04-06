using System;
using System.Collections.Generic;
using OG.ASTBuilding;

namespace OG
{
    public abstract class ErrorInheritorVisitor<T> : OGBaseVisitor<T>, IErrorable
    {
        
        /// <summary>
        /// Current errors can be used to append found errors to the list passed as argument. 
        /// </summary>
        /// <param name="currentErrors"></param>
        public List<SemanticError> SemanticErrors { get; set; }

        public ErrorInheritorVisitor(List<SemanticError> errs)
        {
            SemanticErrors = errs;
        }
    }

    public abstract class ErrorInheritorWriter<T> : ErrorInheritorVisitor<T>, IErrorPrinter
    {
        protected ErrorInheritorWriter(List<SemanticError> errs) : base(errs)
        {
        }

        public void PrintErrors()
        {
            foreach (SemanticError error in SemanticErrors)
            {
                Console.WriteLine(error);
            }
        }

        public void PrintError()
        {
            Console.WriteLine();
        }
    }

    public interface IErrorPrinter : IErrorable
    {
        public void PrintErrors();
    }
}