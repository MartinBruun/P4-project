namespace OG.AST
{
    public class SemanticError
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public string Msg { get; set; }
        public string Context { get; set; }

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

        public override string ToString()
        {
            return $"{Msg}\nLine: {Line} Column: {Column} at:\n--> {Context}";
        }
    }
}