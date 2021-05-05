namespace OG.CodeGeneration
{
    public class GCodeCommandText : IGCodeCommand
    {
        public GCodeCommandText(string commandText)
        {
            CommandText = commandText;
        }

        public string CommandText { get; }

        public string CreateGCodeTextCommand()
        {
            return CommandText;
        }

        public static GCodeCommandText operator +(GCodeCommandText g1, GCodeCommandText g2)
        {
            return new GCodeCommandText(g1.CommandText + g2.CommandText);
        }
        
    }
}