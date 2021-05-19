using OG.ASTBuilding.TreeNodes;

namespace OG.ASTBuilding
{
    public class SemanticError
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public string Msg { get; set; }
        public string Context { get; set; }
        public AstNode Node { get; set; }
        public bool IsFatal { get; set; } = false;

        public SemanticError(int line, int column, string msg)
        {
            Line = line;
            Column = column;
            Msg = msg;
            Context = "!No context given!";
        }
        public SemanticError(int line, int column, string msg, string context)
        {
            Line = line;
            Column = column;
            Msg = msg;
            Context = context;
        }

        public SemanticError(AstNode node, string msg)
        {
            Msg = msg;
            Node = node;
            Line = node.Line;
            Column = node.Column;
        }

        public SemanticError(string msg)
        {
            Msg = msg;
            IsFatal = true;
        }

        public override string ToString()
        {
            if (IsFatal)
            {
                return $"FATAL ERROR : " + Msg;
            }
            else
            {
                var line = Line == 0 ? Node.Line : Line;
                var column = Column == 0 ? Node.Column : Column;

                return $"{Msg}\nLine: "+ (line != 0 ? $"{line}" : "?")+ $" Column: {column} at:\n--> {Context}";
            }
          
        }
        
    }
}