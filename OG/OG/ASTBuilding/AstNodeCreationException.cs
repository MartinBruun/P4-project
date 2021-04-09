using System;

namespace OG.ASTBuilding.Draw
{
    public class AstNodeCreationException : Exception
    {
        public AstNodeCreationException(string eMessage)
            : base("Something went wrong creating node\n" + eMessage)
        {
           
        }
        public AstNodeCreationException() 
            : base("Something went wrong creating node\n")
        {
           
        }
    }
}