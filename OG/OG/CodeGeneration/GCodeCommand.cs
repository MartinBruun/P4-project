namespace OG.CodeGeneration
{
    public class GCodeCommand : IGCodeCommand
    {
        public GCodeCommand(string commandText)
        {
            CommandText = commandText;
        }

        public string CommandText { get; }

        public string CreateGCodeTextCommand()
        {
            return CommandText;
        }

        public static GCodeCommand operator +(GCodeCommand g1, GCodeCommand g2)
        {
            return new GCodeCommand(g1.CommandText + g2.CommandText);
        }
        
    }
}