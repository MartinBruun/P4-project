namespace OG.AST
{
    public class SemanticError
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public string Msg { get; set; }

        public SemanticError()
        {
            
        }

        public override string ToString()
        {
            return $"\n{this.Msg}\nin  line: {this.Line}\nand column :{this.Column}\n";
        }
    }
}